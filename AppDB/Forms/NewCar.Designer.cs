namespace AppDB.Forms
{
    partial class NewCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.chkAvailability = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtModel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcolor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbTechnical_details = new System.Windows.Forms.ComboBox();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 85);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Марка:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 128);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Модель:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 171);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(48, 19);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Цвет:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 209);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(49, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Цена:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 253);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(156, 19);
            this.materialLabel5.TabIndex = 20;
            this.materialLabel5.Text = "Техническая деталь:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 295);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(105, 19);
            this.materialLabel6.TabIndex = 21;
            this.materialLabel6.Text = "Доступность:";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(184, 83);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(336, 21);
            this.cmbBrand.TabIndex = 22;
            // 
            // chkAvailability
            // 
            this.chkAvailability.AutoSize = true;
            this.chkAvailability.Depth = 0;
            this.chkAvailability.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkAvailability.Location = new System.Drawing.Point(187, 284);
            this.chkAvailability.Margin = new System.Windows.Forms.Padding(0);
            this.chkAvailability.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAvailability.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAvailability.Name = "chkAvailability";
            this.chkAvailability.Ripple = true;
            this.chkAvailability.Size = new System.Drawing.Size(26, 30);
            this.chkAvailability.TabIndex = 23;
            this.chkAvailability.UseVisualStyleBackColor = true;
            this.chkAvailability.CheckedChanged += new System.EventHandler(this.chkAvailability_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(13, 364);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(93, 36);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtModel
            // 
            this.txtModel.Depth = 0;
            this.txtModel.Hint = "";
            this.txtModel.Location = new System.Drawing.Point(184, 124);
            this.txtModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtModel.Name = "txtModel";
            this.txtModel.PasswordChar = '\0';
            this.txtModel.SelectedText = "";
            this.txtModel.SelectionLength = 0;
            this.txtModel.SelectionStart = 0;
            this.txtModel.Size = new System.Drawing.Size(188, 23);
            this.txtModel.TabIndex = 25;
            this.txtModel.UseSystemPasswordChar = false;
            // 
            // txtcolor
            // 
            this.txtcolor.Depth = 0;
            this.txtcolor.Hint = "";
            this.txtcolor.Location = new System.Drawing.Point(184, 167);
            this.txtcolor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.PasswordChar = '\0';
            this.txtcolor.SelectedText = "";
            this.txtcolor.SelectionLength = 0;
            this.txtcolor.SelectionStart = 0;
            this.txtcolor.Size = new System.Drawing.Size(188, 23);
            this.txtcolor.TabIndex = 26;
            this.txtcolor.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Depth = 0;
            this.txtPrice.Hint = "";
            this.txtPrice.Location = new System.Drawing.Point(184, 205);
            this.txtPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(188, 23);
            this.txtPrice.TabIndex = 27;
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // cmbTechnical_details
            // 
            this.cmbTechnical_details.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTechnical_details.FormattingEnabled = true;
            this.cmbTechnical_details.Location = new System.Drawing.Point(184, 251);
            this.cmbTechnical_details.Name = "cmbTechnical_details";
            this.cmbTechnical_details.Size = new System.Drawing.Size(824, 21);
            this.cmbTechnical_details.TabIndex = 28;
            this.cmbTechnical_details.MouseEnter += new System.EventHandler(this.cmbTechnical_details_MouseEnter);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(294, 364);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(68, 36);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 414);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbTechnical_details);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkAvailability);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "NewCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox cmbBrand;
        private MaterialSkin.Controls.MaterialCheckBox chkAvailability;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtModel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcolor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrice;
        private System.Windows.Forms.ComboBox cmbTechnical_details;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
    }
}