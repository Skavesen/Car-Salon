using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppDB
{
    public partial class NewForm : MaterialForm
    {
        
        
        int id;
        DataTable dt = new DataTable();

        public NewForm()
        {
            InitializeComponent();
            if (Main.flagClient == true)
               Text = "Новый клиент";          
        }

        public NewForm(int idd)
        {
            InitializeComponent();
            Text = "Редактировать запись";
            id = idd;
            string sql = @"select c.lastname, c.firstname, c.patronymic, c.passport, c.address, c.phone
                           from clients c
                            where c.id =" + idd;

            Connection.con = new NpgsqlConnection(Connection.connection());
            Connection.con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
            cmd.CommandType = CommandType.Text;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(reader);
            txtlastname.Text = dt.Rows[0].ItemArray.GetValue(0).ToString();
            txtname.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
            txtpatronymic.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
            txtpassport.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();
            txtaddress.Text = dt.Rows[0].ItemArray.GetValue(4).ToString();
            txtphone.Text = dt.Rows[0].ItemArray.GetValue(5).ToString();
        }

          
      private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.flagClient == true)
            {
                try
                {

                    if (txtlastname.Text.Trim().Length <= 0 ||
                        txtname.Text.Trim().Length <= 0 ||
                        txtpatronymic.Text.Trim().Length <= 0 ||
                        txtpassport.Text.Trim().Length <= 0 ||
                        txtaddress.Text.Trim().Length <= 0 ||
                        txtphone.Text.Trim().Length <= 0)
                    {
                        if (txtlastname.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Фамилия\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtname.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Имя\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtpatronymic.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Отчество\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtpassport.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Паспортные данные\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtaddress.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Адрес\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtphone.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Телефон\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    string sql = @"Insert into  clients (lastname, firstname, patronymic, passport, address, phone)
                                    Values (@lastname, @name, @patronymic, @passport, @address, @phone)";
                    Connection.con = new NpgsqlConnection(Connection.connection());
                    Connection.con.Open();
                    using (NpgsqlCommand command = Connection.con.CreateCommand())
                    {
                        command.CommandText = sql;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@lastname", txtlastname.Text);
                        command.Parameters.AddWithValue("@name", txtname.Text);
                        command.Parameters.AddWithValue("@patronymic", txtpatronymic.Text);
                        command.Parameters.AddWithValue("@passport", txtpassport.Text);
                        command.Parameters.AddWithValue("@address", txtaddress.Text);
                        command.Parameters.AddWithValue("@phone", txtphone.Text);
                        command.ExecuteNonQuery();
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.con.Close();
                }

            }
           else
            {
                try {
                    if (txtlastname.Text.Trim().Length <= 0 ||
                             txtname.Text.Trim().Length <= 0 ||
                             txtpatronymic.Text.Trim().Length <= 0 ||
                             txtpassport.Text.Trim().Length <= 0 ||
                             txtaddress.Text.Trim().Length <= 0 ||
                             txtphone.Text.Trim().Length <= 0)
                    {
                        if (txtlastname.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Фамилия\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtname.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Имя\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtpatronymic.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Отчество\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtpassport.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Паспортные данные\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtaddress.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Адрес\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else if (txtphone.Text.Trim().Length <= 0)
                            MessageBox.Show("Поле \"Телефон\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    string sql = @"Update clients
                                set lastname = @lastname, firstname = @name, patronymic = @patronymic, passport = @passport, address = @address, phone = @phone
                                where id = @id";
                    Connection.con = new NpgsqlConnection(Connection.connection());
                    Connection.con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@lastname", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@patronymic", txtpatronymic.Text);
                    cmd.Parameters.AddWithValue("@passport", txtpassport.Text);
                    cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.con.Close();
                }
        }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '+') return;
            if (e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Connection.con.Close();
            Close();
        }
    }
    }


