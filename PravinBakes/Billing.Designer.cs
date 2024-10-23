namespace PravinBakes
{
    partial class Billing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Drinks = new System.Windows.Forms.Button();
            this.btn_Chocolates = new System.Windows.Forms.Button();
            this.btn_Chips = new System.Windows.Forms.Button();
            this.btn_Biscuits = new System.Windows.Forms.Button();
            this.gbox_biscuits = new System.Windows.Forms.GroupBox();
            this.btn_Goodday = new System.Windows.Forms.Button();
            this.btn_Hideseek = new System.Windows.Forms.Button();
            this.btn_Fifty = new System.Windows.Forms.Button();
            this.btn_MilkBikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.txt_Cost = new System.Windows.Forms.TextBox();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.cmb_Quantity = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.gBox_Chips = new System.Windows.Forms.GroupBox();
            this.btn_Kurkure = new System.Windows.Forms.Button();
            this.btn_Lays = new System.Windows.Forms.Button();
            this.btn_Doritos = new System.Windows.Forms.Button();
            this.btn_Cheetos = new System.Windows.Forms.Button();
            this.gBox_Chocolates = new System.Windows.Forms.GroupBox();
            this.btn_Milky = new System.Windows.Forms.Button();
            this.btn_FiveStar = new System.Windows.Forms.Button();
            this.btn_Kitkat = new System.Windows.Forms.Button();
            this.btn_Dairy = new System.Windows.Forms.Button();
            this.gBox_Drinks = new System.Windows.Forms.GroupBox();
            this.btn_Bovonto = new System.Windows.Forms.Button();
            this.btn_Slice = new System.Windows.Forms.Button();
            this.btn_Fanta = new System.Windows.Forms.Button();
            this.btn_Sevenup = new System.Windows.Forms.Button();
            this.picBox_Exit = new System.Windows.Forms.PictureBox();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.lbl_CustomerID = new System.Windows.Forms.Label();
            this.txt_Billedby = new System.Windows.Forms.TextBox();
            this.lbl_Billedby = new System.Windows.Forms.Label();
            this.txt_Gst = new System.Windows.Forms.TextBox();
            this.lbl_Gst = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.cmb_CashOnline = new System.Windows.Forms.ComboBox();
            this.txt_BillNumber = new System.Windows.Forms.TextBox();
            this.lbl_BillId = new System.Windows.Forms.Label();
            this.lbl_Mode = new System.Windows.Forms.Label();
            this.add_Btn = new System.Windows.Forms.Button();
            this.txt_ProductId = new System.Windows.Forms.TextBox();
            this.lbl_ProductId = new System.Windows.Forms.Label();
            this.txt_MbNo = new System.Windows.Forms.TextBox();
            this.lbl_CusMbNo = new System.Windows.Forms.Label();
            this.btn_CusId = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbox_biscuits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBox_Chips.SuspendLayout();
            this.gBox_Chocolates.SuspendLayout();
            this.gBox_Drinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Drinks);
            this.groupBox1.Controls.Add(this.btn_Chocolates);
            this.groupBox1.Controls.Add(this.btn_Chips);
            this.groupBox1.Controls.Add(this.btn_Biscuits);
            this.groupBox1.Location = new System.Drawing.Point(217, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Drinks
            // 
            this.btn_Drinks.BackgroundImage = global::PravinBakes.Properties.Resources.cooldrinks;
            this.btn_Drinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Drinks.Location = new System.Drawing.Point(910, 21);
            this.btn_Drinks.Name = "btn_Drinks";
            this.btn_Drinks.Size = new System.Drawing.Size(138, 96);
            this.btn_Drinks.TabIndex = 3;
            this.btn_Drinks.UseVisualStyleBackColor = true;
            this.btn_Drinks.Click += new System.EventHandler(this.btn_Drinks_Click);
            // 
            // btn_Chocolates
            // 
            this.btn_Chocolates.BackgroundImage = global::PravinBakes.Properties.Resources.chocolates;
            this.btn_Chocolates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Chocolates.Location = new System.Drawing.Point(640, 21);
            this.btn_Chocolates.Name = "btn_Chocolates";
            this.btn_Chocolates.Size = new System.Drawing.Size(138, 96);
            this.btn_Chocolates.TabIndex = 2;
            this.btn_Chocolates.UseVisualStyleBackColor = true;
            this.btn_Chocolates.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Chips
            // 
            this.btn_Chips.BackgroundImage = global::PravinBakes.Properties.Resources.chips;
            this.btn_Chips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Chips.Location = new System.Drawing.Point(370, 21);
            this.btn_Chips.Name = "btn_Chips";
            this.btn_Chips.Size = new System.Drawing.Size(138, 96);
            this.btn_Chips.TabIndex = 1;
            this.btn_Chips.UseVisualStyleBackColor = true;
            this.btn_Chips.Click += new System.EventHandler(this.btn_Chips_Click);
            // 
            // btn_Biscuits
            // 
            this.btn_Biscuits.BackgroundImage = global::PravinBakes.Properties.Resources.cookies;
            this.btn_Biscuits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Biscuits.Location = new System.Drawing.Point(100, 21);
            this.btn_Biscuits.Name = "btn_Biscuits";
            this.btn_Biscuits.Size = new System.Drawing.Size(138, 96);
            this.btn_Biscuits.TabIndex = 0;
            this.btn_Biscuits.UseVisualStyleBackColor = true;
            this.btn_Biscuits.Click += new System.EventHandler(this.btn_Biscuits_Click);
            // 
            // gbox_biscuits
            // 
            this.gbox_biscuits.Controls.Add(this.btn_Goodday);
            this.gbox_biscuits.Controls.Add(this.btn_Hideseek);
            this.gbox_biscuits.Controls.Add(this.btn_Fifty);
            this.gbox_biscuits.Controls.Add(this.btn_MilkBikis);
            this.gbox_biscuits.Location = new System.Drawing.Point(28, 199);
            this.gbox_biscuits.Name = "gbox_biscuits";
            this.gbox_biscuits.Size = new System.Drawing.Size(601, 305);
            this.gbox_biscuits.TabIndex = 1;
            this.gbox_biscuits.TabStop = false;
            this.gbox_biscuits.Text = "Biscuits";
            // 
            // btn_Goodday
            // 
            this.btn_Goodday.BackgroundImage = global::PravinBakes.Properties.Resources.goodday;
            this.btn_Goodday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Goodday.Location = new System.Drawing.Point(305, 163);
            this.btn_Goodday.Name = "btn_Goodday";
            this.btn_Goodday.Size = new System.Drawing.Size(138, 96);
            this.btn_Goodday.TabIndex = 4;
            this.btn_Goodday.UseVisualStyleBackColor = true;
            this.btn_Goodday.Click += new System.EventHandler(this.btn_Goodday_Click);
            // 
            // btn_Hideseek
            // 
            this.btn_Hideseek.BackgroundImage = global::PravinBakes.Properties.Resources.hideseek;
            this.btn_Hideseek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Hideseek.Location = new System.Drawing.Point(131, 163);
            this.btn_Hideseek.Name = "btn_Hideseek";
            this.btn_Hideseek.Size = new System.Drawing.Size(138, 96);
            this.btn_Hideseek.TabIndex = 3;
            this.btn_Hideseek.UseVisualStyleBackColor = true;
            this.btn_Hideseek.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_Fifty
            // 
            this.btn_Fifty.BackgroundImage = global::PravinBakes.Properties.Resources._5050bis;
            this.btn_Fifty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Fifty.Location = new System.Drawing.Point(303, 49);
            this.btn_Fifty.Name = "btn_Fifty";
            this.btn_Fifty.Size = new System.Drawing.Size(138, 96);
            this.btn_Fifty.TabIndex = 2;
            this.btn_Fifty.UseVisualStyleBackColor = true;
            this.btn_Fifty.Click += new System.EventHandler(this.btn_Fifty_Click);
            // 
            // btn_MilkBikis
            // 
            this.btn_MilkBikis.BackgroundImage = global::PravinBakes.Properties.Resources.milkbikis;
            this.btn_MilkBikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MilkBikis.Location = new System.Drawing.Point(131, 49);
            this.btn_MilkBikis.Name = "btn_MilkBikis";
            this.btn_MilkBikis.Size = new System.Drawing.Size(138, 96);
            this.btn_MilkBikis.TabIndex = 1;
            this.btn_MilkBikis.UseVisualStyleBackColor = true;
            this.btn_MilkBikis.Click += new System.EventHandler(this.btn_MilkBikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Quantity,
            this.Amount,
            this.productId});
            this.dataGridView1.Location = new System.Drawing.Point(667, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 394);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product_Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // productId
            // 
            this.productId.HeaderText = "productId";
            this.productId.MinimumWidth = 6;
            this.productId.Name = "productId";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductName.Location = new System.Drawing.Point(28, 558);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(183, 35);
            this.txt_ProductName.TabIndex = 12;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProductName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(24, 527);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(165, 26);
            this.lbl_ProductName.TabIndex = 11;
            this.lbl_ProductName.Text = "Product Name";
            // 
            // txt_Cost
            // 
            this.txt_Cost.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cost.Location = new System.Drawing.Point(232, 558);
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(183, 35);
            this.txt_Cost.TabIndex = 14;
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.AutoSize = true;
            this.lbl_Cost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cost.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cost.Location = new System.Drawing.Point(228, 527);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(60, 26);
            this.lbl_Cost.TabIndex = 13;
            this.lbl_Cost.Text = "Cost";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Quantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(433, 527);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(108, 26);
            this.lbl_Quantity.TabIndex = 15;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // cmb_Quantity
            // 
            this.cmb_Quantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F);
            this.cmb_Quantity.FormattingEnabled = true;
            this.cmb_Quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_Quantity.Location = new System.Drawing.Point(438, 558);
            this.cmb_Quantity.Name = "cmb_Quantity";
            this.cmb_Quantity.Size = new System.Drawing.Size(183, 36);
            this.cmb_Quantity.TabIndex = 16;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Cancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(300, 618);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(140, 56);
            this.btn_Cancel.TabIndex = 24;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // gBox_Chips
            // 
            this.gBox_Chips.Controls.Add(this.btn_Kurkure);
            this.gBox_Chips.Controls.Add(this.btn_Lays);
            this.gBox_Chips.Controls.Add(this.btn_Doritos);
            this.gBox_Chips.Controls.Add(this.btn_Cheetos);
            this.gBox_Chips.Location = new System.Drawing.Point(28, 199);
            this.gBox_Chips.Name = "gBox_Chips";
            this.gBox_Chips.Size = new System.Drawing.Size(601, 305);
            this.gBox_Chips.TabIndex = 25;
            this.gBox_Chips.TabStop = false;
            this.gBox_Chips.Text = "Chips";
            // 
            // btn_Kurkure
            // 
            this.btn_Kurkure.BackgroundImage = global::PravinBakes.Properties.Resources.kurkure;
            this.btn_Kurkure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Kurkure.Location = new System.Drawing.Point(305, 163);
            this.btn_Kurkure.Name = "btn_Kurkure";
            this.btn_Kurkure.Size = new System.Drawing.Size(138, 96);
            this.btn_Kurkure.TabIndex = 4;
            this.btn_Kurkure.UseVisualStyleBackColor = true;
            this.btn_Kurkure.Click += new System.EventHandler(this.btn_Kurkure_Click);
            // 
            // btn_Lays
            // 
            this.btn_Lays.BackgroundImage = global::PravinBakes.Properties.Resources.lays;
            this.btn_Lays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Lays.Location = new System.Drawing.Point(131, 163);
            this.btn_Lays.Name = "btn_Lays";
            this.btn_Lays.Size = new System.Drawing.Size(138, 96);
            this.btn_Lays.TabIndex = 3;
            this.btn_Lays.UseVisualStyleBackColor = true;
            this.btn_Lays.Click += new System.EventHandler(this.btn_Lays_Click);
            // 
            // btn_Doritos
            // 
            this.btn_Doritos.BackgroundImage = global::PravinBakes.Properties.Resources.doritos;
            this.btn_Doritos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Doritos.Location = new System.Drawing.Point(303, 49);
            this.btn_Doritos.Name = "btn_Doritos";
            this.btn_Doritos.Size = new System.Drawing.Size(138, 96);
            this.btn_Doritos.TabIndex = 2;
            this.btn_Doritos.UseVisualStyleBackColor = true;
            this.btn_Doritos.Click += new System.EventHandler(this.btn_Doritos_Click);
            // 
            // btn_Cheetos
            // 
            this.btn_Cheetos.BackgroundImage = global::PravinBakes.Properties.Resources.cheetos;
            this.btn_Cheetos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cheetos.Location = new System.Drawing.Point(131, 49);
            this.btn_Cheetos.Name = "btn_Cheetos";
            this.btn_Cheetos.Size = new System.Drawing.Size(138, 96);
            this.btn_Cheetos.TabIndex = 1;
            this.btn_Cheetos.UseVisualStyleBackColor = true;
            this.btn_Cheetos.Click += new System.EventHandler(this.btn_Cheetos_Click);
            // 
            // gBox_Chocolates
            // 
            this.gBox_Chocolates.Controls.Add(this.btn_Milky);
            this.gBox_Chocolates.Controls.Add(this.btn_FiveStar);
            this.gBox_Chocolates.Controls.Add(this.btn_Kitkat);
            this.gBox_Chocolates.Controls.Add(this.btn_Dairy);
            this.gBox_Chocolates.Location = new System.Drawing.Point(28, 199);
            this.gBox_Chocolates.Name = "gBox_Chocolates";
            this.gBox_Chocolates.Size = new System.Drawing.Size(601, 305);
            this.gBox_Chocolates.TabIndex = 26;
            this.gBox_Chocolates.TabStop = false;
            this.gBox_Chocolates.Text = "Chocolates";
            // 
            // btn_Milky
            // 
            this.btn_Milky.BackgroundImage = global::PravinBakes.Properties.Resources.milkybar;
            this.btn_Milky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milky.Location = new System.Drawing.Point(305, 163);
            this.btn_Milky.Name = "btn_Milky";
            this.btn_Milky.Size = new System.Drawing.Size(138, 96);
            this.btn_Milky.TabIndex = 4;
            this.btn_Milky.UseVisualStyleBackColor = true;
            this.btn_Milky.Click += new System.EventHandler(this.btn_Milky_Click);
            // 
            // btn_FiveStar
            // 
            this.btn_FiveStar.BackgroundImage = global::PravinBakes.Properties.Resources._5star;
            this.btn_FiveStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FiveStar.Location = new System.Drawing.Point(131, 163);
            this.btn_FiveStar.Name = "btn_FiveStar";
            this.btn_FiveStar.Size = new System.Drawing.Size(138, 96);
            this.btn_FiveStar.TabIndex = 3;
            this.btn_FiveStar.UseVisualStyleBackColor = true;
            this.btn_FiveStar.Click += new System.EventHandler(this.btn_FiveStar_Click);
            // 
            // btn_Kitkat
            // 
            this.btn_Kitkat.BackgroundImage = global::PravinBakes.Properties.Resources.kitkat;
            this.btn_Kitkat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Kitkat.Location = new System.Drawing.Point(303, 49);
            this.btn_Kitkat.Name = "btn_Kitkat";
            this.btn_Kitkat.Size = new System.Drawing.Size(138, 96);
            this.btn_Kitkat.TabIndex = 2;
            this.btn_Kitkat.UseVisualStyleBackColor = true;
            this.btn_Kitkat.Click += new System.EventHandler(this.btn_Kitkat_Click);
            // 
            // btn_Dairy
            // 
            this.btn_Dairy.BackgroundImage = global::PravinBakes.Properties.Resources.dairymilk;
            this.btn_Dairy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Dairy.Location = new System.Drawing.Point(131, 49);
            this.btn_Dairy.Name = "btn_Dairy";
            this.btn_Dairy.Size = new System.Drawing.Size(138, 96);
            this.btn_Dairy.TabIndex = 1;
            this.btn_Dairy.UseVisualStyleBackColor = true;
            this.btn_Dairy.Click += new System.EventHandler(this.btn_Dairy_Click);
            // 
            // gBox_Drinks
            // 
            this.gBox_Drinks.Controls.Add(this.btn_Bovonto);
            this.gBox_Drinks.Controls.Add(this.btn_Slice);
            this.gBox_Drinks.Controls.Add(this.btn_Fanta);
            this.gBox_Drinks.Controls.Add(this.btn_Sevenup);
            this.gBox_Drinks.Location = new System.Drawing.Point(28, 199);
            this.gBox_Drinks.Name = "gBox_Drinks";
            this.gBox_Drinks.Size = new System.Drawing.Size(601, 305);
            this.gBox_Drinks.TabIndex = 27;
            this.gBox_Drinks.TabStop = false;
            this.gBox_Drinks.Text = "Cool Drinks";
            // 
            // btn_Bovonto
            // 
            this.btn_Bovonto.BackgroundImage = global::PravinBakes.Properties.Resources.bovonto;
            this.btn_Bovonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Bovonto.Location = new System.Drawing.Point(305, 163);
            this.btn_Bovonto.Name = "btn_Bovonto";
            this.btn_Bovonto.Size = new System.Drawing.Size(138, 96);
            this.btn_Bovonto.TabIndex = 4;
            this.btn_Bovonto.UseVisualStyleBackColor = true;
            this.btn_Bovonto.Click += new System.EventHandler(this.btn_Bovonto_Click);
            // 
            // btn_Slice
            // 
            this.btn_Slice.BackgroundImage = global::PravinBakes.Properties.Resources.slice;
            this.btn_Slice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Slice.Location = new System.Drawing.Point(131, 163);
            this.btn_Slice.Name = "btn_Slice";
            this.btn_Slice.Size = new System.Drawing.Size(138, 96);
            this.btn_Slice.TabIndex = 3;
            this.btn_Slice.UseVisualStyleBackColor = true;
            this.btn_Slice.Click += new System.EventHandler(this.btn_Slice_Click);
            // 
            // btn_Fanta
            // 
            this.btn_Fanta.BackgroundImage = global::PravinBakes.Properties.Resources.fanta;
            this.btn_Fanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Fanta.Location = new System.Drawing.Point(303, 49);
            this.btn_Fanta.Name = "btn_Fanta";
            this.btn_Fanta.Size = new System.Drawing.Size(138, 96);
            this.btn_Fanta.TabIndex = 2;
            this.btn_Fanta.UseVisualStyleBackColor = true;
            this.btn_Fanta.Click += new System.EventHandler(this.btn_Fanta_Click);
            // 
            // btn_Sevenup
            // 
            this.btn_Sevenup.BackgroundImage = global::PravinBakes.Properties.Resources._7up;
            this.btn_Sevenup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sevenup.Location = new System.Drawing.Point(131, 49);
            this.btn_Sevenup.Name = "btn_Sevenup";
            this.btn_Sevenup.Size = new System.Drawing.Size(138, 96);
            this.btn_Sevenup.TabIndex = 1;
            this.btn_Sevenup.UseVisualStyleBackColor = true;
            this.btn_Sevenup.Click += new System.EventHandler(this.btn_Sevenup_Click);
            // 
            // picBox_Exit
            // 
            this.picBox_Exit.Image = global::PravinBakes.Properties.Resources.exit;
            this.picBox_Exit.Location = new System.Drawing.Point(1423, 2);
            this.picBox_Exit.Name = "picBox_Exit";
            this.picBox_Exit.Size = new System.Drawing.Size(52, 45);
            this.picBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Exit.TabIndex = 8;
            this.picBox_Exit.TabStop = false;
            this.picBox_Exit.Click += new System.EventHandler(this.picBox_Exit_Click);
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerID.Location = new System.Drawing.Point(233, 730);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(183, 35);
            this.txt_CustomerID.TabIndex = 31;
            // 
            // lbl_CustomerID
            // 
            this.lbl_CustomerID.AutoSize = true;
            this.lbl_CustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CustomerID.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerID.Location = new System.Drawing.Point(229, 699);
            this.lbl_CustomerID.Name = "lbl_CustomerID";
            this.lbl_CustomerID.Size = new System.Drawing.Size(147, 26);
            this.lbl_CustomerID.TabIndex = 30;
            this.lbl_CustomerID.Text = "Customer Id";
            // 
            // txt_Billedby
            // 
            this.txt_Billedby.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Billedby.Location = new System.Drawing.Point(12, 60);
            this.txt_Billedby.Name = "txt_Billedby";
            this.txt_Billedby.Size = new System.Drawing.Size(183, 35);
            this.txt_Billedby.TabIndex = 29;
            this.txt_Billedby.TextChanged += new System.EventHandler(this.txt_Billedby_TextChanged);
            // 
            // lbl_Billedby
            // 
            this.lbl_Billedby.AutoSize = true;
            this.lbl_Billedby.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Billedby.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Billedby.Location = new System.Drawing.Point(8, 29);
            this.lbl_Billedby.Name = "lbl_Billedby";
            this.lbl_Billedby.Size = new System.Drawing.Size(110, 26);
            this.lbl_Billedby.TabIndex = 28;
            this.lbl_Billedby.Text = "Billed By";
            // 
            // txt_Gst
            // 
            this.txt_Gst.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gst.Location = new System.Drawing.Point(893, 666);
            this.txt_Gst.Name = "txt_Gst";
            this.txt_Gst.Size = new System.Drawing.Size(183, 35);
            this.txt_Gst.TabIndex = 35;
            this.txt_Gst.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl_Gst
            // 
            this.lbl_Gst.AutoSize = true;
            this.lbl_Gst.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gst.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gst.Location = new System.Drawing.Point(689, 666);
            this.lbl_Gst.Name = "lbl_Gst";
            this.lbl_Gst.Size = new System.Drawing.Size(63, 28);
            this.lbl_Gst.TabIndex = 34;
            this.lbl_Gst.Text = "GST";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(893, 609);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(183, 35);
            this.txt_Amount.TabIndex = 33;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Amount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(689, 617);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(97, 26);
            this.lbl_Amount.TabIndex = 32;
            this.lbl_Amount.Text = "Amount";
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(893, 721);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(183, 35);
            this.txt_Total.TabIndex = 37;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(689, 721);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(160, 26);
            this.lbl_Total.TabIndex = 36;
            this.lbl_Total.Text = "Total Amount";
            // 
            // btn_Bill
            // 
            this.btn_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Bill.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bill.Location = new System.Drawing.Point(1226, 730);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Size = new System.Drawing.Size(117, 62);
            this.btn_Bill.TabIndex = 38;
            this.btn_Bill.Text = "BILL";
            this.btn_Bill.UseVisualStyleBackColor = false;
            this.btn_Bill.Click += new System.EventHandler(this.btn_Bill_Click);
            // 
            // cmb_CashOnline
            // 
            this.cmb_CashOnline.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F);
            this.cmb_CashOnline.FormattingEnabled = true;
            this.cmb_CashOnline.Items.AddRange(new object[] {
            "Online",
            "Cash"});
            this.cmb_CashOnline.Location = new System.Drawing.Point(1212, 665);
            this.cmb_CashOnline.Name = "cmb_CashOnline";
            this.cmb_CashOnline.Size = new System.Drawing.Size(183, 36);
            this.cmb_CashOnline.TabIndex = 39;
            this.cmb_CashOnline.SelectedIndexChanged += new System.EventHandler(this.cmb_CashOnline_SelectedIndexChanged);
            // 
            // txt_BillNumber
            // 
            this.txt_BillNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BillNumber.Location = new System.Drawing.Point(1212, 608);
            this.txt_BillNumber.Name = "txt_BillNumber";
            this.txt_BillNumber.Size = new System.Drawing.Size(183, 35);
            this.txt_BillNumber.TabIndex = 41;
            this.txt_BillNumber.TextChanged += new System.EventHandler(this.txt_BillNumber_TextChanged);
            // 
            // lbl_BillId
            // 
            this.lbl_BillId.AutoSize = true;
            this.lbl_BillId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BillId.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BillId.Location = new System.Drawing.Point(1114, 617);
            this.lbl_BillId.Name = "lbl_BillId";
            this.lbl_BillId.Size = new System.Drawing.Size(78, 26);
            this.lbl_BillId.TabIndex = 40;
            this.lbl_BillId.Text = "Bill Id";
            // 
            // lbl_Mode
            // 
            this.lbl_Mode.AutoSize = true;
            this.lbl_Mode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mode.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mode.Location = new System.Drawing.Point(1114, 675);
            this.lbl_Mode.Name = "lbl_Mode";
            this.lbl_Mode.Size = new System.Drawing.Size(69, 26);
            this.lbl_Mode.TabIndex = 42;
            this.lbl_Mode.Text = "Mode";
            // 
            // add_Btn
            // 
            this.add_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add_Btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Btn.Location = new System.Drawing.Point(148, 618);
            this.add_Btn.Name = "add_Btn";
            this.add_Btn.Size = new System.Drawing.Size(140, 56);
            this.add_Btn.TabIndex = 43;
            this.add_Btn.Text = "Add";
            this.add_Btn.UseVisualStyleBackColor = false;
            this.add_Btn.Click += new System.EventHandler(this.add_Btn_Click);
            // 
            // txt_ProductId
            // 
            this.txt_ProductId.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductId.Location = new System.Drawing.Point(446, 730);
            this.txt_ProductId.Name = "txt_ProductId";
            this.txt_ProductId.Size = new System.Drawing.Size(183, 35);
            this.txt_ProductId.TabIndex = 45;
            // 
            // lbl_ProductId
            // 
            this.lbl_ProductId.AutoSize = true;
            this.lbl_ProductId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProductId.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductId.Location = new System.Drawing.Point(442, 699);
            this.lbl_ProductId.Name = "lbl_ProductId";
            this.lbl_ProductId.Size = new System.Drawing.Size(125, 26);
            this.lbl_ProductId.TabIndex = 44;
            this.lbl_ProductId.Text = "Product Id";
            // 
            // txt_MbNo
            // 
            this.txt_MbNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MbNo.Location = new System.Drawing.Point(28, 730);
            this.txt_MbNo.Name = "txt_MbNo";
            this.txt_MbNo.Size = new System.Drawing.Size(183, 35);
            this.txt_MbNo.TabIndex = 47;
            // 
            // lbl_CusMbNo
            // 
            this.lbl_CusMbNo.AutoSize = true;
            this.lbl_CusMbNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CusMbNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CusMbNo.Location = new System.Drawing.Point(24, 699);
            this.lbl_CusMbNo.Name = "lbl_CusMbNo";
            this.lbl_CusMbNo.Size = new System.Drawing.Size(196, 26);
            this.lbl_CusMbNo.TabIndex = 46;
            this.lbl_CusMbNo.Text = "Customer Mobile";
            // 
            // btn_CusId
            // 
            this.btn_CusId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CusId.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CusId.Location = new System.Drawing.Point(44, 775);
            this.btn_CusId.Name = "btn_CusId";
            this.btn_CusId.Size = new System.Drawing.Size(167, 39);
            this.btn_CusId.TabIndex = 48;
            this.btn_CusId.Text = "fetch Id";
            this.btn_CusId.UseVisualStyleBackColor = false;
            this.btn_CusId.Click += new System.EventHandler(this.btn_CusId_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1476, 826);
            this.Controls.Add(this.btn_CusId);
            this.Controls.Add(this.txt_MbNo);
            this.Controls.Add(this.lbl_CusMbNo);
            this.Controls.Add(this.txt_ProductId);
            this.Controls.Add(this.lbl_ProductId);
            this.Controls.Add(this.add_Btn);
            this.Controls.Add(this.lbl_Mode);
            this.Controls.Add(this.txt_BillNumber);
            this.Controls.Add(this.lbl_BillId);
            this.Controls.Add(this.cmb_CashOnline);
            this.Controls.Add(this.btn_Bill);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.txt_Gst);
            this.Controls.Add(this.lbl_Gst);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.txt_CustomerID);
            this.Controls.Add(this.lbl_CustomerID);
            this.Controls.Add(this.txt_Billedby);
            this.Controls.Add(this.lbl_Billedby);
            this.Controls.Add(this.gBox_Drinks);
            this.Controls.Add(this.gBox_Chocolates);
            this.Controls.Add(this.gBox_Chips);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cmb_Quantity);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.txt_Cost);
            this.Controls.Add(this.lbl_Cost);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbox_biscuits);
            this.Controls.Add(this.picBox_Exit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbox_biscuits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBox_Chips.ResumeLayout(false);
            this.gBox_Chocolates.ResumeLayout(false);
            this.gBox_Drinks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBox_Exit;
        private System.Windows.Forms.GroupBox gbox_biscuits;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.TextBox txt_Cost;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.ComboBox cmb_Quantity;
        private System.Windows.Forms.Button btn_Biscuits;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Drinks;
        private System.Windows.Forms.Button btn_Chocolates;
        private System.Windows.Forms.Button btn_Chips;
        private System.Windows.Forms.Button btn_Hideseek;
        private System.Windows.Forms.Button btn_Fifty;
        private System.Windows.Forms.Button btn_MilkBikis;
        private System.Windows.Forms.Button btn_Goodday;
        private System.Windows.Forms.GroupBox gBox_Chips;
        private System.Windows.Forms.Button btn_Kurkure;
        private System.Windows.Forms.Button btn_Lays;
        private System.Windows.Forms.Button btn_Doritos;
        private System.Windows.Forms.Button btn_Cheetos;
        private System.Windows.Forms.GroupBox gBox_Chocolates;
        private System.Windows.Forms.Button btn_Milky;
        private System.Windows.Forms.Button btn_FiveStar;
        private System.Windows.Forms.Button btn_Kitkat;
        private System.Windows.Forms.Button btn_Dairy;
        private System.Windows.Forms.GroupBox gBox_Drinks;
        private System.Windows.Forms.Button btn_Bovonto;
        private System.Windows.Forms.Button btn_Slice;
        private System.Windows.Forms.Button btn_Fanta;
        private System.Windows.Forms.Button btn_Sevenup;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Label lbl_CustomerID;
        private System.Windows.Forms.TextBox txt_Billedby;
        private System.Windows.Forms.Label lbl_Billedby;
        private System.Windows.Forms.TextBox txt_Gst;
        private System.Windows.Forms.Label lbl_Gst;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_Bill;
        private System.Windows.Forms.ComboBox cmb_CashOnline;
        private System.Windows.Forms.TextBox txt_BillNumber;
        private System.Windows.Forms.Label lbl_BillId;
        private System.Windows.Forms.Label lbl_Mode;
        private System.Windows.Forms.Button add_Btn;
        private System.Windows.Forms.TextBox txt_ProductId;
        private System.Windows.Forms.Label lbl_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.TextBox txt_MbNo;
        private System.Windows.Forms.Label lbl_CusMbNo;
        private System.Windows.Forms.Button btn_CusId;
    }
}