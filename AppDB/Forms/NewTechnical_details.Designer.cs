namespace AppDB.Forms
{
    partial class NewTechnical_details
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
            this.txtdoors_count = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtseats_count = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtengine_capacity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbBodyType = new System.Windows.Forms.ComboBox();
            this.cmbEngineType = new System.Windows.Forms.ComboBox();
            this.cmbEngineLocation = new System.Windows.Forms.ComboBox();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(154, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Количество дверей:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 113);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(137, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Количество мест:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 149);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(165, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Мощность двигателя:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 186);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(93, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Тип кузова:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 220);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(117, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Тип двигателя:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 258);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(196, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Расположение двигателя:";
            // 
            // txtdoors_count
            // 
            this.txtdoors_count.Depth = 0;
            this.txtdoors_count.Hint = "";
            this.txtdoors_count.Location = new System.Drawing.Point(201, 74);
            this.txtdoors_count.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdoors_count.Name = "txtdoors_count";
            this.txtdoors_count.PasswordChar = '\0';
            this.txtdoors_count.SelectedText = "";
            this.txtdoors_count.SelectionLength = 0;
            this.txtdoors_count.SelectionStart = 0;
            this.txtdoors_count.Size = new System.Drawing.Size(75, 23);
            this.txtdoors_count.TabIndex = 6;
            this.txtdoors_count.UseSystemPasswordChar = false;
            this.txtdoors_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_Numbers);
            // 
            // txtseats_count
            // 
            this.txtseats_count.Depth = 0;
            this.txtseats_count.Hint = "";
            this.txtseats_count.Location = new System.Drawing.Point(201, 103);
            this.txtseats_count.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtseats_count.Name = "txtseats_count";
            this.txtseats_count.PasswordChar = '\0';
            this.txtseats_count.SelectedText = "";
            this.txtseats_count.SelectionLength = 0;
            this.txtseats_count.SelectionStart = 0;
            this.txtseats_count.Size = new System.Drawing.Size(75, 23);
            this.txtseats_count.TabIndex = 7;
            this.txtseats_count.UseSystemPasswordChar = false;
            this.txtseats_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_Numbers);
            // 
            // txtengine_capacity
            // 
            this.txtengine_capacity.Depth = 0;
            this.txtengine_capacity.Hint = "";
            this.txtengine_capacity.Location = new System.Drawing.Point(201, 149);
            this.txtengine_capacity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtengine_capacity.Name = "txtengine_capacity";
            this.txtengine_capacity.PasswordChar = '\0';
            this.txtengine_capacity.SelectedText = "";
            this.txtengine_capacity.SelectionLength = 0;
            this.txtengine_capacity.SelectionStart = 0;
            this.txtengine_capacity.Size = new System.Drawing.Size(75, 23);
            this.txtengine_capacity.TabIndex = 8;
            this.txtengine_capacity.UseSystemPasswordChar = false;
            this.txtengine_capacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_Numbers);
            // 
            // cmbBodyType
            // 
            this.cmbBodyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodyType.FormattingEnabled = true;
            this.cmbBodyType.Location = new System.Drawing.Point(178, 178);
            this.cmbBodyType.Name = "cmbBodyType";
            this.cmbBodyType.Size = new System.Drawing.Size(199, 21);
            this.cmbBodyType.TabIndex = 9;
            // 
            // cmbEngineType
            // 
            this.cmbEngineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEngineType.FormattingEnabled = true;
            this.cmbEngineType.Items.AddRange(new object[] {
            "гибрид",
            "дизель",
            "электрический",
            "бензин"});
            this.cmbEngineType.Location = new System.Drawing.Point(178, 218);
            this.cmbEngineType.Name = "cmbEngineType";
            this.cmbEngineType.Size = new System.Drawing.Size(199, 21);
            this.cmbEngineType.TabIndex = 10;
            // 
            // cmbEngineLocation
            // 
            this.cmbEngineLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEngineLocation.FormattingEnabled = true;
            this.cmbEngineLocation.Items.AddRange(new object[] {
            "передний",
            "задний",
            "средний"});
            this.cmbEngineLocation.Location = new System.Drawing.Point(214, 256);
            this.cmbEngineLocation.Name = "cmbEngineLocation";
            this.cmbEngineLocation.Size = new System.Drawing.Size(163, 21);
            this.cmbEngineLocation.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(283, 304);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(94, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(12, 304);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(94, 30);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewTechnical_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 355);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbEngineLocation);
            this.Controls.Add(this.cmbEngineType);
            this.Controls.Add(this.cmbBodyType);
            this.Controls.Add(this.txtengine_capacity);
            this.Controls.Add(this.txtseats_count);
            this.Controls.Add(this.txtdoors_count);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 355);
            this.Name = "NewTechnical_details";
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdoors_count;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtseats_count;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtengine_capacity;
        private System.Windows.Forms.ComboBox cmbBodyType;
        private System.Windows.Forms.ComboBox cmbEngineType;
        private System.Windows.Forms.ComboBox cmbEngineLocation;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
    }
}