namespace AppDB
{
    partial class NewPurchase
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
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbFIO = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cmbPurchase_type = new System.Windows.Forms.ComboBox();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Модель:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 123);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "ФИО:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 163);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Дата:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 204);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(98, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Тип оплаты:";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(116, 77);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(273, 21);
            this.cmbModel.TabIndex = 4;
            // 
            // cmbFIO
            // 
            this.cmbFIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFIO.FormattingEnabled = true;
            this.cmbFIO.Location = new System.Drawing.Point(116, 121);
            this.cmbFIO.Name = "cmbFIO";
            this.cmbFIO.Size = new System.Drawing.Size(273, 21);
            this.cmbFIO.TabIndex = 5;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(116, 161);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(273, 20);
            this.date.TabIndex = 6;
            // 
            // cmbPurchase_type
            // 
            this.cmbPurchase_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchase_type.FormattingEnabled = true;
            this.cmbPurchase_type.Items.AddRange(new object[] {
            "Наличный",
            "Безналичный"});
            this.cmbPurchase_type.Location = new System.Drawing.Point(116, 202);
            this.cmbPurchase_type.Name = "cmbPurchase_type";
            this.cmbPurchase_type.Size = new System.Drawing.Size(273, 21);
            this.cmbPurchase_type.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(16, 246);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(149, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(200, 246);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(210, 30);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 291);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbPurchase_type);
            this.Controls.Add(this.date);
            this.Controls.Add(this.cmbFIO);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 291);
            this.Name = "NewPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbFIO;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox cmbPurchase_type;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
    }
}