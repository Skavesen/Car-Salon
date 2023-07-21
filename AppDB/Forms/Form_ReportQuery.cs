using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Npgsql;
using System.IO;
using System.Reflection;

namespace AppDB.Forms
{
    public partial class Form_ReportQuery : MaterialForm
    {
        public Form_ReportQuery()
        {
            InitializeComponent();
        }

        private void Form_ReportQuery_Load(object sender, EventArgs e)
        {
            try
            { var sql = @"select *
                        from (select  (cl.lastname||' '||cl.firstname||' '||cl.patronymic) as fio, count(p.id) as avto, p.datee 
                         from purchases p, clients cl, car c 
                         where p.car_id = c.id and cl.id = p.client_id and p.payment_type = 'Безналичный'
                        group by p.datee, fio) new_table
                          Limit 5";
                var adapter = new NpgsqlDataAdapter(sql, Connection.connection());
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                Main.LocalizeHeaders(dataGridView1);
            }
            catch
            {
                Connection.con.Close();
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Documents Report (*.Xlsx)|*.xlsx|Excel Documents Report(*.xls)|*.xls", ValidateNames = true, FileName = "Имя документа", Title = "Выберите директорию куда вы хотите сохранить отчет в Excel" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string fn = sfd.FileName;
                    try
                    {
                        if (dataGridView1.Rows.Count != 0)
                        {
                            string[] Alphabit = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                              "N", "O","P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                            string Range_Letter = Alphabit[dataGridView1.Columns.Count];
                            string Range_Row = (dataGridView1.Rows.Count + 1).ToString();
                            if (File.Exists(fn))
                            {
                                File.Delete(fn);
                            }
                            Excel.Application oApp;
                            Excel.Worksheet oSheet;
                            Excel.Workbook oBook;

                            oApp = new Excel.Application();
                            oBook = oApp.Workbooks.Add();
                            oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);
                            for (int x = 0; x < dataGridView1.Columns.Count; x++)
                            {
                                // создание столбцов
                                oSheet.Cells[1, x + 2] = dataGridView1.Columns[x].HeaderText;

                            }

                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                                {
                                    // создание строк
                                    oSheet.Cells[j + 2, i + 2] = dataGridView1.Rows[j].Cells[i].Value;

                                }
                            }
                            //Добавляем также форматирование
                            Range rng1 = oSheet.get_Range("B1", Range_Letter + "1");
                            rng1.Font.Size = 14;
                            rng1.Font.Bold = true;
                            rng1.Cells.Borders.LineStyle = XlLineStyle.xlDouble;
                            rng1.Cells.Borders.Color = Color.DeepSkyBlue;
                            rng1.Font.Color = Color.Black;
                            rng1.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                            rng1.Interior.Color = Color.LightGray;

                            Range rng2 = oSheet.get_Range("B2", Range_Letter + Range_Row);
                            rng2.WrapText = false;
                            rng2.Font.Size = 12;
                            rng2.Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
                            rng2.Cells.Borders.Color = Color.DeepSkyBlue;
                            rng2.VerticalAlignment = XlVAlign.xlVAlignCenter;
                            rng2.Interior.Color = Color.Azure;
                            rng2.EntireColumn.AutoFit();
                            rng2.EntireRow.AutoFit();

                            //Добавляем заголовок строки
                            oSheet.get_Range("B1", Range_Letter + "2").EntireRow.Insert(XlInsertShiftDirection.xlShiftDown, Missing.Value);
                            oSheet.Cells[1, 3] = "Лимит продаж по безналичному расчету";
                            Range rng3 = oSheet.get_Range("B1", Range_Letter + "2");
                            rng3.Merge(Missing.Value);
                            rng3.Font.Size = 16;
                            rng3.Font.Color = Color.Blue;
                            rng3.Font.Bold = true;
                            rng3.VerticalAlignment = XlVAlign.xlVAlignCenter;
                            rng3.Interior.Color = Color.LightSkyBlue;

                            oBook.SaveAs(fn);
                            oApp.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
       }
    }
}
