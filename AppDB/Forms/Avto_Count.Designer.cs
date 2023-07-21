namespace AppDB.Forms
{
    partial class Avto_Count
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSaveDiagram = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 307);
            this.dataGridView1.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(440, 73);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(448, 353);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // btnSaveDiagram
            // 
            this.btnSaveDiagram.Depth = 0;
            this.btnSaveDiagram.Location = new System.Drawing.Point(98, 407);
            this.btnSaveDiagram.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveDiagram.Name = "btnSaveDiagram";
            this.btnSaveDiagram.Primary = true;
            this.btnSaveDiagram.Size = new System.Drawing.Size(215, 23);
            this.btnSaveDiagram.TabIndex = 7;
            this.btnSaveDiagram.Text = "Сохранить диаграмму";
            this.btnSaveDiagram.UseVisualStyleBackColor = true;
            this.btnSaveDiagram.Click += new System.EventHandler(this.btnSaveDiagram_Click);
            // 
            // Avto_Count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 438);
            this.Controls.Add(this.btnSaveDiagram);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Avto_Count";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Количество купленных моделей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveDiagram;
    }
}