namespace pms
{
    partial class FormUser
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
            this.lstUser = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtFirstName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblReenter = new System.Windows.Forms.Label();
            this.txtReenterPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnRegister = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbRole = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnModify = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstUser);
            this.groupBox1.Location = new System.Drawing.Point(-1, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(938, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lstUser
            // 
            this.lstUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colFirstName,
            this.colLastName,
            this.colUsername,
            this.colRole});
            this.lstUser.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUser.FullRowSelect = true;
            this.lstUser.GridLines = true;
            this.lstUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstUser.HideSelection = false;
            this.lstUser.Location = new System.Drawing.Point(5, 8);
            this.lstUser.MultiSelect = false;
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(914, 205);
            this.lstUser.TabIndex = 94;
            this.lstUser.UseCompatibleStateImageBehavior = false;
            this.lstUser.View = System.Windows.Forms.View.Details;
            this.lstUser.SelectedIndexChanged += new System.EventHandler(this.lstUser_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 99;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First name";
            this.colFirstName.Width = 168;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last Name";
            this.colLastName.Width = 178;
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 259;
            // 
            // colRole
            // 
            this.colRole.Text = "Role";
            this.colRole.Width = 205;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbPassword.Location = new System.Drawing.Point(38, 27);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(104, 23);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "First Name";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbUsername.Location = new System.Drawing.Point(38, 107);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(99, 23);
            this.lbUsername.TabIndex = 8;
            this.lbUsername.Text = "Username";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(291, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(324, 33);
            this.txtFirstName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFirstName.StateCommon.Border.Rounding = 10;
            this.txtFirstName.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(291, 106);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(236, 33);
            this.txtUsername.StateActive.Content.Color1 = System.Drawing.Color.MidnightBlue;
            this.txtUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.Rounding = 10;
            this.txtUsername.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(38, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(291, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(324, 33);
            this.txtLastName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLastName.StateCommon.Border.Rounding = 10;
            this.txtLastName.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.TabIndex = 10;
            // 
            // lblReenter
            // 
            this.lblReenter.AutoSize = true;
            this.lblReenter.BackColor = System.Drawing.Color.Transparent;
            this.lblReenter.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReenter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblReenter.Location = new System.Drawing.Point(38, 230);
            this.lblReenter.Name = "lblReenter";
            this.lblReenter.Size = new System.Drawing.Size(177, 23);
            this.lblReenter.TabIndex = 15;
            this.lblReenter.Text = "Re-enter Password";
            // 
            // txtReenterPassword
            // 
            this.txtReenterPassword.Location = new System.Drawing.Point(291, 227);
            this.txtReenterPassword.Name = "txtReenterPassword";
            this.txtReenterPassword.PasswordChar = '●';
            this.txtReenterPassword.Size = new System.Drawing.Size(236, 31);
            this.txtReenterPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReenterPassword.StateCommon.Border.Rounding = 10;
            this.txtReenterPassword.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReenterPassword.TabIndex = 14;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPass.Location = new System.Drawing.Point(38, 190);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(95, 23);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(291, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(236, 31);
            this.txtPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateCommon.Border.Rounding = 10;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.TabIndex = 12;
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Location = new System.Drawing.Point(715, 407);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegister.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRegister.OverrideDefault.Border.Rounding = 25;
            this.btnRegister.OverrideDefault.Border.Width = 1;
            this.btnRegister.Size = new System.Drawing.Size(159, 47);
            this.btnRegister.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRegister.StateCommon.Border.Rounding = 25;
            this.btnRegister.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRegister.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRegister.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRegister.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRegister.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnRegister.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnRegister.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegister.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnRegister.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnRegister.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegister.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRegister.StateTracking.Border.Rounding = 25;
            this.btnRegister.StateTracking.Border.Width = 1;
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Values.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbRole);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.lblReenter);
            this.groupBox2.Controls.Add(this.lbUsername);
            this.groupBox2.Controls.Add(this.txtReenterPassword);
            this.groupBox2.Controls.Add(this.lbPassword);
            this.groupBox2.Controls.Add(this.lblPass);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 325);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(660, 274);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // cmbRole
            // 
            this.cmbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.DropDownWidth = 145;
            this.cmbRole.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.cmbRole.Location = new System.Drawing.Point(291, 146);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbRole.Size = new System.Drawing.Size(108, 31);
            this.cmbRole.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.White;
            this.cmbRole.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbRole.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbRole.StateActive.ComboBox.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.cmbRole.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbRole.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbRole.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(38, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Role";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(629, 8);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "lblID";
            // 
            // btnModify
            // 
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Location = new System.Drawing.Point(714, 462);
            this.btnModify.Name = "btnModify";
            this.btnModify.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnModify.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnModify.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnModify.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnModify.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnModify.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnModify.OverrideDefault.Border.Rounding = 25;
            this.btnModify.OverrideDefault.Border.Width = 1;
            this.btnModify.Size = new System.Drawing.Size(159, 47);
            this.btnModify.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnModify.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnModify.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnModify.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnModify.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnModify.StateCommon.Border.Rounding = 25;
            this.btnModify.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnModify.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnModify.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnModify.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnModify.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnModify.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnModify.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnModify.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnModify.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnModify.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnModify.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnModify.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnModify.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnModify.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnModify.StateTracking.Border.Rounding = 25;
            this.btnModify.StateTracking.Border.Width = 1;
            this.btnModify.TabIndex = 18;
            this.btnModify.Values.Text = "Modify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeader.Location = new System.Drawing.Point(399, 32);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(347, 42);
            this.lblHeader.TabIndex = 93;
            this.lblHeader.Text = "USER INFORMATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pms.Properties.Resources.Logo_Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 91);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(736, 541);
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
            this.btnBack.Size = new System.Drawing.Size(116, 45);
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
            this.btnBack.TabIndex = 102;
            this.btnBack.Values.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 612);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFirstName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLastName;
        private System.Windows.Forms.Label lblReenter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReenterPassword;
        private System.Windows.Forms.Label lblPass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRegister;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnModify;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lstUser;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbRole;
    }
}