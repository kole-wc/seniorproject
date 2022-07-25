
namespace pms
{
    partial class FormMTNHistory
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstMaintenance = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblId.Location = new System.Drawing.Point(11, 129);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 14);
            this.lblId.TabIndex = 93;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeader.Location = new System.Drawing.Point(336, 36);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(420, 42);
            this.lblHeader.TabIndex = 91;
            this.lblHeader.Text = "MAINTENANCE HISTORY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pms.Properties.Resources.Logo_Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(11, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 112);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // lstMaintenance
            // 
            this.lstMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMaintenance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colProblem,
            this.colStatus,
            this.colDate});
            this.lstMaintenance.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMaintenance.FullRowSelect = true;
            this.lstMaintenance.GridLines = true;
            this.lstMaintenance.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMaintenance.HideSelection = false;
            this.lstMaintenance.Location = new System.Drawing.Point(-1, 119);
            this.lstMaintenance.MultiSelect = false;
            this.lstMaintenance.Name = "lstMaintenance";
            this.lstMaintenance.Size = new System.Drawing.Size(813, 243);
            this.lstMaintenance.TabIndex = 94;
            this.lstMaintenance.UseCompatibleStateImageBehavior = false;
            this.lstMaintenance.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 87;
            // 
            // colProblem
            // 
            this.colProblem.Text = "Problem";
            this.colProblem.Width = 401;
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
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Location = new System.Drawing.Point(287, 383);
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
            this.btnExport.Size = new System.Drawing.Size(215, 45);
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
            this.btnExport.TabIndex = 96;
            this.btnExport.Values.Text = "Export in Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(658, 383);
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
            this.btnBack.TabIndex = 95;
            this.btnBack.Values.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormMTNHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstMaintenance);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMTNHistory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMTNHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lstMaintenance;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colProblem;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExport;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
    }
}