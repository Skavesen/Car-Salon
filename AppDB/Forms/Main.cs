using AppDB.Forms;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AppDB
{
    public partial class Main : MaterialForm
    {
        public static bool flagClient= true;
        public static bool flagBrand = true;
        public static bool flagCar = true;
        public static bool flagPurchase = true;
        public static bool flagTechnical_details = true;
       public static Dictionary<string, string> headers = new Dictionary<string, string>()
        {
            {"lastname","Фамилия" },
            {"firstname","Имя" },
            {"patronymic","Отчество" },
            {"passport","Паспортные данные" },
            {"fio","ФИО" },
            {"address","Адрес" },
            {"phone","Телефон" }, //clients
            {"model","Модель" },
            {"color","Цвет" },
            {"price","Цена" },
            {"availability","Доступность" }, // car
            {"brand","Марка" },             // brands
            {"datee","Дата" },
            {"payment_type","Тип оплаты" }, //purchases
            {"doors_count","Количество дверей" },
            {"seats_count","Количество мест" },
            {"engine_capacity","Мощность двигателя" },
            {"engine_type","Тип двигателя" },
            {"engine_location","Расположение двигателя" },//technical_details
            {"body_type","Тип кузова" },
            {"avto","Количество купленных машин" },
            {"c_col","Марка модели" }

        };
       
        public Main()
        {
            InitializeComponent();
           
        }
      
        public void btnAddClient_Click(object sender, EventArgs e)
        {

            flagClient = true;
            new NewForm().ShowDialog(this);
            ChooseTable("clients",dataGridView1);



        }

        private void btnEddClient_Click(object sender, EventArgs e)
        {

            flagClient = false;
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value);
            new NewForm(id).ShowDialog();
            ChooseTable("clients", dataGridView1);
          
        }

        void ChooseTable(string table, DataGridView dg)
        {
            try
            {
                Connection.con = new NpgsqlConnection(Connection.connection());
                    Connection.con.Open();
                    DataTable dt = new DataTable();
                    string command = "Select * from " + table;
                    switch (table)
                    {
                        case "car":
                        command = @"select  c.id, c.model, c.color, c.price, br.brand, t.doors_count,
                                       t.seats_count, t.engine_capacity, b.body_type, t.engine_type, t.engine_location, c.availability
                                      from brands br, car c, technical_details t, body_types b
                                      where c.brand_id = br.id and c.technical_details_id = t.id and t.body_type_id = b.id";
                       
                            break;
                        
                    case "clients":
                            command = @"select * from clients";
                            break;
                    case "brands":
                            command = @"select * from brands";
                            break;
                    case "purchases":
                        command = @"select p.id, c.model, (cl.lastname||' '|| cl.firstname||' '||cl.patronymic) as fio, p.datee, p.payment_type
                                    from purchases p, car c, clients cl
                                        where p.car_id = c.id and p.client_id = cl.id";
                        break;
                    case "technical_details":
                        command = @"select t.id, t.doors_count, t.seats_count, t.engine_capacity, b.body_type, t.engine_type, t.engine_location
                                    from technical_details t, body_types b
                                    where t.body_type_id = b.id";
                        break;

                    }
                    NpgsqlCommand pcommand = new NpgsqlCommand(command, Connection.con)
                    {
                        CommandType = CommandType.Text
                    };
                    NpgsqlDataReader preader = pcommand.ExecuteReader();
                    dt.Clear();
                    dt.Load(preader);
                    dg.DataSource = dt;
                    dg.Columns[0].Visible = false;
                    dg.EnableHeadersVisualStyles = false;
                    dg.ColumnHeadersDefaultCellStyle.Font = new Font(dg.ColumnHeadersDefaultCellStyle.Font.FontFamily, 7f, FontStyle.Bold);
                    LocalizeHeaders(dg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.con.Close();
            }

        }

       public static void LocalizeHeaders(DataGridView dg)
        {
            for (int a = 0; a < dg.Columns.Count; ++a)
            {
                if (headers.ContainsKey(dg.Columns[a].HeaderText))
                    dg.Columns[a].HeaderText = headers[dg.Columns[a].HeaderText];
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ChooseTable("clients", dataGridView1);
            ChooseTable("car", dataGridView2);           
            ChooseTable("purchases", dataGridView3);
            ChooseTable("brands", dataGridView4);
            ChooseTable("technical_details", dataGridView5);

            
        }
            void delete(int id,string table,DataGridView dg)
        {
            try
            {
                string sql = @"delete from " + table + " where id =" + id;
                Connection.con = new NpgsqlConnection(Connection.connection());
                Connection.con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.DeleteCommand = Connection.con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;
                var dialog = new DialogResult();
                dialog = MessageBox.Show("Вы действительно хотите удалить запись?","Удаление",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

                if (dialog == DialogResult.OK)
                {
                    int success = cmd.ExecuteNonQuery();
                    if (success > 0)
                    {
                        MessageBox.Show("Удаление прошло успешно!", "Удаление");

                    }
                }
                Connection.con.Close();
                ChooseTable(table, dg);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.con.Close();
            }
        }
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value);
            delete(id, "clients", dataGridView1);
        }

      

        private void dataGridView2_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)

            {
                if ((bool)row.Cells[11].Value == true)
                {
                    dataGridView2.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGreen;

                }
                if ((bool)row.Cells[11].Value == false)
                {
                    dataGridView2.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightCoral;

                }
            }
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            flagBrand = true;
            new NewBrand().ShowDialog();
            ChooseTable("brands", dataGridView4);
        }

        private void btnEddBrand_Click(object sender, EventArgs e)
        {
            flagBrand = false;
            int id = Convert.ToInt32(dataGridView4.SelectedCells[0].OwningRow.Cells[0].Value);
            new NewBrand(id).ShowDialog();
            ChooseTable("brands", dataGridView4);
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView4.SelectedCells[0].OwningRow.Cells[0].Value);
            delete(id, "brands", dataGridView4);
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            flagCar = true;
            new NewCar().ShowDialog();
            ChooseTable("car", dataGridView2);
        }

        private void btnEddCar_Click(object sender, EventArgs e)
        {
            flagCar = false;
            int id = Convert.ToInt32(dataGridView2.SelectedCells[0].OwningRow.Cells[0].Value);
            new NewCar(id).ShowDialog();
            ChooseTable("car", dataGridView2);
        }

        private void btnDelCar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.SelectedCells[0].OwningRow.Cells[0].Value);
            delete(id, "car", dataGridView2);
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            flagPurchase = true;
            new NewPurchase().ShowDialog();
            ChooseTable("purchases", dataGridView3);
        }

        private void btnEddPurchase_Click(object sender, EventArgs e)
        {
            flagPurchase = false;
            int id = Convert.ToInt32(dataGridView3.SelectedCells[0].OwningRow.Cells[0].Value);
            new NewPurchase(id).ShowDialog();
            ChooseTable("purchases",dataGridView3);
        }

        private void btnDelPurchase_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView3.SelectedCells[0].OwningRow.Cells[0].Value);
            delete(id, "purchases", dataGridView3);
        }

        private void btnAddTechnical_details_Click(object sender, EventArgs e)
        {
            flagTechnical_details = true;
            new NewTechnical_details().ShowDialog();
            ChooseTable("technical_details", dataGridView5);
        }

        private void btnEddTechnical_details_Click(object sender, EventArgs e)
        {
            flagTechnical_details = false;
            int id = Convert.ToInt32(dataGridView5.SelectedCells[0].OwningRow.Cells[0].Value);
            new NewTechnical_details(id).ShowDialog();
            ChooseTable("technical_details", dataGridView5);
        }

        private void btnDelTechnical_details_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView5.SelectedCells[0].OwningRow.Cells[0].Value);
            delete(id, "technical_details", dataGridView5);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var dialog = new DialogResult();
            dialog = MessageBox.Show("Вы действительно хотите покинуть приложение?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }
        }

       

        private void количествоКупленныхМашинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Avto_Count().ShowDialog();
        }

        private void оформитьПокупкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddPurchase().ShowDialog();
        }

        private void лимитПродажПоБезналичномуРасчетуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_ReportQuery().ShowDialog();
        }

        private void сделатьБекапToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BackupForm().ShowDialog();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new SearchForm().ShowDialog();
        }
    }
}
