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

namespace AppDB
{
    public partial class NewPurchase : MaterialForm
    {
        int id;
        DataTable dtable = new DataTable();
        public NewPurchase()
        {
            InitializeComponent();
            if (Main.flagPurchase ==  true)
            {
                Text = "Новая покупка";
                cmbModel_fill();
                cmbFIO_fill();
            }
            
        }

        public NewPurchase(int idd)
        {
            InitializeComponent();

            Text = "Редактировать запись";
            string sql = @"select p.id, c.model, (cl.lastname||' '|| cl.firstname||' '||cl.patronymic) as fio, p.datee, p.payment_type
                                    from purchases p, car c, clients cl
                                        where p.car_id = c.id and p.client_id = cl.id and p.id=" + idd;
                id = idd;
                try
                {
                    Connection.con = new NpgsqlConnection(Connection.connection());
                    Connection.con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    dtable.Clear();
                    dtable.Load(reader);
                    date.Value = (DateTime)dtable.Rows[0].ItemArray.GetValue(3);
                    cmbPurchase_type.SelectedItem = dtable.Rows[0].ItemArray.GetValue(4).ToString();
                    Connection.con.Close();
                    cmbModel_fill_ed();
                    cmbFIO_filledd();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        
        void cmbModel_fill()
        {
            try {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(@"select c.id, c.model from car c", Connection.con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                cmbModel.DataSource = ds.Tables[0].DefaultView;
                cmbModel.DisplayMember = "model";
                cmbModel.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.con.Close();
            }
            }
        void cmbFIO_fill()
        {
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(@"select cl.id, (cl.lastname || ' ' || cl.firstname || ' ' || cl.patronymic) as fio from clients cl", Connection.con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                cmbFIO.DataSource = ds.Tables[0].DefaultView;
                cmbFIO.DisplayMember = "fio";
                cmbFIO.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.con.Close();
                
            }
        }
        void cmbModel_fill_ed()
        {
            try
            {

                Connection.con = new NpgsqlConnection(Connection.connection());
                Connection.con.Open();
                string sql = @"select c.id, c.model from car c";
                DataTable dt = new DataTable();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader reader = cmd.ExecuteReader();
                dt.Clear();
                dt.Load(reader);
                cmbModel.DataSource = dt;
                cmbModel.DisplayMember = "model";
                cmbModel.ValueMember = "id";
                Connection.con.Close();

                DataTable dt2 = new DataTable();
                Connection.con.Open();
                cmd = new NpgsqlCommand(@"select c.id from car c, purchases p
                                          where c.id = p.car_id and p.id ="+id,Connection.con);
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();
                dt2.Clear();
                dt2.Load(reader);
                cmbModel.SelectedValue = dt2.Rows[0].ItemArray.GetValue(0);
                Connection.con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            }

        void cmbFIO_filledd()
        {
            try
            {
                Connection.con = new NpgsqlConnection(Connection.connection());
                Connection.con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(@"select cl.id, (cl.lastname || ' ' || cl.firstname || ' ' || cl.patronymic) as fio from clients cl", Connection.con);
                DataTable dt = new DataTable(), dt2 = new DataTable();
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader reader = cmd.ExecuteReader();
                dt.Clear();
                dt.Load(reader);
                cmbFIO.DataSource = dt;
                cmbFIO.DisplayMember = "fio";
                cmbFIO.ValueMember = "id";
                Connection.con.Close();
                Connection.con.Open();
                cmd = new NpgsqlCommand(@"select c.id from clients c, purchases p
                                          where c.id = p.client_id and p.id =" + id, Connection.con);
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();
                dt2.Clear();
                dt2.Load(reader);
                cmbFIO.SelectedValue = dt2.Rows[0].ItemArray.GetValue(0);
                Connection.con.Close();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
                
            }
        }

        void Execute (string SQL,CommandType commandType = CommandType.Text,string[] parameters = null, object[] values = null )
        {
            using (NpgsqlCommand cmd = Connection.con.CreateCommand())
            {
                cmd.CommandText = SQL;
                if (parameters!=null&&parameters.Length>0)
                    for (int a = 0; a < parameters.Length; ++a)
                    {
                        cmd.Parameters.AddWithValue(parameters[a], values[a]);
                    }
                cmd.CommandType = commandType;
                cmd.ExecuteNonQuery();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.flagPurchase == true)
            {
                try
              {
                    string sql = @"Insert into purchases(car_id, client_id, datee, payment_type) values(@model, @client, @date, @payment_type)";
                    Connection.con = new NpgsqlConnection(Connection.connection());
                    Connection.con.Open();
                    using (NpgsqlCommand cmd = Connection.con.CreateCommand())
                    {

                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@model", Convert.ToInt32(cmbModel.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@client", Convert.ToInt32(cmbFIO.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@date", date.Value);
                        cmd.Parameters.Add("@payment_type", NpgsqlTypes.NpgsqlDbType.Unknown).Value = cmbPurchase_type.Text;
                        cmd.ExecuteNonQuery();
                        Close();
                    }
                                   
                    MessageBox.Show("Запись успешно добавлена", "Внимание");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (Main.flagPurchase == false)
            {
                try
                {
                    string sql = @"Update purchases
                                    set car_id = @model, client_id = @client, datee = @date , payment_type = @payment_type
                                   where id = @id";
                    Connection.con = new NpgsqlConnection(Connection.connection());
                    Connection.con.Open();
                    using (NpgsqlCommand cmd = Connection.con.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@model", Convert.ToInt32(cmbModel.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@client", Convert.ToInt32(cmbFIO.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@date", date.Value);
                        cmd.Parameters.Add("@payment_type", NpgsqlTypes.NpgsqlDbType.Unknown).Value = cmbPurchase_type.Text;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        Close();
                    }

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.con.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Connection.con.Close();
            Close();
        }
    }
}
