namespace pms
{
    partial class FormCustomer
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstCustomer = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAddUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnReset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnIndividual = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCompany = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOldest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAll1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAll2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNewest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnExportWhole = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnHistory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblSubDistrict = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtDistrict = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSubDistrict = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cmbProvince = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtPostCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtHousenumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtRoad = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblHousenumber = new System.Windows.Forms.Label();
            this.lblRoad = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblLastName2 = new System.Windows.Forms.Label();
            this.txtLastName2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblFirstName2 = new System.Windows.Forms.Label();
            this.txtFirstName2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvince)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeader.Location = new System.Drawing.Point(668, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(448, 42);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "CUSTOMER INFORMATION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1451, 104);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pms.Properties.Resources.Logo_Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(51, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 112);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lstCustomer
            // 
            this.lstCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.columnFirstName,
            this.colLastName,
            this.colCompany,
            this.colAddress,
            this.colTel,
            this.colPhone,
            this.colEmail,
            this.colType});
            this.lstCustomer.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomer.FullRowSelect = true;
            this.lstCustomer.GridLines = true;
            this.lstCustomer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstCustomer.HideSelection = false;
            this.lstCustomer.Location = new System.Drawing.Point(0, 131);
            this.lstCustomer.MultiSelect = false;
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(1450, 216);
            this.lstCustomer.TabIndex = 0;
            this.lstCustomer.UseCompatibleStateImageBehavior = false;
            this.lstCustomer.View = System.Windows.Forms.View.Details;
            this.lstCustomer.SelectedIndexChanged += new System.EventHandler(this.lstCustomer_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 87;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "First Name";
            this.columnFirstName.Width = 167;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last Name";
            this.colLastName.Width = 179;
            // 
            // colCompany
            // 
            this.colCompany.Text = "Company";
            this.colCompany.Width = 207;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.Width = 190;
            // 
            // colTel
            // 
            this.colTel.Text = "Tel";
            this.colTel.Width = 130;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone number";
            this.colPhone.Width = 130;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 215;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 114;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFirstName.Location = new System.Drawing.Point(234, 432);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 19);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(173, 454);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 33);
            this.txtFirstName.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtFirstName.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtFirstName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFirstName.StateCommon.Border.Rounding = 10;
            this.txtFirstName.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLastName.Location = new System.Drawing.Point(466, 432);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(87, 19);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(411, 454);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 33);
            this.txtLastName.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtLastName.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtLastName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLastName.StateCommon.Border.Rounding = 10;
            this.txtLastName.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.TabIndex = 8;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbType
            // 
            this.cmbType.DropDownWidth = 145;
            this.cmbType.Items.AddRange(new object[] {
            "Individual",
            "Company"});
            this.cmbType.Location = new System.Drawing.Point(50, 373);
            this.cmbType.Name = "cmbType";
            this.cmbType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbType.Size = new System.Drawing.Size(234, 34);
            this.cmbType.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.White;
            this.cmbType.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbType.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.MidnightBlue;
            this.cmbType.StateActive.ComboBox.Content.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbType.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.TabIndex = 30;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCompany.Location = new System.Drawing.Point(359, 432);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(79, 19);
            this.lblCompany.TabIndex = 12;
            this.lblCompany.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(173, 454);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(437, 33);
            this.txtCompany.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtCompany.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtCompany.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCompany.StateCommon.Border.Rounding = 10;
            this.txtCompany.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.TabIndex = 11;
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTel.Location = new System.Drawing.Point(706, 432);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(30, 19);
            this.lblTel.TabIndex = 14;
            this.lblTel.Text = "Tel";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(645, 454);
            this.txtTel.MaxLength = 10;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(157, 33);
            this.txtTel.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtTel.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtTel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTel.StateCommon.Border.Rounding = 10;
            this.txtTel.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.TabIndex = 13;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmail.Location = new System.Drawing.Point(946, 432);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(838, 454);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 33);
            this.txtEmail.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtEmail.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 10;
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUpdate.Location = new System.Drawing.Point(50, 712);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAddUpdate.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddUpdate.OverrideDefault.Border.Rounding = 25;
            this.btnAddUpdate.OverrideDefault.Border.Width = 1;
            this.btnAddUpdate.Size = new System.Drawing.Size(166, 45);
            this.btnAddUpdate.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddUpdate.StateCommon.Border.Rounding = 25;
            this.btnAddUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddUpdate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAddUpdate.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddUpdate.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnAddUpdate.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnAddUpdate.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAddUpdate.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnAddUpdate.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnAddUpdate.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAddUpdate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddUpdate.StateTracking.Border.Rounding = 25;
            this.btnAddUpdate.StateTracking.Border.Width = 1;
            this.btnAddUpdate.TabIndex = 17;
            this.btnAddUpdate.Values.Text = "Add";
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(1024, 712);
            this.btnReset.Name = "btnReset";
            this.btnReset.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnReset.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnReset.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnReset.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnReset.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnReset.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReset.OverrideDefault.Border.Rounding = 25;
            this.btnReset.OverrideDefault.Border.Width = 1;
            this.btnReset.Size = new System.Drawing.Size(159, 45);
            this.btnReset.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnReset.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnReset.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnReset.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnReset.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReset.StateCommon.Border.Rounding = 25;
            this.btnReset.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnReset.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnReset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnReset.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnReset.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnReset.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnReset.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReset.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnReset.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnReset.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnReset.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnReset.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnReset.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnReset.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReset.StateTracking.Border.Rounding = 25;
            this.btnReset.StateTracking.Border.Width = 1;
            this.btnReset.TabIndex = 20;
            this.btnReset.Values.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(1213, 712);
            this.btnBack.Name = "btnBack";
            this.btnBack.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkBlue;
            this.btnBack.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.btnBack.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnBack.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkBlue;
            this.btnBack.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.btnBack.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.OverrideDefault.Border.Rounding = 25;
            this.btnBack.OverrideDefault.Border.Width = 1;
            this.btnBack.Size = new System.Drawing.Size(159, 45);
            this.btnBack.StateCommon.Back.Color1 = System.Drawing.Color.DarkBlue;
            this.btnBack.StateCommon.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.btnBack.StateCommon.Border.Color1 = System.Drawing.Color.DarkBlue;
            this.btnBack.StateCommon.Border.Color2 = System.Drawing.Color.DarkBlue;
            this.btnBack.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateCommon.Border.Rounding = 25;
            this.btnBack.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnBack.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnBack.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnBack.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnBack.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnBack.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnBack.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnBack.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnBack.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnBack.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnBack.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateTracking.Border.Rounding = 25;
            this.btnBack.StateTracking.Border.Width = 1;
            this.btnBack.TabIndex = 21;
            this.btnBack.Values.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(838, 373);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(534, 33);
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtSearch.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 10;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(50, 454);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(89, 33);
            this.txtId.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtId.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtId.StateCommon.Border.Rounding = 10;
            this.txtId.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.TabIndex = 24;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblId.Location = new System.Drawing.Point(83, 432);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 19);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "ID";
            // 
            // btnIndividual
            // 
            this.btnIndividual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndividual.Location = new System.Drawing.Point(332, 366);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnIndividual.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnIndividual.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnIndividual.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnIndividual.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnIndividual.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIndividual.OverrideDefault.Border.Rounding = 25;
            this.btnIndividual.OverrideDefault.Border.Width = 3;
            this.btnIndividual.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnIndividual.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnIndividual.Size = new System.Drawing.Size(128, 47);
            this.btnIndividual.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnIndividual.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnIndividual.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnIndividual.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnIndividual.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIndividual.StateCommon.Border.Rounding = 25;
            this.btnIndividual.StateCommon.Border.Width = 3;
            this.btnIndividual.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnIndividual.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnIndividual.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndividual.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnIndividual.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnIndividual.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnIndividual.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnIndividual.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIndividual.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnIndividual.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnIndividual.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnIndividual.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnIndividual.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnIndividual.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnIndividual.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIndividual.StateTracking.Border.Rounding = 25;
            this.btnIndividual.StateTracking.Border.Width = 1;
            this.btnIndividual.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnIndividual.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnIndividual.TabIndex = 31;
            this.btnIndividual.Values.Text = "Individual";
            this.btnIndividual.Click += new System.EventHandler(this.btnIndividual_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompany.Location = new System.Drawing.Point(470, 366);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCompany.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCompany.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCompany.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCompany.OverrideDefault.Border.Rounding = 25;
            this.btnCompany.OverrideDefault.Border.Width = 3;
            this.btnCompany.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.Size = new System.Drawing.Size(123, 47);
            this.btnCompany.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCompany.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCompany.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCompany.StateCommon.Border.Rounding = 25;
            this.btnCompany.StateCommon.Border.Width = 3;
            this.btnCompany.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCompany.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCompany.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnCompany.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnCompany.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCompany.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnCompany.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnCompany.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCompany.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCompany.StateTracking.Border.Rounding = 25;
            this.btnCompany.StateTracking.Border.Width = 1;
            this.btnCompany.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCompany.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCompany.TabIndex = 33;
            this.btnCompany.Values.Text = "Company";
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnOldest
            // 
            this.btnOldest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOldest.Location = new System.Drawing.Point(687, 366);
            this.btnOldest.Name = "btnOldest";
            this.btnOldest.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnOldest.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnOldest.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOldest.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOldest.OverrideDefault.Border.Rounding = 25;
            this.btnOldest.OverrideDefault.Border.Width = 3;
            this.btnOldest.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.Size = new System.Drawing.Size(115, 47);
            this.btnOldest.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnOldest.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnOldest.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOldest.StateCommon.Border.Rounding = 25;
            this.btnOldest.StateCommon.Border.Width = 3;
            this.btnOldest.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOldest.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOldest.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOldest.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnOldest.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnOldest.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOldest.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnOldest.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnOldest.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOldest.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOldest.StateTracking.Border.Rounding = 25;
            this.btnOldest.StateTracking.Border.Width = 1;
            this.btnOldest.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnOldest.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnOldest.TabIndex = 35;
            this.btnOldest.Values.Text = "Oldest";
            this.btnOldest.Click += new System.EventHandler(this.btnOldest_Click);
            // 
            // btnAll1
            // 
            this.btnAll1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll1.Location = new System.Drawing.Point(332, 366);
            this.btnAll1.Name = "btnAll1";
            this.btnAll1.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAll1.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAll1.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll1.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll1.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll1.OverrideDefault.Border.Rounding = 25;
            this.btnAll1.OverrideDefault.Border.Width = 3;
            this.btnAll1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll1.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll1.Size = new System.Drawing.Size(128, 47);
            this.btnAll1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAll1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAll1.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll1.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll1.StateCommon.Border.Rounding = 25;
            this.btnAll1.StateCommon.Border.Width = 3;
            this.btnAll1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAll1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll1.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll1.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll1.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll1.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll1.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnAll1.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnAll1.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll1.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnAll1.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnAll1.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll1.StateTracking.Border.Rounding = 25;
            this.btnAll1.StateTracking.Border.Width = 1;
            this.btnAll1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAll1.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAll1.TabIndex = 36;
            this.btnAll1.Values.Text = "All";
            this.btnAll1.Click += new System.EventHandler(this.btnAll1_Click);
            // 
            // btnAll2
            // 
            this.btnAll2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll2.Location = new System.Drawing.Point(470, 366);
            this.btnAll2.Name = "btnAll2";
            this.btnAll2.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAll2.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAll2.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll2.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll2.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll2.OverrideDefault.Border.Rounding = 25;
            this.btnAll2.OverrideDefault.Border.Width = 3;
            this.btnAll2.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll2.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll2.Size = new System.Drawing.Size(123, 47);
            this.btnAll2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAll2.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAll2.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll2.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll2.StateCommon.Border.Rounding = 25;
            this.btnAll2.StateCommon.Border.Width = 3;
            this.btnAll2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAll2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll2.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll2.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll2.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll2.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll2.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnAll2.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnAll2.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll2.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnAll2.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnAll2.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll2.StateTracking.Border.Rounding = 25;
            this.btnAll2.StateTracking.Border.Width = 1;
            this.btnAll2.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAll2.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAll2.TabIndex = 37;
            this.btnAll2.Values.Text = "All";
            this.btnAll2.Click += new System.EventHandler(this.btnAll2_Click);
            // 
            // btnNewest
            // 
            this.btnNewest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewest.Location = new System.Drawing.Point(687, 366);
            this.btnNewest.Name = "btnNewest";
            this.btnNewest.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNewest.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNewest.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnNewest.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNewest.OverrideDefault.Border.Rounding = 25;
            this.btnNewest.OverrideDefault.Border.Width = 3;
            this.btnNewest.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.Size = new System.Drawing.Size(115, 47);
            this.btnNewest.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNewest.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNewest.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNewest.StateCommon.Border.Rounding = 25;
            this.btnNewest.StateCommon.Border.Width = 3;
            this.btnNewest.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewest.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnNewest.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNewest.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnNewest.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnNewest.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnNewest.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnNewest.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnNewest.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnNewest.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNewest.StateTracking.Border.Rounding = 25;
            this.btnNewest.StateTracking.Border.Width = 1;
            this.btnNewest.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNewest.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNewest.TabIndex = 38;
            this.btnNewest.Values.Text = "Newest";
            this.btnNewest.Click += new System.EventHandler(this.btnNewest_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::pms.Properties.Resources.icons8_search_24;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1338, 378);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // btnExportWhole
            // 
            this.btnExportWhole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportWhole.Location = new System.Drawing.Point(497, 712);
            this.btnExportWhole.Name = "btnExportWhole";
            this.btnExportWhole.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnExportWhole.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExportWhole.OverrideDefault.Border.Rounding = 25;
            this.btnExportWhole.OverrideDefault.Border.Width = 1;
            this.btnExportWhole.Size = new System.Drawing.Size(263, 45);
            this.btnExportWhole.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExportWhole.StateCommon.Border.Rounding = 25;
            this.btnExportWhole.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExportWhole.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnExportWhole.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportWhole.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExportWhole.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExportWhole.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnExportWhole.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnExportWhole.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnExportWhole.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnExportWhole.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnExportWhole.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnExportWhole.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExportWhole.StateTracking.Border.Rounding = 25;
            this.btnExportWhole.StateTracking.Border.Width = 1;
            this.btnExportWhole.TabIndex = 39;
            this.btnExportWhole.Values.Text = "Export All in Excel";
            this.btnExportWhole.Click += new System.EventHandler(this.btnExportWhole_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.Location = new System.Drawing.Point(1165, 492);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnHistory.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHistory.OverrideDefault.Border.Rounding = 25;
            this.btnHistory.OverrideDefault.Border.Width = 1;
            this.btnHistory.Size = new System.Drawing.Size(207, 131);
            this.btnHistory.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHistory.StateCommon.Border.Rounding = 25;
            this.btnHistory.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHistory.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHistory.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnHistory.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHistory.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnHistory.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnHistory.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnHistory.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnHistory.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnHistory.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnHistory.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHistory.StateTracking.Border.Rounding = 25;
            this.btnHistory.StateTracking.Border.Width = 1;
            this.btnHistory.TabIndex = 40;
            this.btnHistory.Values.Text = "History";
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lblSubDistrict
            // 
            this.lblSubDistrict.AutoSize = true;
            this.lblSubDistrict.BackColor = System.Drawing.Color.Transparent;
            this.lblSubDistrict.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDistrict.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSubDistrict.Location = new System.Drawing.Point(597, 604);
            this.lblSubDistrict.Name = "lblSubDistrict";
            this.lblSubDistrict.Size = new System.Drawing.Size(99, 19);
            this.lblSubDistrict.TabIndex = 79;
            this.lblSubDistrict.Text = "Sub-District";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAddress.Location = new System.Drawing.Point(535, 559);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(104, 29);
            this.lblAddress.TabIndex = 78;
            this.lblAddress.Text = "Address";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblProvince);
            this.panel2.Controls.Add(this.txtDistrict);
            this.panel2.Controls.Add(this.txtSubDistrict);
            this.panel2.Controls.Add(this.lblDistrict);
            this.panel2.Controls.Add(this.cmbProvince);
            this.panel2.Controls.Add(this.txtPostCode);
            this.panel2.Controls.Add(this.txtHousenumber);
            this.panel2.Controls.Add(this.txtRoad);
            this.panel2.Controls.Add(this.lblHousenumber);
            this.panel2.Controls.Add(this.lblRoad);
            this.panel2.Controls.Add(this.lblPostalCode);
            this.panel2.Location = new System.Drawing.Point(42, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 117);
            this.panel2.TabIndex = 80;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.BackColor = System.Drawing.Color.Transparent;
            this.lblProvince.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblProvince.Location = new System.Drawing.Point(757, 31);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(73, 19);
            this.lblProvince.TabIndex = 69;
            this.lblProvince.Text = "Province";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(361, 53);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(143, 33);
            this.txtDistrict.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtDistrict.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtDistrict.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDistrict.StateCommon.Border.Rounding = 10;
            this.txtDistrict.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrict.TabIndex = 73;
            this.txtDistrict.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubDistrict
            // 
            this.txtSubDistrict.Location = new System.Drawing.Point(534, 53);
            this.txtSubDistrict.Name = "txtSubDistrict";
            this.txtSubDistrict.Size = new System.Drawing.Size(143, 33);
            this.txtSubDistrict.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtSubDistrict.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtSubDistrict.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSubDistrict.StateCommon.Border.Rounding = 10;
            this.txtSubDistrict.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubDistrict.TabIndex = 74;
            this.txtSubDistrict.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.BackColor = System.Drawing.Color.Transparent;
            this.lblDistrict.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDistrict.Location = new System.Drawing.Point(402, 31);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(63, 19);
            this.lblDistrict.TabIndex = 67;
            this.lblDistrict.Text = "District";
            // 
            // cmbProvince
            // 
            this.cmbProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvince.DropDownWidth = 145;
            this.cmbProvince.Items.AddRange(new object[] {
            "Bangkok",
            "Samut Prakan",
            "Pathum Thani",
            "Samut Sakhon",
            "Nakhon Pathom",
            "Nonthaburi",
            "Saraburi",
            "Sing Buri",
            "Chainat",
            "Ang Thong",
            "Lopburi",
            "Phra Nakhon Si Ayutthaya",
            "Chonburi",
            "Chachoengsao",
            "Rayong",
            "Trat",
            "Chanthaburi",
            "Nakhon Nayok",
            "Prachinburi",
            "Sa Kaeo",
            "Khon Kaen",
            "Udon Thani",
            "Loei",
            "Nong Khai",
            "Mukdahan",
            "Nakhon Phanom",
            "Sakon Nakhon",
            "Kalasin",
            "Nakhon Ratchasima",
            "Chaiyaphum",
            "Yasothon",
            "Ubon Ratchathani",
            "Roi Et",
            "Buriram",
            "Surin",
            "Maha Sarakham",
            "Sisaket",
            "Nong Bua Lamphu",
            "Amnat Charoen",
            "Bueng Kan",
            "Chiang Mai",
            "Lampang",
            "Uttaradit",
            "Mae Hong Son",
            "Chiang Rai",
            "Phrae",
            "Lamphun",
            "Nan",
            "Phayao",
            "Nakhon Sawan",
            "Phitsanulok",
            "Kamphaeng Phet",
            "Uthai Thani",
            "Sukhothai",
            "Tak",
            "Phichit",
            "Phetchabun",
            "Phuket",
            "Surat Thani",
            "Ranong",
            "Phang Nga",
            "Krabi",
            "Chumphon",
            "Nakhon Si Thammarat",
            "Songkhla",
            "Satun",
            "Yala",
            "Trang",
            "Narathiwat",
            "Phattalung",
            "Pattani",
            "Ratchaburi",
            "Kanchanaburi",
            "Prachuap Khiri Khan",
            "Phetchaburi",
            "Suphan Buri",
            "Samut Songkhram"});
            this.cmbProvince.Location = new System.Drawing.Point(709, 53);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbProvince.Size = new System.Drawing.Size(172, 31);
            this.cmbProvince.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.White;
            this.cmbProvince.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbProvince.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbProvince.StateActive.ComboBox.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvince.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbProvince.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbProvince.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvince.TabIndex = 75;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(914, 51);
            this.txtPostCode.MaxLength = 5;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(114, 33);
            this.txtPostCode.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtPostCode.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtPostCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPostCode.StateCommon.Border.Rounding = 10;
            this.txtPostCode.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostCode.TabIndex = 76;
            this.txtPostCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHousenumber
            // 
            this.txtHousenumber.Location = new System.Drawing.Point(36, 53);
            this.txtHousenumber.Name = "txtHousenumber";
            this.txtHousenumber.Size = new System.Drawing.Size(114, 33);
            this.txtHousenumber.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtHousenumber.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtHousenumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtHousenumber.StateCommon.Border.Rounding = 10;
            this.txtHousenumber.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHousenumber.TabIndex = 71;
            this.txtHousenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRoad
            // 
            this.txtRoad.Location = new System.Drawing.Point(183, 53);
            this.txtRoad.Name = "txtRoad";
            this.txtRoad.Size = new System.Drawing.Size(143, 33);
            this.txtRoad.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtRoad.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtRoad.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRoad.StateCommon.Border.Rounding = 10;
            this.txtRoad.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoad.TabIndex = 72;
            this.txtRoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHousenumber
            // 
            this.lblHousenumber.AutoSize = true;
            this.lblHousenumber.BackColor = System.Drawing.Color.Transparent;
            this.lblHousenumber.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHousenumber.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHousenumber.Location = new System.Drawing.Point(37, 31);
            this.lblHousenumber.Name = "lblHousenumber";
            this.lblHousenumber.Size = new System.Drawing.Size(113, 19);
            this.lblHousenumber.TabIndex = 65;
            this.lblHousenumber.Text = "Housenumber";
            // 
            // lblRoad
            // 
            this.lblRoad.AutoSize = true;
            this.lblRoad.BackColor = System.Drawing.Color.Transparent;
            this.lblRoad.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRoad.Location = new System.Drawing.Point(207, 31);
            this.lblRoad.Name = "lblRoad";
            this.lblRoad.Size = new System.Drawing.Size(87, 19);
            this.lblRoad.TabIndex = 66;
            this.lblRoad.Text = "Road && Soi";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.BackColor = System.Drawing.Color.Transparent;
            this.lblPostalCode.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPostalCode.Location = new System.Drawing.Point(922, 31);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(97, 19);
            this.lblPostalCode.TabIndex = 70;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLastName2.Location = new System.Drawing.Point(466, 492);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(87, 19);
            this.lblLastName2.TabIndex = 84;
            this.lblLastName2.Text = "Last Name";
            // 
            // txtLastName2
            // 
            this.txtLastName2.Location = new System.Drawing.Point(411, 514);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(199, 33);
            this.txtLastName2.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtLastName2.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtLastName2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLastName2.StateCommon.Border.Rounding = 10;
            this.txtLastName2.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName2.TabIndex = 83;
            this.txtLastName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFirstName2
            // 
            this.lblFirstName2.AutoSize = true;
            this.lblFirstName2.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFirstName2.Location = new System.Drawing.Point(234, 492);
            this.lblFirstName2.Name = "lblFirstName2";
            this.lblFirstName2.Size = new System.Drawing.Size(88, 19);
            this.lblFirstName2.TabIndex = 82;
            this.lblFirstName2.Text = "First Name";
            // 
            // txtFirstName2
            // 
            this.txtFirstName2.Location = new System.Drawing.Point(173, 514);
            this.txtFirstName2.Name = "txtFirstName2";
            this.txtFirstName2.Size = new System.Drawing.Size(199, 33);
            this.txtFirstName2.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtFirstName2.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtFirstName2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFirstName2.StateCommon.Border.Rounding = 10;
            this.txtFirstName2.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName2.TabIndex = 81;
            this.txtFirstName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.Transparent;
            this.lblContact.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblContact.Location = new System.Drawing.Point(39, 522);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(122, 19);
            this.lblContact.TabIndex = 85;
            this.lblContact.Text = "Contact Person";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(1, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1029, 19);
            this.label4.TabIndex = 86;
            this.label4.Text = "*If customer is a company, First Name and Last Name are the name of contact perso" +
    "n and Phone number is the contact person phone number.";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(645, 514);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 33);
            this.txtPhone.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtPhone.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtPhone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhone.StateCommon.Border.Rounding = 10;
            this.txtPhone.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.TabIndex = 87;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPhone.Location = new System.Drawing.Point(670, 492);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(112, 19);
            this.lblPhone.TabIndex = 88;
            this.lblPhone.Text = "Phonenumber";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1421, 782);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblLastName2);
            this.Controls.Add(this.txtLastName2);
            this.Controls.Add(this.lblFirstName2);
            this.Controls.Add(this.txtFirstName2);
            this.Controls.Add(this.lblSubDistrict);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnExportWhole);
            this.Controls.Add(this.btnOldest);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnIndividual);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAll2);
            this.Controls.Add(this.btnAll1);
            this.Controls.Add(this.btnNewest);
            this.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormCustomer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvince)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstCustomer;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colCompany;
        private System.Windows.Forms.ColumnHeader colTel;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.Label lblFirstName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLastName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbType;
        private System.Windows.Forms.Label lblCompany;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCompany;
        private System.Windows.Forms.Label lblTel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTel;
        private System.Windows.Forms.Label lblEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReset;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtId;
        private System.Windows.Forms.Label lblId;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnIndividual;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCompany;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOldest;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAll1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAll2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNewest;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExportWhole;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHistory;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.Label lblSubDistrict;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProvince;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDistrict;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSubDistrict;
        private System.Windows.Forms.Label lblDistrict;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbProvince;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPostCode;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtHousenumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRoad;
        private System.Windows.Forms.Label lblHousenumber;
        private System.Windows.Forms.Label lblRoad;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblLastName2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLastName2;
        private System.Windows.Forms.Label lblFirstName2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFirstName2;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader colPhone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
    }
}