using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppDB.Forms
{
    public partial class Avto_Count : MaterialSkin.Controls.MaterialForm
    {
        public Avto_Count()
        {
            InitializeComponent();
            create_graph();
            ShowDate();
        }

        void ShowDate()
        {
            try
            {


                var sql = @"select(c.model || ' ' || b.brand) as c_col, count(p.id) as avto
                            from car c, brands b, purchases p
                                where b.id = c.brand_id and c.id = p.car_id
                                    group by c_col;";
                Connection.con = new Npgsql.NpgsqlConnection(Connection.connection());
                Connection.con.Open();
                Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sql, Connection.con);
                DataTable dt = new DataTable();
                     Npgsql.NpgsqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                  Main.LocalizeHeaders(dataGridView1);
                Connection.con.Close();
            }
            catch
            {
                Connection.con.Close();
            }
        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            

        }
        void create_graph()
        {
            try
            {
                int id = 1;
                var sql = @"select(c.model || ' ' || b.brand) as c_col, count(p.id) as avto
                            from car c, brands b, purchases p
                                where b.id = c.brand_id and c.id = p.car_id
                                    group by c_col;";
                Connection.con = new Npgsql.NpgsqlConnection(Connection.connection());
                Connection.con.Open();
                Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sql, Connection.con);
                Npgsql.NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series.Add(reader["c_col"].ToString());
                    chart1.Series[reader["c_col"].ToString()].Points.AddY(reader["avto"]);
                    chart1.Series[reader["c_col"].ToString()].ChartType = SeriesChartType.Column;
                    chart1.Series[reader["c_col"].ToString()].IsValueShownAsLabel = true;
                    chart1.Series[reader["c_col"].ToString()].LegendText = id + ". "+reader["c_col"].ToString();
                    chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                    chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                    id++;
                }
               
                Connection.con.Close();
            }
            catch
            {
                Connection.con.Close();
            }
        }
    
    

        private void btnSaveDiagram_Click(object sender, EventArgs e)
        {
            var dialog = new DialogResult();
            dialog = MessageBox.Show("Хотите ли Вы сохранить диаграмму?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Title = "Выбрать место куда сохранить", ValidateNames = true, Filter = "Png files|*.png" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = sfd.FileName;
                        chart1.SaveImage(fileName, ChartImageFormat.Png);
                    }
                }
            }
        }
    }
}

