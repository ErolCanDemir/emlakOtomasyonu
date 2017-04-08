namespace AdvertApplication
{
    partial class AdvertsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertsForm));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RDSale = new System.Windows.Forms.RadioButton();
            this.RDRent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBAll = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.NUDIDSearch = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.NUDDepositMax = new System.Windows.Forms.NumericUpDown();
            this.NUDDepositMin = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NUDPriceMax = new System.Windows.Forms.NumericUpDown();
            this.NUDPriceMin = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.CBOAA = new System.Windows.Forms.CheckBox();
            this.CBHType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NUDAgeMax = new System.Windows.Forms.NumericUpDown();
            this.NUDAgeMin = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUDAreaMax = new System.Windows.Forms.NumericUpDown();
            this.NUDAreaMin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDFloorMax = new System.Windows.Forms.NumericUpDown();
            this.NUDFloorMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NUDRoomsMax = new System.Windows.Forms.NumericUpDown();
            this.NUDRoomsMin = new System.Windows.Forms.NumericUpDown();
            this.CBState = new System.Windows.Forms.ComboBox();
            this.CBCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDIDSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDepositMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDepositMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPriceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAgeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAgeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAreaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAreaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFloorMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFloorMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRoomsMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRoomsMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1607, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.type,
            this.rooms,
            this.floor,
            this.state,
            this.area,
            this.age,
            this.houseType,
            this.status,
            this.saleprice,
            this.rentprice,
            this.deposit});
            this.dataGridView1.Location = new System.Drawing.Point(379, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1339, 654);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.type.Frozen = true;
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 69;
            // 
            // rooms
            // 
            this.rooms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rooms.Frozen = true;
            this.rooms.HeaderText = "Rooms";
            this.rooms.Name = "rooms";
            this.rooms.ReadOnly = true;
            this.rooms.Width = 81;
            // 
            // floor
            // 
            this.floor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.floor.Frozen = true;
            this.floor.HeaderText = "Floor";
            this.floor.Name = "floor";
            this.floor.ReadOnly = true;
            this.floor.Width = 69;
            // 
            // state
            // 
            this.state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.state.Frozen = true;
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Width = 70;
            // 
            // area
            // 
            this.area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.area.Frozen = true;
            this.area.HeaderText = "Area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            this.area.Width = 67;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.age.Frozen = true;
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 62;
            // 
            // houseType
            // 
            this.houseType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.houseType.Frozen = true;
            this.houseType.HeaderText = "House Type";
            this.houseType.Name = "houseType";
            this.houseType.ReadOnly = true;
            this.houseType.Width = 114;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.Frozen = true;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 77;
            // 
            // saleprice
            // 
            this.saleprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.saleprice.Frozen = true;
            this.saleprice.HeaderText = "Sale Price";
            this.saleprice.Name = "saleprice";
            this.saleprice.ReadOnly = true;
            this.saleprice.Width = 101;
            // 
            // rentprice
            // 
            this.rentprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rentprice.Frozen = true;
            this.rentprice.HeaderText = "Rent Price";
            this.rentprice.Name = "rentprice";
            this.rentprice.ReadOnly = true;
            this.rentprice.Width = 103;
            // 
            // deposit
            // 
            this.deposit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deposit.Frozen = true;
            this.deposit.HeaderText = "Deposit";
            this.deposit.Name = "deposit";
            this.deposit.ReadOnly = true;
            this.deposit.Width = 85;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(379, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 93);
            this.button2.TabIndex = 2;
            this.button2.Text = "House Add";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(28, 692);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 94);
            this.button3.TabIndex = 4;
            this.button3.Text = "House Search";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RDSale
            // 
            this.RDSale.AutoSize = true;
            this.RDSale.Location = new System.Drawing.Point(101, 70);
            this.RDSale.Name = "RDSale";
            this.RDSale.Size = new System.Drawing.Size(57, 21);
            this.RDSale.TabIndex = 5;
            this.RDSale.Text = "Sale";
            this.RDSale.UseVisualStyleBackColor = true;
            this.RDSale.CheckedChanged += new System.EventHandler(this.RDSale_CheckedChanged);
            // 
            // RDRent
            // 
            this.RDRent.AutoSize = true;
            this.RDRent.Location = new System.Drawing.Point(164, 70);
            this.RDRent.Name = "RDRent";
            this.RDRent.Size = new System.Drawing.Size(59, 21);
            this.RDRent.TabIndex = 6;
            this.RDRent.Text = "Rent";
            this.RDRent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBAll);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.NUDIDSearch);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.NUDDepositMax);
            this.groupBox1.Controls.Add(this.NUDDepositMin);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.NUDPriceMax);
            this.groupBox1.Controls.Add(this.NUDPriceMin);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CBOAA);
            this.groupBox1.Controls.Add(this.CBHType);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.NUDAgeMax);
            this.groupBox1.Controls.Add(this.NUDAgeMin);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NUDAreaMax);
            this.groupBox1.Controls.Add(this.NUDAreaMin);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NUDFloorMax);
            this.groupBox1.Controls.Add(this.NUDFloorMin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NUDRoomsMax);
            this.groupBox1.Controls.Add(this.NUDRoomsMin);
            this.groupBox1.Controls.Add(this.CBState);
            this.groupBox1.Controls.Add(this.RDRent);
            this.groupBox1.Controls.Add(this.CBCity);
            this.groupBox1.Controls.Add(this.RDSale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 543);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Search";
            // 
            // RBAll
            // 
            this.RBAll.AutoSize = true;
            this.RBAll.Checked = true;
            this.RBAll.Location = new System.Drawing.Point(241, 70);
            this.RBAll.Name = "RBAll";
            this.RBAll.Size = new System.Drawing.Size(44, 21);
            this.RBAll.TabIndex = 10;
            this.RBAll.TabStop = true;
            this.RBAll.Text = "All";
            this.RBAll.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 461);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 17);
            this.label17.TabIndex = 9;
            this.label17.Text = "ID Search :";
            // 
            // NUDIDSearch
            // 
            this.NUDIDSearch.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUDIDSearch.Location = new System.Drawing.Point(101, 459);
            this.NUDIDSearch.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.NUDIDSearch.Name = "NUDIDSearch";
            this.NUDIDSearch.Size = new System.Drawing.Size(120, 22);
            this.NUDIDSearch.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(185, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 17);
            this.label14.TabIndex = 42;
            this.label14.Text = "-";
            // 
            // NUDDepositMax
            // 
            this.NUDDepositMax.Location = new System.Drawing.Point(204, 376);
            this.NUDDepositMax.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.NUDDepositMax.Name = "NUDDepositMax";
            this.NUDDepositMax.Size = new System.Drawing.Size(91, 22);
            this.NUDDepositMax.TabIndex = 41;
            // 
            // NUDDepositMin
            // 
            this.NUDDepositMin.Location = new System.Drawing.Point(101, 376);
            this.NUDDepositMin.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.NUDDepositMin.Name = "NUDDepositMin";
            this.NUDDepositMin.Size = new System.Drawing.Size(78, 22);
            this.NUDDepositMin.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "Deposit :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "-";
            // 
            // NUDPriceMax
            // 
            this.NUDPriceMax.Location = new System.Drawing.Point(204, 340);
            this.NUDPriceMax.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.NUDPriceMax.Name = "NUDPriceMax";
            this.NUDPriceMax.Size = new System.Drawing.Size(91, 22);
            this.NUDPriceMax.TabIndex = 37;
            // 
            // NUDPriceMin
            // 
            this.NUDPriceMin.Location = new System.Drawing.Point(101, 340);
            this.NUDPriceMin.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.NUDPriceMin.Name = "NUDPriceMin";
            this.NUDPriceMin.Size = new System.Drawing.Size(78, 22);
            this.NUDPriceMin.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Price :";
            // 
            // CBOAA
            // 
            this.CBOAA.AutoSize = true;
            this.CBOAA.Location = new System.Drawing.Point(14, 305);
            this.CBOAA.Name = "CBOAA";
            this.CBOAA.Size = new System.Drawing.Size(153, 21);
            this.CBOAA.TabIndex = 34;
            this.CBOAA.Text = "Only Active Adverts";
            this.CBOAA.UseVisualStyleBackColor = true;
            // 
            // CBHType
            // 
            this.CBHType.FormattingEnabled = true;
            this.CBHType.Items.AddRange(new object[] {
            "Apartment",
            "withGarden",
            "Dublex",
            "Sparate"});
            this.CBHType.Location = new System.Drawing.Point(101, 261);
            this.CBHType.Name = "CBHType";
            this.CBHType.Size = new System.Drawing.Size(194, 24);
            this.CBHType.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "H. Type :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "-";
            // 
            // NUDAgeMax
            // 
            this.NUDAgeMax.Location = new System.Drawing.Point(204, 222);
            this.NUDAgeMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDAgeMax.Name = "NUDAgeMax";
            this.NUDAgeMax.Size = new System.Drawing.Size(91, 22);
            this.NUDAgeMax.TabIndex = 30;
            // 
            // NUDAgeMin
            // 
            this.NUDAgeMin.Location = new System.Drawing.Point(101, 222);
            this.NUDAgeMin.Name = "NUDAgeMin";
            this.NUDAgeMin.Size = new System.Drawing.Size(78, 22);
            this.NUDAgeMin.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Age :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "-";
            // 
            // NUDAreaMax
            // 
            this.NUDAreaMax.Location = new System.Drawing.Point(204, 185);
            this.NUDAreaMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDAreaMax.Name = "NUDAreaMax";
            this.NUDAreaMax.Size = new System.Drawing.Size(91, 22);
            this.NUDAreaMax.TabIndex = 26;
            // 
            // NUDAreaMin
            // 
            this.NUDAreaMin.Location = new System.Drawing.Point(101, 185);
            this.NUDAreaMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDAreaMin.Name = "NUDAreaMin";
            this.NUDAreaMin.Size = new System.Drawing.Size(78, 22);
            this.NUDAreaMin.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Area :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "-";
            // 
            // NUDFloorMax
            // 
            this.NUDFloorMax.Location = new System.Drawing.Point(204, 146);
            this.NUDFloorMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDFloorMax.Name = "NUDFloorMax";
            this.NUDFloorMax.Size = new System.Drawing.Size(91, 22);
            this.NUDFloorMax.TabIndex = 22;
            // 
            // NUDFloorMin
            // 
            this.NUDFloorMin.Location = new System.Drawing.Point(101, 146);
            this.NUDFloorMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDFloorMin.Name = "NUDFloorMin";
            this.NUDFloorMin.Size = new System.Drawing.Size(78, 22);
            this.NUDFloorMin.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Floor :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "-";
            // 
            // NUDRoomsMax
            // 
            this.NUDRoomsMax.Location = new System.Drawing.Point(204, 106);
            this.NUDRoomsMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDRoomsMax.Name = "NUDRoomsMax";
            this.NUDRoomsMax.Size = new System.Drawing.Size(91, 22);
            this.NUDRoomsMax.TabIndex = 18;
            // 
            // NUDRoomsMin
            // 
            this.NUDRoomsMin.Location = new System.Drawing.Point(101, 106);
            this.NUDRoomsMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDRoomsMin.Name = "NUDRoomsMin";
            this.NUDRoomsMin.Size = new System.Drawing.Size(78, 22);
            this.NUDRoomsMin.TabIndex = 17;
            // 
            // CBState
            // 
            this.CBState.FormattingEnabled = true;
            this.CBState.Location = new System.Drawing.Point(204, 30);
            this.CBState.Name = "CBState";
            this.CBState.Size = new System.Drawing.Size(91, 24);
            this.CBState.TabIndex = 16;
            // 
            // CBCity
            // 
            this.CBCity.FormattingEnabled = true;
            this.CBCity.Location = new System.Drawing.Point(101, 30);
            this.CBCity.Name = "CBCity";
            this.CBCity.Size = new System.Drawing.Size(97, 24);
            this.CBCity.TabIndex = 15;
            this.CBCity.SelectedIndexChanged += new System.EventHandler(this.CBCity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rooms :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "City / State :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 93);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BTClearSearch
            // 
            this.BTClearSearch.Image = ((System.Drawing.Image)(resources.GetObject("BTClearSearch.Image")));
            this.BTClearSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTClearSearch.Location = new System.Drawing.Point(269, 692);
            this.BTClearSearch.Name = "BTClearSearch";
            this.BTClearSearch.Size = new System.Drawing.Size(82, 90);
            this.BTClearSearch.TabIndex = 9;
            this.BTClearSearch.Text = "Clear Seacrh";
            this.BTClearSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTClearSearch.UseVisualStyleBackColor = true;
            this.BTClearSearch.Click += new System.EventHandler(this.BTClearSearch_Click);
            // 
            // AdvertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 796);
            this.Controls.Add(this.BTClearSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "AdvertsForm";
            this.Text = "Advert Application ";
            this.Load += new System.EventHandler(this.AdvertsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDIDSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDepositMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDepositMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPriceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAgeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAgeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAreaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAreaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFloorMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFloorMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRoomsMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRoomsMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton RDSale;
        private System.Windows.Forms.RadioButton RDRent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown NUDDepositMax;
        private System.Windows.Forms.NumericUpDown NUDDepositMin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown NUDPriceMax;
        private System.Windows.Forms.NumericUpDown NUDPriceMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox CBOAA;
        private System.Windows.Forms.ComboBox CBHType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NUDAgeMax;
        private System.Windows.Forms.NumericUpDown NUDAgeMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUDAreaMax;
        private System.Windows.Forms.NumericUpDown NUDAreaMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDFloorMax;
        private System.Windows.Forms.NumericUpDown NUDFloorMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUDRoomsMax;
        private System.Windows.Forms.NumericUpDown NUDRoomsMin;
        private System.Windows.Forms.ComboBox CBState;
        private System.Windows.Forms.ComboBox CBCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown NUDIDSearch;
        private System.Windows.Forms.Button BTClearSearch;
        private System.Windows.Forms.RadioButton RBAll;
    }
}