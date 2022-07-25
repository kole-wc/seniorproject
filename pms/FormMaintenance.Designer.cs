namespace pms
{
    partial class FormMaintenance
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
            this.btnHistory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnReset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProblem = new System.Windows.Forms.Label();
            this.txtProblem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lstMaintenance = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbService = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.btnComp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAll3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNewest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOldest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOng = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAll2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAll1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistory
            // 
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.Location = new System.Drawing.Point(707, 439);
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
            this.btnHistory.Size = new System.Drawing.Size(410, 45);
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
            this.btnHistory.TabIndex = 64;
            this.btnHistory.Values.Text = "History";
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Location = new System.Drawing.Point(391, 584);
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
            this.btnExport.Size = new System.Drawing.Size(281, 45);
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
            this.btnExport.TabIndex = 63;
            this.btnExport.Values.Text = "Export All in Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblId.Location = new System.Drawing.Point(85, 500);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 19);
            this.lblId.TabIndex = 58;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(52, 522);
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
            this.txtId.TabIndex = 57;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(707, 373);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(410, 33);
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtSearch.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 10;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TabIndex = 55;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(1001, 584);
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
            this.btnBack.TabIndex = 54;
            this.btnBack.Values.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(849, 584);
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
            this.btnReset.Size = new System.Drawing.Size(124, 45);
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
            this.btnReset.TabIndex = 53;
            this.btnReset.Values.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUpdate.Location = new System.Drawing.Point(52, 584);
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
            this.btnAddUpdate.Size = new System.Drawing.Size(141, 45);
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
            this.btnAddUpdate.TabIndex = 51;
            this.btnAddUpdate.Values.Text = "Add";
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDate.Location = new System.Drawing.Point(955, 500);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(107, 19);
            this.lblDate.TabIndex = 50;
            this.lblDate.Text = "Request Date";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblStatus.Location = new System.Drawing.Point(751, 500);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 19);
            this.lblStatus.TabIndex = 48;
            this.lblStatus.Text = "Status";
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.BackColor = System.Drawing.Color.Transparent;
            this.lblProblem.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblProblem.Location = new System.Drawing.Point(381, 500);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(71, 19);
            this.lblProblem.TabIndex = 46;
            this.lblProblem.Text = "Problem";
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(167, 522);
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(505, 33);
            this.txtProblem.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtProblem.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtProblem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProblem.StateCommon.Border.Rounding = 10;
            this.txtProblem.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProblem.TabIndex = 45;
            this.txtProblem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstMaintenance
            // 
            this.lstMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMaintenance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colService,
            this.colProblem,
            this.colStatus,
            this.colDate});
            this.lstMaintenance.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMaintenance.FullRowSelect = true;
            this.lstMaintenance.GridLines = true;
            this.lstMaintenance.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMaintenance.HideSelection = false;
            this.lstMaintenance.Location = new System.Drawing.Point(2, 104);
            this.lstMaintenance.MultiSelect = false;
            this.lstMaintenance.Name = "lstMaintenance";
            this.lstMaintenance.Size = new System.Drawing.Size(1169, 243);
            this.lstMaintenance.TabIndex = 41;
            this.lstMaintenance.UseCompatibleStateImageBehavior = false;
            this.lstMaintenance.View = System.Windows.Forms.View.Details;
            this.lstMaintenance.SelectedIndexChanged += new System.EventHandler(this.lstMaintenance_SelectedIndexChanged_1);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 87;
            // 
            // colService
            // 
            this.colService.Text = "Service";
            this.colService.Width = 257;
            // 
            // colProblem
            // 
            this.colProblem.Text = "Problem";
            this.colProblem.Width = 500;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 176;
            // 
            // colDate
            // 
            this.colDate.Text = "Request Date";
            this.colDate.Width = 147;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 104);
            this.panel1.TabIndex = 42;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeader.Location = new System.Drawing.Point(480, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(506, 42);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "MAINTENANCE INFORMATION";
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
            // cmbService
            // 
            this.cmbService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.DropDownWidth = 145;
            this.cmbService.Location = new System.Drawing.Point(52, 448);
            this.cmbService.Name = "cmbService";
            this.cmbService.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbService.Size = new System.Drawing.Size(620, 31);
            this.cmbService.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.White;
            this.cmbService.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbService.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbService.StateActive.ComboBox.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbService.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbService.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbService.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbService.TabIndex = 71;
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.CustomFormat = "yyyy-MM-dd";
            this.dateTime.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(886, 525);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(248, 27);
            this.dateTime.TabIndex = 72;
            this.dateTime.Value = new System.DateTime(2022, 2, 2, 0, 0, 0, 0);
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.DropDownWidth = 145;
            this.cmbStatus.Items.AddRange(new object[] {
            "Processing",
            "Ongoing",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(707, 522);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbStatus.Size = new System.Drawing.Size(153, 31);
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
            this.cmbStatus.TabIndex = 73;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblService.Location = new System.Drawing.Point(300, 426);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(114, 19);
            this.lblService.TabIndex = 74;
            this.lblService.Text = "Select Service";
            // 
            // btnComp
            // 
            this.btnComp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComp.Location = new System.Drawing.Point(304, 367);
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
            this.btnComp.TabIndex = 86;
            this.btnComp.Values.Text = "Completed";
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // btnAll3
            // 
            this.btnAll3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll3.Location = new System.Drawing.Point(304, 367);
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
            this.btnAll3.TabIndex = 87;
            this.btnAll3.Values.Text = "All";
            this.btnAll3.Click += new System.EventHandler(this.btnAll3_Click);
            // 
            // btnNewest
            // 
            this.btnNewest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewest.Location = new System.Drawing.Point(510, 367);
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
            this.btnNewest.TabIndex = 85;
            this.btnNewest.Values.Text = "Newest";
            this.btnNewest.Click += new System.EventHandler(this.btnNewest_Click);
            // 
            // btnOldest
            // 
            this.btnOldest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOldest.Location = new System.Drawing.Point(510, 367);
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
            this.btnOldest.TabIndex = 82;
            this.btnOldest.Values.Text = "Oldest";
            this.btnOldest.Click += new System.EventHandler(this.btnOldest_Click);
            // 
            // btnOng
            // 
            this.btnOng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOng.Location = new System.Drawing.Point(179, 367);
            this.btnOng.Name = "btnOng";
            this.btnOng.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnOng.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnOng.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOng.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOng.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOng.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOng.OverrideDefault.Border.Rounding = 25;
            this.btnOng.OverrideDefault.Border.Width = 3;
            this.btnOng.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOng.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOng.Size = new System.Drawing.Size(119, 47);
            this.btnOng.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnOng.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnOng.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOng.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOng.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOng.StateCommon.Border.Rounding = 25;
            this.btnOng.StateCommon.Border.Width = 3;
            this.btnOng.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOng.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOng.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOng.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOng.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOng.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOng.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnOng.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOng.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnOng.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnOng.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOng.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnOng.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnOng.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOng.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOng.StateTracking.Border.Rounding = 25;
            this.btnOng.StateTracking.Border.Width = 1;
            this.btnOng.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnOng.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnOng.TabIndex = 81;
            this.btnOng.Values.Text = "Ongoing";
            this.btnOng.Click += new System.EventHandler(this.btnOng_Click);
            // 
            // btnProc
            // 
            this.btnProc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProc.Location = new System.Drawing.Point(54, 367);
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
            this.btnProc.TabIndex = 80;
            this.btnProc.Values.Text = "Processing";
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // btnAll2
            // 
            this.btnAll2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll2.Location = new System.Drawing.Point(179, 367);
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
            this.btnAll2.TabIndex = 84;
            this.btnAll2.Values.Text = "All";
            this.btnAll2.Click += new System.EventHandler(this.btnAll2_Click);
            // 
            // btnAll1
            // 
            this.btnAll1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll1.Location = new System.Drawing.Point(54, 367);
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
            this.btnAll1.TabIndex = 83;
            this.btnAll1.Values.Text = "All";
            this.btnAll1.Click += new System.EventHandler(this.btnAll1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::pms.Properties.Resources.icons8_search_24;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1087, 379);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // FormMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 658);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.btnAll3);
            this.Controls.Add(this.btnOldest);
            this.Controls.Add(this.btnOng);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnAll2);
            this.Controls.Add(this.btnAll1);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblProblem);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.lstMaintenance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNewest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMaintenance";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMaintenance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHistory;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExport;
        private System.Windows.Forms.Label lblId;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtId;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReset;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddUpdate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProblem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProblem;
        private System.Windows.Forms.ListView lstMaintenance;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colService;
        private System.Windows.Forms.ColumnHeader colProblem;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbService;
        private System.Windows.Forms.DateTimePicker dateTime;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbStatus;
        private System.Windows.Forms.Label lblService;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnComp;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAll3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNewest;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOldest;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOng;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAll2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAll1;
    }
}