namespace AppDB.Forms
{
    partial class AddPurchase
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
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbPurchase_type = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cmbFIO = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(18, 248);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(389, 30);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Оформить покупку";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnPerform_Purchase_Click);
            // 
            // cmbPurchase_type
            // 
            this.cmbPurchase_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchase_type.FormattingEnabled = true;
            this.cmbPurchase_type.Items.AddRange(new object[] {
            "Наличный",
            "Безналичный"});
            this.cmbPurchase_type.Location = new System.Drawing.Point(118, 204);
            this.cmbPurchase_type.Name = "cmbPurchase_type";
            this.cmbPurchase_type.Size = new System.Drawing.Size(289, 21);
            this.cmbPurchase_type.TabIndex = 22;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(118, 163);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(289, 20);
            this.date.TabIndex = 21;
            // 
            // cmbFIO
            // 
            this.cmbFIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFIO.FormattingEnabled = true;
            this.cmbFIO.Location = new System.Drawing.Point(118, 123);
            this.cmbFIO.Name = "cmbFIO";
            this.cmbFIO.Size = new System.Drawing.Size(289, 21);
            this.cmbFIO.TabIndex = 20;
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(118, 79);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(289, 21);
            this.cmbModel.TabIndex = 19;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(14, 206);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(98, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Тип оплаты:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 165);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Дата:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "ФИО:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Модель:";
            // 
            // AddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 295);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbPurchase_type);
            this.Controls.Add(this.date);
            this.Controls.Add(this.cmbFIO);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AddPurchase";
            this.Text = "Оформить покупку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private System.Windows.Forms.ComboBox cmbPurchase_type;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox cmbFIO;
        private System.Windows.Forms.ComboBox cmbModel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}