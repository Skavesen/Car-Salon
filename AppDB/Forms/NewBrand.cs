using MaterialSkin.Controls;
using Npgsql;
using NpgsqlTypes;
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
    public partial class NewBrand : MaterialForm
    {
        int id;
        DataTable dt = new DataTable();
        public NewBrand()
        {
            InitializeComponent();
            if (Main.flagBrand == true)
               Text = "Добавить запись";
        }

        public NewBrand(int idd)
        {
            InitializeComponent();
            id = idd;
            Text = "Редактировать запись";
            string sql = @"select b.brand
                           from brands b
                            where b.id =" + idd;
            Connection.con = new NpgsqlConnection(Connection.connection());
            Connection.con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
            cmd.CommandType = CommandType.Text;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(reader);
            txtbrand.Text = dt.Rows[0].ItemArray.GetValue(0).ToString();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Connection.con.Close();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.flagBrand == true)
            {
                try
                {
                    if (txtbrand.Text.Trim().Length <= 0)
                    {
                        MessageBox.Show("Поле \"Марка\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    Connection.con = new NpgsqlConnection(Connection.connection());
                    Connection.con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("ins_brand", Connection.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@brand", NpgsqlDbType.Text).Value = txtbrand.Text;
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
                    if (txtbrand.Text.Trim().Length <= 0)
                    {
                        MessageBox.Show("Поле \"Марка\" не должно быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    Connection.con = new NpgsqlConnection(Connection.connection());
                    Connection.con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("upd_brand", Connection.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@brand", txtbrand.Text);
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
    }
}
