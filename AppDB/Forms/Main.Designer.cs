namespace AppDB
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelCar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEddCar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddCar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDelPurchase = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEddPurchase = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddPurchase = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDeleteBrand = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEddBrand = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddBrand = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.btnDelTechnical_details = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEddTechnical_details = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddTechnical_details = new MaterialSkin.Controls.MaterialRaisedButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.dssdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьПокупкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоКупленныхМашинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лимитПродажПоБезналичномуРасчетуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьБекапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.TabSelector);
            this.panel1.Controls.Add(this.TabControl);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 479);
            this.panel1.TabIndex = 0;
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TabControl;
            this.TabSelector.Depth = 0;
            this.TabSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabSelector.Location = new System.Drawing.Point(0, 20);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(1279, 23);
            this.TabSelector.TabIndex = 2;
            this.TabSelector.Text = "materialTabSelector1";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Controls.Add(this.tabPage5);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControl.Location = new System.Drawing.Point(0, 43);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1279, 436);
            this.TabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteClient);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnEditClient);
            this.tabPage1.Controls.Add(this.btnAddClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1271, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Depth = 0;
            this.btnDeleteClient.Location = new System.Drawing.Point(1066, 64);
            this.btnDeleteClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Primary = true;
            this.btnDeleteClient.Size = new System.Drawing.Size(190, 23);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Удалить запись";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 404);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Depth = 0;
            this.btnEditClient.Location = new System.Drawing.Point(1066, 35);
            this.btnEditClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Primary = true;
            this.btnEditClient.Size = new System.Drawing.Size(190, 23);
            this.btnEditClient.TabIndex = 1;
            this.btnEditClient.Text = "Редактировать запись";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEddClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Depth = 0;
            this.btnAddClient.Location = new System.Drawing.Point(1066, 6);
            this.btnAddClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Primary = true;
            this.btnAddClient.Size = new System.Drawing.Size(190, 23);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Добавить запись";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelCar);
            this.tabPage2.Controls.Add(this.btnEddCar);
            this.tabPage2.Controls.Add(this.btnAddCar);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1271, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Автомобили";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelCar
            // 
            this.btnDelCar.Depth = 0;
            this.btnDelCar.Location = new System.Drawing.Point(1066, 64);
            this.btnDelCar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelCar.Name = "btnDelCar";
            this.btnDelCar.Primary = true;
            this.btnDelCar.Size = new System.Drawing.Size(190, 23);
            this.btnDelCar.TabIndex = 6;
            this.btnDelCar.Text = "Удалить запись";
            this.btnDelCar.UseVisualStyleBackColor = true;
            this.btnDelCar.Click += new System.EventHandler(this.btnDelCar_Click);
            // 
            // btnEddCar
            // 
            this.btnEddCar.Depth = 0;
            this.btnEddCar.Location = new System.Drawing.Point(1066, 35);
            this.btnEddCar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEddCar.Name = "btnEddCar";
            this.btnEddCar.Primary = true;
            this.btnEddCar.Size = new System.Drawing.Size(190, 23);
            this.btnEddCar.TabIndex = 5;
            this.btnEddCar.Text = "Редактировать запись";
            this.btnEddCar.UseVisualStyleBackColor = true;
            this.btnEddCar.Click += new System.EventHandler(this.btnEddCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Depth = 0;
            this.btnAddCar.Location = new System.Drawing.Point(1066, 6);
            this.btnAddCar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Primary = true;
            this.btnAddCar.Size = new System.Drawing.Size(190, 23);
            this.btnAddCar.TabIndex = 4;
            this.btnAddCar.Text = "Добавить запись";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 35;
            this.dataGridView2.Size = new System.Drawing.Size(1057, 404);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView2_Paint);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDelPurchase);
            this.tabPage3.Controls.Add(this.btnEddPurchase);
            this.tabPage3.Controls.Add(this.btnAddPurchase);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1271, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Покупки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDelPurchase
            // 
            this.btnDelPurchase.Depth = 0;
            this.btnDelPurchase.Location = new System.Drawing.Point(1068, 64);
            this.btnDelPurchase.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelPurchase.Name = "btnDelPurchase";
            this.btnDelPurchase.Primary = true;
            this.btnDelPurchase.Size = new System.Drawing.Size(190, 23);
            this.btnDelPurchase.TabIndex = 9;
            this.btnDelPurchase.Text = "Удалить запись";
            this.btnDelPurchase.UseVisualStyleBackColor = true;
            this.btnDelPurchase.Click += new System.EventHandler(this.btnDelPurchase_Click);
            // 
            // btnEddPurchase
            // 
            this.btnEddPurchase.Depth = 0;
            this.btnEddPurchase.Location = new System.Drawing.Point(1068, 35);
            this.btnEddPurchase.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEddPurchase.Name = "btnEddPurchase";
            this.btnEddPurchase.Primary = true;
            this.btnEddPurchase.Size = new System.Drawing.Size(190, 23);
            this.btnEddPurchase.TabIndex = 8;
            this.btnEddPurchase.Text = "Редактировать запись";
            this.btnEddPurchase.UseVisualStyleBackColor = true;
            this.btnEddPurchase.Click += new System.EventHandler(this.btnEddPurchase_Click);
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.Depth = 0;
            this.btnAddPurchase.Location = new System.Drawing.Point(1068, 6);
            this.btnAddPurchase.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Primary = true;
            this.btnAddPurchase.Size = new System.Drawing.Size(190, 23);
            this.btnAddPurchase.TabIndex = 7;
            this.btnAddPurchase.Text = "Добавить запись";
            this.btnAddPurchase.UseVisualStyleBackColor = true;
            this.btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 35;
            this.dataGridView3.Size = new System.Drawing.Size(1057, 404);
            this.dataGridView3.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDeleteBrand);
            this.tabPage4.Controls.Add(this.btnEddBrand);
            this.tabPage4.Controls.Add(this.btnAddBrand);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1271, 410);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Марки";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.Depth = 0;
            this.btnDeleteBrand.Location = new System.Drawing.Point(1066, 64);
            this.btnDeleteBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.Primary = true;
            this.btnDeleteBrand.Size = new System.Drawing.Size(190, 23);
            this.btnDeleteBrand.TabIndex = 9;
            this.btnDeleteBrand.Text = "Удалить запись";
            this.btnDeleteBrand.UseVisualStyleBackColor = true;
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // btnEddBrand
            // 
            this.btnEddBrand.Depth = 0;
            this.btnEddBrand.Location = new System.Drawing.Point(1066, 35);
            this.btnEddBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEddBrand.Name = "btnEddBrand";
            this.btnEddBrand.Primary = true;
            this.btnEddBrand.Size = new System.Drawing.Size(190, 23);
            this.btnEddBrand.TabIndex = 8;
            this.btnEddBrand.Text = "Редактировать запись";
            this.btnEddBrand.UseVisualStyleBackColor = true;
            this.btnEddBrand.Click += new System.EventHandler(this.btnEddBrand_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Depth = 0;
            this.btnAddBrand.Location = new System.Drawing.Point(1066, 6);
            this.btnAddBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Primary = true;
            this.btnAddBrand.Size = new System.Drawing.Size(190, 23);
            this.btnAddBrand.TabIndex = 7;
            this.btnAddBrand.Text = "Добавить запись";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 35;
            this.dataGridView4.Size = new System.Drawing.Size(1057, 404);
            this.dataGridView4.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Controls.Add(this.btnDelTechnical_details);
            this.tabPage5.Controls.Add(this.btnEddTechnical_details);
            this.tabPage5.Controls.Add(this.btnAddTechnical_details);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1271, 410);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Технические детали";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersWidth = 35;
            this.dataGridView5.Size = new System.Drawing.Size(1057, 404);
            this.dataGridView5.TabIndex = 10;
            // 
            // btnDelTechnical_details
            // 
            this.btnDelTechnical_details.Depth = 0;
            this.btnDelTechnical_details.Location = new System.Drawing.Point(1068, 64);
            this.btnDelTechnical_details.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelTechnical_details.Name = "btnDelTechnical_details";
            this.btnDelTechnical_details.Primary = true;
            this.btnDelTechnical_details.Size = new System.Drawing.Size(190, 23);
            this.btnDelTechnical_details.TabIndex = 9;
            this.btnDelTechnical_details.Text = "Удалить запись";
            this.btnDelTechnical_details.UseVisualStyleBackColor = true;
            this.btnDelTechnical_details.Click += new System.EventHandler(this.btnDelTechnical_details_Click);
            // 
            // btnEddTechnical_details
            // 
            this.btnEddTechnical_details.Depth = 0;
            this.btnEddTechnical_details.Location = new System.Drawing.Point(1068, 35);
            this.btnEddTechnical_details.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEddTechnical_details.Name = "btnEddTechnical_details";
            this.btnEddTechnical_details.Primary = true;
            this.btnEddTechnical_details.Size = new System.Drawing.Size(190, 23);
            this.btnEddTechnical_details.TabIndex = 8;
            this.btnEddTechnical_details.Text = "Редактировать запись";
            this.btnEddTechnical_details.UseVisualStyleBackColor = true;
            this.btnEddTechnical_details.Click += new System.EventHandler(this.btnEddTechnical_details_Click);
            // 
            // btnAddTechnical_details
            // 
            this.btnAddTechnical_details.Depth = 0;
            this.btnAddTechnical_details.Location = new System.Drawing.Point(1068, 6);
            this.btnAddTechnical_details.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTechnical_details.Name = "btnAddTechnical_details";
            this.btnAddTechnical_details.Primary = true;
            this.btnAddTechnical_details.Size = new System.Drawing.Size(190, 23);
            this.btnAddTechnical_details.TabIndex = 7;
            this.btnAddTechnical_details.Text = "Добавить запись";
            this.btnAddTechnical_details.UseVisualStyleBackColor = true;
            this.btnAddTechnical_details.Click += new System.EventHandler(this.btnAddTechnical_details_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit,
            this.dssdToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1279, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 20);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dssdToolStripMenuItem
            // 
            this.dssdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оформитьПокупкуToolStripMenuItem,
            this.количествоКупленныхМашинToolStripMenuItem,
            this.лимитПродажПоБезналичномуРасчетуToolStripMenuItem,
            this.сделатьБекапToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.dssdToolStripMenuItem.Name = "dssdToolStripMenuItem";
            this.dssdToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.dssdToolStripMenuItem.Text = "Действия";
            // 
            // оформитьПокупкуToolStripMenuItem
            // 
            this.оформитьПокупкуToolStripMenuItem.Name = "оформитьПокупкуToolStripMenuItem";
            this.оформитьПокупкуToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.оформитьПокупкуToolStripMenuItem.Text = "Оформить покупку";
            this.оформитьПокупкуToolStripMenuItem.Click += new System.EventHandler(this.оформитьПокупкуToolStripMenuItem_Click);
            // 
            // количествоКупленныхМашинToolStripMenuItem
            // 
            this.количествоКупленныхМашинToolStripMenuItem.Name = "количествоКупленныхМашинToolStripMenuItem";
            this.количествоКупленныхМашинToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.количествоКупленныхМашинToolStripMenuItem.Text = "Количество купленных моделей";
            this.количествоКупленныхМашинToolStripMenuItem.Click += new System.EventHandler(this.количествоКупленныхМашинToolStripMenuItem_Click);
            // 
            // лимитПродажПоБезналичномуРасчетуToolStripMenuItem
            // 
            this.лимитПродажПоБезналичномуРасчетуToolStripMenuItem.Name = "лимитПродажПоБезналичномуРасчетуToolStripMenuItem";
            this.лимитПродажПоБезналичномуРасчетуToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.лимитПродажПоБезналичномуРасчетуToolStripMenuItem.Text = "Лимит продаж по безналичному расчету";
            this.лимитПродажПоБезналичномуРасчетуToolStripMenuItem.Click += new System.EventHandler(this.лимитПродажПоБезналичномуРасчетуToolStripMenuItem_Click);
            // 
            // сделатьБекапToolStripMenuItem
            // 
            this.сделатьБекапToolStripMenuItem.Name = "сделатьБекапToolStripMenuItem";
            this.сделатьБекапToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.сделатьБекапToolStripMenuItem.Text = "Сделать бекап";
            this.сделатьБекапToolStripMenuItem.Click += new System.EventHandler(this.сделатьБекапToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1279, 544);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосалон";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem dssdToolStripMenuItem;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteClient;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditClient;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddClient;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelCar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEddCar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddCar;
        private System.Windows.Forms.DataGridView dataGridView4;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteBrand;
        private MaterialSkin.Controls.MaterialRaisedButton btnEddBrand;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddBrand;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelPurchase;
        private MaterialSkin.Controls.MaterialRaisedButton btnEddPurchase;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddPurchase;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView5;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelTechnical_details;
        private MaterialSkin.Controls.MaterialRaisedButton btnEddTechnical_details;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddTechnical_details;
        private System.Windows.Forms.ToolStripMenuItem оформитьПокупкуToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem количествоКупленныхМашинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лимитПродажПоБезналичномуРасчетуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьБекапToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
    }
}

