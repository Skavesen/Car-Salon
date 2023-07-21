namespace AppDB.Forms
{
    partial class BackupForm
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
            this.btnSelectBackUp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtLocationBackup = new System.Windows.Forms.TextBox();
            this.btnMakeBackup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnSelectBackUp
            // 
            this.btnSelectBackUp.Depth = 0;
            this.btnSelectBackUp.Location = new System.Drawing.Point(12, 69);
            this.btnSelectBackUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectBackUp.Name = "btnSelectBackUp";
            this.btnSelectBackUp.Primary = true;
            this.btnSelectBackUp.Size = new System.Drawing.Size(422, 29);
            this.btnSelectBackUp.TabIndex = 0;
            this.btnSelectBackUp.Text = "Сохранить резервную копию как";
            this.btnSelectBackUp.UseVisualStyleBackColor = true;
            this.btnSelectBackUp.Click += new System.EventHandler(this.btnSelectBackUp_Click);
            // 
            // txtLocationBackup
            // 
            this.txtLocationBackup.Location = new System.Drawing.Point(12, 104);
            this.txtLocationBackup.Multiline = true;
            this.txtLocationBackup.Name = "txtLocationBackup";
            this.txtLocationBackup.ReadOnly = true;
            this.txtLocationBackup.Size = new System.Drawing.Size(422, 75);
            this.txtLocationBackup.TabIndex = 1;
            // 
            // btnMakeBackup
            // 
            this.btnMakeBackup.Depth = 0;
            this.btnMakeBackup.Location = new System.Drawing.Point(12, 185);
            this.btnMakeBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMakeBackup.Name = "btnMakeBackup";
            this.btnMakeBackup.Primary = true;
            this.btnMakeBackup.Size = new System.Drawing.Size(422, 29);
            this.btnMakeBackup.TabIndex = 2;
            this.btnMakeBackup.Text = "Сделать резервную копию для БД";
            this.btnMakeBackup.UseVisualStyleBackColor = true;
            this.btnMakeBackup.Click += new System.EventHandler(this.btnMakeBackup_Click);
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 236);
            this.Controls.Add(this.btnMakeBackup);
            this.Controls.Add(this.txtLocationBackup);
            this.Controls.Add(this.btnSelectBackUp);
            this.MaximizeBox = false;
            this.Name = "BackupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSelectBackUp;
        private System.Windows.Forms.TextBox txtLocationBackup;
        private MaterialSkin.Controls.MaterialRaisedButton btnMakeBackup;
    }
}