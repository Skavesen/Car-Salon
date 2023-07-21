using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDB.Forms
{
    public partial class NewTechnical_details : MaterialForm
    {
        int id;
        DataTable dtable = new DataTable();
        public NewTechnical_details()
        {
            InitializeComponent();
            if (Main.flagTechnical_details == true)
               Text = "Новая техническая деталь";
                body_type_fill();
        }

        public NewTechnical_details(int idd)
        {
            InitializeComponent();
            id = idd;
            Text = "Редактировать запись";
            try
            {
                string sql = @"select t.doors_count, t.seats_count, t.engine_capacity, b.body_type, t.engine_type, t.engine_location
                                    from technical_details t, body_types b
                                    where t.body_type_id = b.id and t.id ="+idd;  
                Connection.con = new NpgsqlConnection(Connection.connection());
                Connection.con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader reader = cmd.ExecuteReader();
                dtable.Clear();
                dtable.Load(reader);
                txtdoors_count.Text = dtable.Rows[0].ItemArray.GetValue(0).ToString();
                txtseats_count.Text = dtable.Rows[0].ItemArray.GetValue(1).ToString();
                txtengine_capacity.Text = dtable.Rows[0].ItemArray.GetValue(2).ToString();
               
                cmbEngineType.SelectedItem = dtable.Rows[0].ItemArray.GetValue(4).ToString();
                cmbEngineLocation.SelectedItem = dtable.Rows[0].ItemArray.GetValue(5).ToString();
                Connection.con.Close();
                body_type_fill_ed();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        void body_type_fill() {
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(@"select b.id, b.body_type from body_types b", Connection.con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                cmbBodyType.DataSource = ds.Tables[0].DefaultView;
                cmbBodyType.DisplayMember = "body_type";
                cmbBodyType.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.con.Close();
            }
        }

        void body_type_fill_ed()
        {
            try
            {

                Connection.con = new NpgsqlConnection(Connection.connection());
                Connection.con.Open();
                string sql = @"select b.id, b.body_type from body_types b";
                DataTable dt = new DataTable();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader reader = cmd.ExecuteReader();
                dt.Clear();
                dt.Load(reader);
                cmbBodyType.DataSource = dt;
                cmbBodyType.DisplayMember = "body_type";
                cmbBodyType.ValueMember = "id";
                Connection.con.Close();

                DataTable dt2 = new DataTable();
                Connection.con.Open();
                cmd = new NpgsqlCommand(@"select b.id from body_types b, technical_details t
                                          where b.id = t.body_type_id and t.id =" + id, Connection.con);
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();
                dt2.Clear();
                dt2.Load(reader);
                cmbBodyType.SelectedValue = dt2.Rows[0].ItemArray.GetValue(0);
                Connection.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.flagTechnical_details == true)
            {
                try
                {
                    string sql = @"Insert into technical_details(doors_count, seats_count, engine_capacity, body_type_id, engine_type, engine_location)
                                values(@doors, @seats, @engine_capacity, @body_type, @engine_type, @engine_location)";
                    if (txtdoors_count.Text.Trim().Length<=0 || 
                        txtseats_count.Text.Trim().Length<=0 ||
                        txtengine_capacity.Text.Trim().Length<=0)

                    {
                        if (txtdoors_count.Text.Trim().Length <= 0)
                        {
                            MessageBox.Show("Поле \"Количество дверей\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (txtseats_count.Text.Trim().Length<=0)
                        {
                            MessageBox.Show("Поле \"Количество мест\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (txtengine_capacity.Text.Trim().Length <= 0)
                        {
                            MessageBox.Show("Поле \"Мощность\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                         Connection.con = new Npgsql.NpgsqlConnection(Connection.connection());
                        Connection.con.Open();
                        Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sql, Connection.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@doors", Convert.ToInt32(txtdoors_count.Text));
                        cmd.Parameters.AddWithValue("@seats", Convert.ToInt32(txtseats_count.Text));
                        cmd.Parameters.AddWithValue("@engine_capacity", Convert.ToInt32(txtengine_capacity.Text));
                        cmd.Parameters.AddWithValue("@body_type", Convert.ToInt32(cmbBodyType.SelectedValue.ToString()));
                        cmd.Parameters.Add("@engine_type", NpgsqlTypes.NpgsqlDbType.Unknown).Value = cmbEngineType.Text;
                        cmd.Parameters.Add("@engine_location", NpgsqlTypes.NpgsqlDbType.Unknown).Value = cmbEngineLocation.Text;
                        cmd.ExecuteNonQuery();
                        Close();       
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.con.Close();
                }
            }
            else
            {
                try
                {
                    string sql = @"Update technical_details
                                    set doors_count = @doors, seats_count = @seats, engine_capacity = @engine_capacity,
                                  body_type_id =  @body_type, engine_type = @engine_type, engine_location = @engine_location
                                  where id = @id";
                    if (txtdoors_count.Text.Trim().Length <= 0 ||
                        txtseats_count.Text.Trim().Length <= 0 ||
                        txtengine_capacity.Text.Trim().Length <= 0)

                    {
                        if (txtdoors_count.Text.Trim().Length <= 0)
                        {
                            MessageBox.Show("Поле \"Количество дверей\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (txtseats_count.Text.Trim().Length <= 0)
                        {
                            MessageBox.Show("Поле \"Количество мест\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (txtengine_capacity.Text.Trim().Length <= 0)
                        {
                            MessageBox.Show("Поле \"Мощность\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    Connection.con = new Npgsql.NpgsqlConnection(Connection.connection());
                    Connection.con.Open();
                    Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sql, Connection.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@doors", Convert.ToInt32(txtdoors_count.Text));
                    cmd.Parameters.AddWithValue("@seats", Convert.ToInt32(txtseats_count.Text));
                    cmd.Parameters.AddWithValue("@engine_capacity", Convert.ToInt32(txtengine_capacity.Text));
                    cmd.Parameters.AddWithValue("@body_type", Convert.ToInt32(cmbBodyType.SelectedValue.ToString()));
                    cmd.Parameters.Add("@engine_type", NpgsqlTypes.NpgsqlDbType.Unknown).Value = cmbEngineType.Text;
                    cmd.Parameters.Add("@engine_location", NpgsqlTypes.NpgsqlDbType.Unknown).Value = cmbEngineLocation.Text;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.con.Close();
                }
            }
        }

        private void Validate_Numbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
