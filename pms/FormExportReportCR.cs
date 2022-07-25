using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pms
{
    public partial class FormExportReportCR : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        public FormExportReportCR()
        {
            InitializeComponent();
        }//ef

        private void FormExportReportCR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.customer_retention' table. You can move, or remove it, as needed.
            this.customer_retentionTableAdapter.Fill(this.DataSet.customer_retention);

            this.reportViewer1.RefreshReport();
        }//ef

        private void btnDone_Click(object sender, EventArgs e)
        {
            string sql = "TRUNCATE TABLE customer_retention";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            string sql = "TRUNCATE TABLE customer_retention";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef

        private void FormExportReportCR_FormClosed(object sender, FormClosedEventArgs e)
        {
            string sql = "TRUNCATE TABLE customer_retention";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef
    }//ec
}//en
