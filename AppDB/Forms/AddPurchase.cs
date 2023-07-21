using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppDB.Forms
{
    public partial class AddPurchase : MaterialForm
    {
        public AddPurchase()
        {
            InitializeComponent();
            cmbModel_fill();
            cmbFIO_fill();
        }
        void cmbModel_fill()
        {
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(@"select c.id, c.model from car c where c.availability = true", Connection.con);
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

           private void btnPerform_Purchase_Click(object sender, EventArgs e)
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
                    MessageBox.Show(string.Format("Чек:\r\n Модель: {0} \r\nФИО: {1}\r\nДата: {2}\r\nТип оплаты: {3} ", cmbModel.Text, cmbFIO.Text, date.Value.ToString("d"), cmbPurchase_type.Text));
                   
                }
                   

                MessageBox.Show("Покупка оформлена!", "Внимание");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
