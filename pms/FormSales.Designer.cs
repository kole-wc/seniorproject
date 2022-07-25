namespace pms
{
    partial class FormSales
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
            this.btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnReset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSales = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOrderDetails = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbCustomer = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnNewest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOldest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeli = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAll2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAll1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnComp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAll3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancelled = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAll4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Location = new System.Drawing.Point(379, 638);
            this.btnExport.Name = "btnExport";
            this.btnExport.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExport.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExport.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnExport.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExport.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExport.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExport.OverrideDefault.Border.Rounding = 25;
            this.btnExport.OverrideDefault.Border.Width = 1;
            this.btnExport.Size = new System.Drawing.Size(260, 45);
            this.btnExport.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExport.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExport.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExport.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExport.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExport.StateCommon.Border.Rounding = 25;
            this.btnExport.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExport.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnExport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExport.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExport.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnExport.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnExport.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExport.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnExport.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnExport.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnExport.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnExport.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnExport.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnExport.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExport.StateTracking.Border.Rounding = 25;
            this.btnExport.StateTracking.Border.Width = 1;
            this.btnExport.TabIndex = 60;
            this.btnExport.Values.Text = "Export All in Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblId.Location = new System.Drawing.Point(190, 498);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 19);
            this.lblId.TabIndex = 55;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(157, 520);
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
            this.txtId.TabIndex = 54;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(799, 391);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(317, 33);
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtSearch.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 10;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TabIndex = 53;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(1001, 638);
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
            this.btnBack.TabIndex = 52;
            this.btnBack.Values.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(864, 638);
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
            this.btnReset.Size = new System.Drawing.Size(118, 45);
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
            this.btnReset.TabIndex = 51;
            this.btnReset.Values.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUpdate.Location = new System.Drawing.Point(52, 638);
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
            this.btnAddUpdate.Size = new System.Drawing.Size(125, 45);
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
            this.btnAddUpdate.TabIndex = 49;
            this.btnAddUpdate.Values.Text = "Add";
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAmount.Location = new System.Drawing.Point(860, 498);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(67, 19);
            this.lblAmount.TabIndex = 48;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(809, 520);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(173, 33);
            this.txtAmount.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtAmount.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtAmount.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAmount.StateCommon.Border.Rounding = 10;
            this.txtAmount.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.TabIndex = 47;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblStatus.Location = new System.Drawing.Point(663, 498);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 19);
            this.lblStatus.TabIndex = 46;
            this.lblStatus.Text = "Status";
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.BackColor = System.Drawing.Color.Transparent;
            this.lblCust.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCust.Location = new System.Drawing.Point(383, 498);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(81, 19);
            this.lblCust.TabIndex = 43;
            this.lblCust.Text = "Customer";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeader.Location = new System.Drawing.Point(541, 39);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(364, 42);
            this.lblHeader.TabIndex = 42;
            this.lblHeader.Text = "SALES INFORMATION";
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 200;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 100;
            // 
            // lstSales
            // 
            this.lstSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colCustomer,
            this.colStatus,
            this.colAmount,
            this.colDate});
            this.lstSales.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSales.FullRowSelect = true;
            this.lstSales.GridLines = true;
            this.lstSales.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstSales.HideSelection = false;
            this.lstSales.Location = new System.Drawing.Point(0, 122);
            this.lstSales.MultiSelect = false;
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(1169, 243);
            this.lstSales.TabIndex = 61;
            this.lstSales.UseCompatibleStateImageBehavior = false;
            this.lstSales.View = System.Windows.Forms.View.Details;
            this.lstSales.SelectedIndexChanged += new System.EventHandler(this.lstSales_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 145;
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Customer";
            this.colCustomer.Width = 425;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 182;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Amount";
            this.colAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colAmount.Width = 220;
            // 
            // colDate
            // 
            this.colDate.Text = "Order Date";
            this.colDate.Width = 197;
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderDetails.Location = new System.Drawing.Point(157, 571);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOrderDetails.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOrderDetails.OverrideDefault.Border.Rounding = 25;
            this.btnOrderDetails.OverrideDefault.Border.Width = 1;
            this.btnOrderDetails.Size = new System.Drawing.Size(825, 42);
            this.btnOrderDetails.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOrderDetails.StateCommon.Border.Rounding = 25;
            this.btnOrderDetails.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnOrderDetails.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnOrderDetails.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDetails.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOrderDetails.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOrderDetails.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnOrderDetails.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnOrderDetails.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOrderDetails.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnOrderDetails.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnOrderDetails.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOrderDetails.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOrderDetails.StateTracking.Border.Rounding = 25;
            this.btnOrderDetails.StateTracking.Border.Width = 1;
            this.btnOrderDetails.TabIndex = 67;
            this.btnOrderDetails.Values.Text = "Order Details";
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.CustomFormat = "yyyy-MM-dd";
            this.dateTime.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(437, 455);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(272, 27);
            this.dateTime.TabIndex = 69;
            this.dateTime.Value = new System.DateTime(2022, 2, 2, 0, 0, 0, 0);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.DropDownWidth = 145;
            this.cmbCustomer.Location = new System.Drawing.Point(279, 520);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbCustomer.Size = new System.Drawing.Size(292, 31);
            this.cmbCustomer.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.White;
            this.cmbCustomer.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbCustomer.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbCustomer.StateActive.ComboBox.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbCustomer.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbCustomer.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.TabIndex = 70;
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.DropDownWidth = 145;
            this.cmbStatus.Items.AddRange(new object[] {
            "Processing",
            "Delivering",
            "Completed",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(614, 520);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbStatus.Size = new System.Drawing.Size(157, 31);
            this.cmbStatus.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.White;
            this.cmbStatus.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbStatus.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbStatus.StateActive.ComboBox.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbStatus.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbStatus.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.TabIndex = 71;
            this.cmbStatus.Text = "Processing";
            // 
            // btnNewest
            // 
            this.btnNewest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewest.Location = new System.Drawing.Point(667, 388);
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
            this.btnNewest.TabIndex = 77;
            this.btnNewest.Values.Text = "Newest";
            this.btnNewest.Click += new System.EventHandler(this.btnNewest_Click);
            // 
            // btnOldest
            // 
            this.btnOldest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOldest.Location = new System.Drawing.Point(667, 388);
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
            this.btnOldest.TabIndex = 74;
            this.btnOldest.Values.Text = "Oldest";
            this.btnOldest.Click += new System.EventHandler(this.btnOldest_Click);
            // 
            // btnDeli
            // 
            this.btnDeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeli.Location = new System.Drawing.Point(177, 388);
            this.btnDeli.Name = "btnDeli";
            this.btnDeli.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnDeli.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnDeli.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDeli.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeli.OverrideDefault.Border.Rounding = 25;
            this.btnDeli.OverrideDefault.Border.Width = 3;
            this.btnDeli.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.Size = new System.Drawing.Size(119, 47);
            this.btnDeli.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnDeli.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnDeli.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeli.StateCommon.Border.Rounding = 25;
            this.btnDeli.StateCommon.Border.Width = 3;
            this.btnDeli.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeli.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnDeli.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeli.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnDeli.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnDeli.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDeli.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnDeli.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnDeli.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDeli.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeli.StateTracking.Border.Rounding = 25;
            this.btnDeli.StateTracking.Border.Width = 1;
            this.btnDeli.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDeli.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDeli.TabIndex = 73;
            this.btnDeli.Values.Text = "Delivering";
            this.btnDeli.Click += new System.EventHandler(this.btnDeli_Click);
            // 
            // btnProc
            // 
            this.btnProc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProc.Location = new System.Drawing.Point(52, 388);
            this.btnProc.Name = "btnProc";
            this.btnProc.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnProc.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnProc.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnProc.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnProc.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnProc.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProc.OverrideDefault.Border.Rounding = 25;
            this.btnProc.OverrideDefault.Border.Width = 3;
            this.btnProc.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnProc.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnProc.Size = new System.Drawing.Size(119, 47);
            this.btnProc.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnProc.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnProc.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnProc.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnProc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProc.StateCommon.Border.Rounding = 25;
            this.btnProc.StateCommon.Border.Width = 3;
            this.btnProc.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnProc.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProc.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProc.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnProc.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnProc.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnProc.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnProc.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProc.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnProc.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnProc.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnProc.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnProc.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnProc.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnProc.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProc.StateTracking.Border.Rounding = 25;
            this.btnProc.StateTracking.Border.Width = 1;
            this.btnProc.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProc.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProc.TabIndex = 72;
            this.btnProc.Values.Text = "Processing";
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // btnAll2
            // 
            this.btnAll2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll2.Location = new System.Drawing.Point(177, 388);
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
            this.btnAll2.Size = new System.Drawing.Size(119, 47);
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
            this.btnAll2.TabIndex = 76;
            this.btnAll2.Values.Text = "All";
            this.btnAll2.Click += new System.EventHandler(this.btnAll2_Click);
            // 
            // btnAll1
            // 
            this.btnAll1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll1.Location = new System.Drawing.Point(52, 388);
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
            this.btnAll1.Size = new System.Drawing.Size(119, 47);
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
            this.btnAll1.TabIndex = 75;
            this.btnAll1.Values.Text = "All";
            this.btnAll1.Click += new System.EventHandler(this.btnAll1_Click);
            // 
            // btnComp
            // 
            this.btnComp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComp.Location = new System.Drawing.Point(302, 388);
            this.btnComp.Name = "btnComp";
            this.btnComp.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnComp.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnComp.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnComp.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnComp.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnComp.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnComp.OverrideDefault.Border.Rounding = 25;
            this.btnComp.OverrideDefault.Border.Width = 3;
            this.btnComp.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnComp.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnComp.Size = new System.Drawing.Size(119, 47);
            this.btnComp.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnComp.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnComp.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnComp.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnComp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnComp.StateCommon.Border.Rounding = 25;
            this.btnComp.StateCommon.Border.Width = 3;
            this.btnComp.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnComp.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnComp.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComp.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnComp.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnComp.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnComp.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnComp.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnComp.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnComp.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnComp.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnComp.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnComp.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnComp.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnComp.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnComp.StateTracking.Border.Rounding = 25;
            this.btnComp.StateTracking.Border.Width = 1;
            this.btnComp.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnComp.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnComp.TabIndex = 78;
            this.btnComp.Values.Text = "Completed";
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // btnAll3
            // 
            this.btnAll3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll3.Location = new System.Drawing.Point(302, 388);
            this.btnAll3.Name = "btnAll3";
            this.btnAll3.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAll3.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAll3.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll3.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll3.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll3.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll3.OverrideDefault.Border.Rounding = 25;
            this.btnAll3.OverrideDefault.Border.Width = 3;
            this.btnAll3.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll3.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll3.Size = new System.Drawing.Size(119, 47);
            this.btnAll3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAll3.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAll3.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll3.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll3.StateCommon.Border.Rounding = 25;
            this.btnAll3.StateCommon.Border.Width = 3;
            this.btnAll3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll3.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAll3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll3.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll3.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll3.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll3.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll3.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll3.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnAll3.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnAll3.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll3.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnAll3.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnAll3.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll3.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll3.StateTracking.Border.Rounding = 25;
            this.btnAll3.StateTracking.Border.Width = 1;
            this.btnAll3.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAll3.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAll3.TabIndex = 79;
            this.btnAll3.Values.Text = "All";
            this.btnAll3.Click += new System.EventHandler(this.btnAll3_Click);
            // 
            // btnCancelled
            // 
            this.btnCancelled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelled.Location = new System.Drawing.Point(427, 388);
            this.btnCancelled.Name = "btnCancelled";
            this.btnCancelled.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCancelled.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCancelled.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCancelled.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelled.OverrideDefault.Border.Rounding = 25;
            this.btnCancelled.OverrideDefault.Border.Width = 3;
            this.btnCancelled.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.Size = new System.Drawing.Size(119, 47);
            this.btnCancelled.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCancelled.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCancelled.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelled.StateCommon.Border.Rounding = 25;
            this.btnCancelled.StateCommon.Border.Width = 3;
            this.btnCancelled.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelled.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCancelled.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelled.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnCancelled.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnCancelled.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCancelled.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnCancelled.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnCancelled.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCancelled.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelled.StateTracking.Border.Rounding = 25;
            this.btnCancelled.StateTracking.Border.Width = 1;
            this.btnCancelled.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancelled.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancelled.TabIndex = 80;
            this.btnCancelled.Values.Text = "Cancelled";
            this.btnCancelled.Click += new System.EventHandler(this.btnCancelled_Click);
            // 
            // btnAll4
            // 
            this.btnAll4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll4.Location = new System.Drawing.Point(427, 388);
            this.btnAll4.Name = "btnAll4";
            this.btnAll4.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAll4.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAll4.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll4.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll4.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll4.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll4.OverrideDefault.Border.Rounding = 25;
            this.btnAll4.OverrideDefault.Border.Width = 3;
            this.btnAll4.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll4.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll4.Size = new System.Drawing.Size(119, 47);
            this.btnAll4.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAll4.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAll4.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll4.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll4.StateCommon.Border.Rounding = 25;
            this.btnAll4.StateCommon.Border.Width = 3;
            this.btnAll4.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll4.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAll4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll4.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll4.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll4.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAll4.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAll4.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll4.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnAll4.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnAll4.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll4.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnAll4.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnAll4.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAll4.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAll4.StateTracking.Border.Rounding = 25;
            this.btnAll4.StateTracking.Border.Width = 1;
            this.btnAll4.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAll4.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAll4.TabIndex = 81;
            this.btnAll4.Values.Text = "All";
            this.btnAll4.Click += new System.EventHandler(this.btnAll4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::pms.Properties.Resources.icons8_search_24;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1088, 397);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 68;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pms.Properties.Resources.Logo_Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 112);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 699);
            this.Controls.Add(this.btnCancelled);
            this.Controls.Add(this.btnAll4);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.btnAll3);
            this.Controls.Add(this.btnOldest);
            this.Controls.Add(this.btnDeli);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnAll2);
            this.Controls.Add(this.btnAll1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.lstSales);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewest);
            this.MaximizeBox = false;
            this.Name = "FormSales";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExport;
        private System.Windows.Forms.Label lblId;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtId;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReset;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddUpdate;
        private System.Windows.Forms.Label lblAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lstSales;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOrderDetails;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DateTimePicker dateTime;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNewest;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOldest;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeli;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAll2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAll1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnComp;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAll3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelled;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAll4;
    }
}