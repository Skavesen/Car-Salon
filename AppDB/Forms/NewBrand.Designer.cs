namespace AppDB.Forms
{
    partial class NewBrand
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
            this.txtbrand = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtbrand
            // 
            this.txtbrand.BackColor = System.Drawing.SystemColors.Window;
            this.txtbrand.Depth = 0;
            this.txtbrand.Hint = "";
            this.txtbrand.Location = new System.Drawing.Point(122, 80);
            this.txtbrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.PasswordChar = '\0';
            this.txtbrand.SelectedText = "";
            this.txtbrand.SelectionLength = 0;
            this.txtbrand.SelectionStart = 0;
            this.txtbrand.Size = new System.Drawing.Size(329, 23);
            this.txtbrand.TabIndex = 12;
            this.txtbrand.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(12, 147);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(210, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Марка:";
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(241, 147);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(210, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(462, 185);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(481, 203);
            this.Name = "NewBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtbrand;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
    }
}