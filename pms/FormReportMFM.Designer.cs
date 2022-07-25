
namespace pms
{
    partial class FormReportMFM
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
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblMonthDisplay = new System.Windows.Forms.Label();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lstMFM = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFreq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.CustomFormat = "yyyy";
            this.dateTime.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(499, 150);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(112, 27);
            this.dateTime.TabIndex = 127;
            this.dateTime.Value = new System.DateTime(2022, 2, 2, 0, 0, 0, 0);
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMonth.Location = new System.Drawing.Point(414, 150);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(79, 25);
            this.lblMonth.TabIndex = 126;
            this.lblMonth.Text = "Month:";
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Location = new System.Drawing.Point(425, 525);
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
            this.btnExport.Size = new System.Drawing.Size(226, 45);
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
            this.btnExport.TabIndex = 125;
            this.btnExport.Values.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblMonthDisplay
            // 
            this.lblMonthDisplay.AutoSize = true;
            this.lblMonthDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthDisplay.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthDisplay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMonthDisplay.Location = new System.Drawing.Point(504, 153);
            this.lblMonthDisplay.Name = "lblMonthDisplay";
            this.lblMonthDisplay.Size = new System.Drawing.Size(0, 25);
            this.lblMonthDisplay.TabIndex = 124;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(895, 525);
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
            this.btnBack.TabIndex = 123;
            this.btnBack.Values.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstMFM
            // 
            this.lstMFM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMFM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colId,
            this.colCus,
            this.colDate,
            this.colFreq});
            this.lstMFM.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMFM.FullRowSelect = true;
            this.lstMFM.GridLines = true;
            this.lstMFM.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMFM.HideSelection = false;
            this.lstMFM.Location = new System.Drawing.Point(-2, 201);
            this.lstMFM.MultiSelect = false;
            this.lstMFM.Name = "lstMFM";
            this.lstMFM.Size = new System.Drawing.Size(1047, 290);
            this.lstMFM.TabIndex = 122;
            this.lstMFM.UseCompatibleStateImageBehavior = false;
            this.lstMFM.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // colId
            // 
            this.colId.Text = "Service ID";
            this.colId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colId.Width = 205;
            // 
            // colCus
            // 
            this.colCus.Text = "Customer";
            this.colCus.Width = 240;
            // 
            // colDate
            // 
            this.colDate.Text = "Request Date";
            this.colDate.Width = 472;
            // 
            // colFreq
            // 
            this.colFreq.Text = "Frequency";
            this.colFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colFreq.Width = 127;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(369, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(321, 29);
            this.lblName.TabIndex = 121;
            this.lblName.Text = "Most Frequent Maintenance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pms.Properties.Resources.Logo_Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(392, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 95);
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // FormReportMFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 586);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblMonthDisplay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstMFM);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReportMFM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormReportMFM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label lblMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExport;
        private System.Windows.Forms.Label lblMonthDisplay;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
        private System.Windows.Forms.ListView lstMFM;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colCus;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colFreq;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}