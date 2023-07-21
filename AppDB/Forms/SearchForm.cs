using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppDB.Forms
{
    public partial class SearchForm : MaterialForm
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public SearchForm()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = string.Empty;
            Connection.con = new NpgsqlConnection(Connection.connection());
            Connection.con.Open();
            DataTable dt = new DataTable();
           switch (cmbTable.SelectedIndex)
            {
                case 0:
                  
                    dt = ds.Tables.Add("clients");
                       command = @"select * from clients";
                       NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command, Connection.con);
                         adapter.Fill(dt);
                  
                    break;
                    
               
                case 1:
                    dt = ds.Tables.Add("car");
                    command = @"select  c.id, c.model, c.color, c.price, br.brand
                                      from brands br, car c
                                      where c.brand_id = br.id";
                    adapter = new NpgsqlDataAdapter(command, Connection.con);
                    adapter.Fill(dt);
                    break;
                case 2:
                    
                    dt = ds.Tables.Add("purchases");
                    command = @"select p.id, c.model, (cl.lastname||' '|| cl.firstname||' '||cl.patronymic) as fio, p.datee, p.payment_type
                                    from purchases p, car c, clients cl
                                        where p.car_id = c.id and p.client_id = cl.id";
                    adapter = new NpgsqlDataAdapter(command, Connection.con);
                    adapter.Fill(dt);
                   
                    break;
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            Main.LocalizeHeaders(dataGridView1);
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        
        
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                    
                        dataGridView1.Rows[i].Selected = false;
                        
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                                if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtSearch.Text))
                                {
                                    dataGridView1.Rows[i].Selected = true;
                                    break;
                                }
                        
                      
                                }
                            }
                        }

       
                    }
                }
