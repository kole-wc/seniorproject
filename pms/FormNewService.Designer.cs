
namespace pms
{
    partial class FormNewService
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
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lstProduct = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnConfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListView();
            this.colProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrderQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtServiceId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtQty = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.txtFees = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(487, 145);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 33);
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtSearch.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 10;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TabIndex = 79;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblProducts.Location = new System.Drawing.Point(302, 140);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(144, 42);
            this.lblProducts.TabIndex = 76;
            this.lblProducts.Text = "Product";
            // 
            // lstProduct
            // 
            this.lstProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colName,
            this.colPrice,
            this.colProdType});
            this.lstProduct.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProduct.FullRowSelect = true;
            this.lstProduct.GridLines = true;
            this.lstProduct.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstProduct.HideSelection = false;
            this.lstProduct.Location = new System.Drawing.Point(0, 188);
            this.lstProduct.MultiSelect = false;
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(766, 421);
            this.lstProduct.TabIndex = 75;
            this.lstProduct.UseCompatibleStateImageBehavior = false;
            this.lstProduct.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 104;
            // 
            // colName
            // 
            this.colName.Text = "Product Name";
            this.colName.Width = 403;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPrice.Width = 133;
            // 
            // colProdType
            // 
            this.colProdType.Text = "Type";
            this.colProdType.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1536, 136);
            this.panel1.TabIndex = 77;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHeader.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeader.Location = new System.Drawing.Point(781, 42);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(303, 42);
            this.lblHeader.TabIndex = 44;
            this.lblHeader.Text = "SERVICE DETAILS";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.BtnConfirm);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lstOrder);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtServiceId);
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Location = new System.Drawing.Point(766, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 831);
            this.panel2.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(694, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 42);
            this.label2.TabIndex = 92;
            this.label2.Text = "฿";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(627, 851);
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
            this.btnBack.TabIndex = 88;
            this.btnBack.Values.Text = "Back";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirm.Location = new System.Drawing.Point(38, 753);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnConfirm.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnConfirm.OverrideDefault.Border.Rounding = 25;
            this.BtnConfirm.OverrideDefault.Border.Width = 1;
            this.BtnConfirm.Size = new System.Drawing.Size(705, 46);
            this.BtnConfirm.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnConfirm.StateCommon.Border.Rounding = 25;
            this.BtnConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnConfirm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnConfirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.BtnConfirm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnConfirm.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.BtnConfirm.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.BtnConfirm.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnConfirm.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.BtnConfirm.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.BtnConfirm.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnConfirm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnConfirm.StateTracking.Border.Rounding = 25;
            this.BtnConfirm.StateTracking.Border.Width = 1;
            this.BtnConfirm.TabIndex = 87;
            this.BtnConfirm.Values.Text = "Confirm";
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Location = new System.Drawing.Point(206, 621);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRemove.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemove.OverrideDefault.Border.Rounding = 25;
            this.btnRemove.OverrideDefault.Border.Width = 1;
            this.btnRemove.Size = new System.Drawing.Size(382, 46);
            this.btnRemove.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemove.StateCommon.Border.Rounding = 25;
            this.btnRemove.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemove.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRemove.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemove.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnRemove.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnRemove.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRemove.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnRemove.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnRemove.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRemove.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemove.StateTracking.Border.Rounding = 25;
            this.btnRemove.StateTracking.Border.Width = 1;
            this.btnRemove.TabIndex = 87;
            this.btnRemove.Values.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(33, 689);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 42);
            this.label1.TabIndex = 76;
            this.label1.Text = "Total (Tax Included) ";
            // 
            // lstOrder
            // 
            this.lstOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProductId,
            this.colOrderName,
            this.colOrderPrice,
            this.colOrderQty,
            this.colType});
            this.lstOrder.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.FullRowSelect = true;
            this.lstOrder.GridLines = true;
            this.lstOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstOrder.HideSelection = false;
            this.lstOrder.Location = new System.Drawing.Point(-1, 183);
            this.lstOrder.MultiSelect = false;
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(766, 421);
            this.lstOrder.TabIndex = 71;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.View = System.Windows.Forms.View.Details;
            // 
            // colProductId
            // 
            this.colProductId.Text = "Product ID";
            this.colProductId.Width = 115;
            // 
            // colOrderName
            // 
            this.colOrderName.Text = "Product Name";
            this.colOrderName.Width = 305;
            // 
            // colOrderPrice
            // 
            this.colOrderPrice.Text = "Price";
            this.colOrderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colOrderPrice.Width = 130;
            // 
            // colOrderQty
            // 
            this.colOrderQty.Text = "Quantity";
            this.colOrderQty.Width = 116;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(317, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 42);
            this.label3.TabIndex = 68;
            this.label3.Text = "Resources";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(371, 689);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(317, 46);
            this.txtTotal.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtTotal.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtTotal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTotal.StateCommon.Border.Rounding = 10;
            this.txtTotal.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.TabIndex = 77;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServiceId
            // 
            this.txtServiceId.Location = new System.Drawing.Point(105, 140);
            this.txtServiceId.Name = "txtServiceId";
            this.txtServiceId.Size = new System.Drawing.Size(155, 33);
            this.txtServiceId.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtServiceId.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtServiceId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtServiceId.StateCommon.Border.Rounding = 10;
            this.txtServiceId.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceId.TabIndex = 56;
            this.txtServiceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblId.Location = new System.Drawing.Point(17, 147);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(82, 19);
            this.lblId.TabIndex = 57;
            this.lblId.Text = "Service ID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::pms.Properties.Resources.icons8_search_24;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(713, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = global::pms.Properties.Resources.Logo_Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 112);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(28, 758);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCancel.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCancel.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCancel.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCancel.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCancel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.OverrideDefault.Border.Rounding = 25;
            this.btnCancel.OverrideDefault.Border.Width = 1;
            this.btnCancel.Size = new System.Drawing.Size(705, 46);
            this.btnCancel.StateCommon.Back.Color1 = System.Drawing.Color.Orange;
            this.btnCancel.StateCommon.Back.Color2 = System.Drawing.Color.Orange;
            this.btnCancel.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCancel.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.Rounding = 25;
            this.btnCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCancel.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCancel.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnCancel.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnCancel.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnCancel.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnCancel.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCancel.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnCancel.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnCancel.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCancel.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateTracking.Border.Rounding = 25;
            this.btnCancel.StateTracking.Border.Width = 1;
            this.btnCancel.TabIndex = 96;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(127, 632);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(156, 33);
            this.txtQty.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtQty.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtQty.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQty.StateCommon.Border.Rounding = 10;
            this.txtQty.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.TabIndex = 95;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblQty.Location = new System.Drawing.Point(48, 640);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(73, 19);
            this.lblQty.TabIndex = 94;
            this.lblQty.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(309, 626);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAdd.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.OverrideDefault.Border.Rounding = 25;
            this.btnAdd.OverrideDefault.Border.Width = 1;
            this.btnAdd.Size = new System.Drawing.Size(382, 46);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 25;
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StatePressed.Back.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.StatePressed.Back.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.StatePressed.Border.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.StatePressed.Border.Color2 = System.Drawing.Color.MidnightBlue;
            this.btnAdd.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateTracking.Back.Color1 = System.Drawing.Color.Navy;
            this.btnAdd.StateTracking.Back.Color2 = System.Drawing.Color.Navy;
            this.btnAdd.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAdd.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnAdd.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnAdd.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAdd.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateTracking.Border.Rounding = 25;
            this.btnAdd.StateTracking.Border.Width = 1;
            this.btnAdd.TabIndex = 93;
            this.btnAdd.Values.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(660, 698);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 42);
            this.label4.TabIndex = 99;
            this.label4.Text = "฿";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFees.Location = new System.Drawing.Point(101, 698);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(217, 42);
            this.lblFees.TabIndex = 97;
            this.lblFees.Text = "Service Fees";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(337, 698);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(317, 46);
            this.txtFees.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtFees.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtFees.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFees.StateCommon.Border.Rounding = 10;
            this.txtFees.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.TabIndex = 98;
            this.txtFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormNewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 815);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNewService";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FromNewService_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListView lstProduct;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colProdType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnConfirm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.ColumnHeader colProductId;
        private System.Windows.Forms.ColumnHeader colOrderName;
        private System.Windows.Forms.ColumnHeader colOrderPrice;
        private System.Windows.Forms.ColumnHeader colOrderQty;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtServiceId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFees;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFees;
    }
}