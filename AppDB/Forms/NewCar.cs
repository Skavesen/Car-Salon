using MaterialSkin.Controls;
using System;
using Npgsql;
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
    public partial class NewCar : MaterialForm
    {
        int id;
        ToolTip toolTip = new ToolTip();
        DataTable dtable = new DataTable();
        public NewCar()
        {
            InitializeComponent();
            if (Main.flagCar == true)
                Text = "Новый автомобиль";
            YesNo();
            cmbBrand_fill();
            cmTechnical_details_fill();
        }

        public NewCar(int idd)
        {
            InitializeComponent();
            Text = "Редактировать запись";
            YesNo();
            try
            {
                string sql = @"select br.brand, c.model, c.color, c.price, t.doors_count, t.seats_count, t.engine_capacity, b.body_type, t.engine_type, t.engine_location, c.availability
                             from brands br, car c, technical_details t, body_types b
                            where t.id = c.technical_details_id and b.id = t.body_type_id and br.id = c.brand_id and c.id=" + idd;
                id = idd;
                Connection.con = new NpgsqlConnection(Connection.connection());
                Connection.con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader reader = cmd.ExecuteReader();
                dtable.Clear();
                dtable.Load(reader);
                cmbBrand_fill_ed();
                txtModel.Text = dtable.Rows[0].ItemArray.GetValue(1).ToString();
                txtcolor.Text = dtable.Rows[0].ItemArray.GetValue(2).ToString();
                txtPrice.Text = dtable.Rows[0].ItemArray.GetValue(3).ToString();
                cmTechnical_details_fill_ed();
                chkAvailability.Checked = (bool)dtable.Rows[0].ItemArray.GetValue(10);
                 Connection.con.Close();
                 
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
           
        }

        void cmbBrand_fill()
        {
            try {
                string sql = @"select id, brand from brands";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, Connection.con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                cmbBrand.DataSource = ds.Tables[0].DefaultView;
                cmbBrand.DisplayMember = "brand";
                cmbBrand.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void cmbBrand_fill_ed() {
            try
            {
                DataTable dtable = new DataTable(), dtable2 = new DataTable();
                Connection.con = new NpgsqlConnection(Connection.connection());
                Connection.con.Open();
                string sql = "select id, brand from brands";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader reader = cmd.ExecuteReader();
                dtable.Clear();
                dtable.Load(reader);
                cmbBrand.DataSource = dtable;
                cmbBrand.DisplayMember = "brand";
                cmbBrand.ValueMember = "id";
                Connection.con.Close();

                Connection.con.Open();
                cmd = new NpgsqlCommand(@"select b.id from brands b, car c
                                          where b.id = c.brand_id and c.id =" + id, Connection.con);
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();
                dtable2.Clear();
                dtable2.Load(reader);
                cmbBrand.SelectedValue = dtable2.Rows[0].ItemArray.GetValue(0);
                Connection.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.con.Close();
            }
        } 

        void cmTechnical_details_fill_ed()
        {
            string sql = @"select t.id, ('Дверей - '||t.doors_count||' Мест - '|| t.seats_count||' Мощность двигателя - '|| t.engine_capacity||' Тип кузова - '||b.body_type||' Тип двигателя - '|| t.engine_type||' Расположение двигателя - '|| t.engine_location) as detal
                                from body_types b, technical_details t where b.id = t.body_type_id";
            DataTable dtable = new DataTable(), dtable2 = new DataTable();
            Connection.con = new NpgsqlConnection(Connection.connection());
            Connection.con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
            cmd.CommandType = CommandType.Text;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            dtable.Clear();
            dtable.Load(reader);
            cmbTechnical_details.DataSource = dtable;
            cmbTechnical_details.DisplayMember = "detal";
            cmbTechnical_details.ValueMember = "id";
            Connection.con.Close();
            Connection.con.Open();
            cmd = new NpgsqlCommand(@"select t.id
                                from body_types b, technical_details t, car c  where b.id = t.body_type_id and t.id = c.technical_details_id and c.id ="+id, Connection.con);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            dtable2.Clear();
            dtable2.Load(reader);

            cmbTechnical_details.SelectedValue = dtable2.Rows[0].ItemArray.GetValue(0);
        }

        void cmTechnical_details_fill()
        {
            try
            {
                string sql = @"select t.id, ('Дверей - '||t.doors_count||' Мест - '|| t.seats_count||' Мощность двигателя - '|| t.engine_capacity||' Тип кузова - '||b.body_type||' Тип двигателя - '|| t.engine_type||' Расположение двигателя - '|| t.engine_location) as detal
                                from body_types b, technical_details t where b.id = t.body_type_id";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, Connection.con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                cmbTechnical_details.DataSource = ds.Tables[0].DefaultView;
                cmbTechnical_details.DisplayMember = "detal";
                cmbTechnical_details.ValueMember = "id";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Main.flagCar == true)
            {
                try
                {
                    if (txtModel.Text.Trim().Length <= 0 || txtcolor.Text.Trim().Length <= 0 || txtPrice.Text.Trim().Length <= 0)
                    {
                        if (txtModel.Text.Trim().Length <= 0)
                        {
                            MessageBox.Show("Поле \"Модель\" не может быть пустым", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (txtcolor.Text.Trim().Length <= 0)
                        {
                            MessageBox.Show("Поле \"Цвет\" не может быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (txtPrice.Text.Trim().Length <= 0)
                        {
                            MessageBox.Show("Поле \"Цена\" не может быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    Connection.con = new NpgsqlConnection(Connection.connection());
                    Connection.con.Open();
                    string sql = @"Insert into car(brand_id, model, color, price, technical_details_id, availability)
                                values(@brand, @model, @color, @price, @technical_detail, @availability)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@brand", Convert.ToInt32(cmbBrand.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@color", txtcolor.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@technical_detail", Convert.ToInt32(cmbTechnical_details.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@availability", chkAvailability.Checked == true ? true : false);
                    cmd.ExecuteNonQuery();
                    Close();
                }
                catch
                {

                    Connection.con.Close();
                }
            }
            else
            {
                try {

                    if (txtModel.Text.Trim().Length <= 0 || txtcolor.Text.Trim().Length <= 0 || txtPrice.Text.Trim().Length <= 0)
                    {
                        if (txtModel.Text.Trim().Length<=0)
                        {
                            MessageBox.Show("Поле \"Модель\" не может быть пустым", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (txtcolor.Text.Trim().Length <= 0)
                        {
                            MessageBox.Show("Поле \"Цвет\" не может быть пустым!","Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (txtPrice.Text.Trim().Length <= 0)
                        {
                            MessageBox.Show("Поле \"Цена\" не может быть пустым!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    Connection.con = new NpgsqlConnection(Connection.connection());
                    Connection.con.Open();
                    string sql = @"Update car
                               Set brand_id = @brand, model = @model, color =  @color, price = @price, technical_details_id = @technical_detail , availability = @availability
                              where id = @id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@brand", Convert.ToInt32(cmbBrand.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@color", txtcolor.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@technical_detail", Convert.ToInt32(cmbTechnical_details.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@availability", chkAvailability.Checked == true ? true : false);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Close();
                }
                catch
                {
                    
                    Connection.con.Close();
                }

            }

        }
        void YesNo()
        {
            if (chkAvailability.CheckState == CheckState.Checked)
            {
                chkAvailability.Text = "да";
            }
            else
            {
                chkAvailability.Text = "нет";
            }
        }
        private void chkAvailability_CheckedChanged(object sender, EventArgs e)
        {
            YesNo();
        }

         private void cmbTechnical_details_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(cmbTechnical_details, "Подсказка показывает какие данные отображаются в раскрывающемся списке:\n\nКоличество дверей\nКоличество мест\nМощность двигателя\nТип кузова\nТип двигателя\nРасположения двигателя");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
