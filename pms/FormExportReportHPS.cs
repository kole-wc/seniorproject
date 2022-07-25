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
    public partial class FormExportReportHPS : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        public FormExportReportHPS()
        {
            InitializeComponent();
        }//ef

        private void FormExportReportHPS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.highest_paid_services' table. You can move, or remove it, as needed.
            this.highest_paid_servicesTableAdapter.Fill(this.DataSet.highest_paid_services);

            this.reportViewer1.RefreshReport();
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            string sql = "TRUNCATE TABLE highest_paid_services";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnDone_Click(object sender, EventArgs e)
        {
            string sql = "TRUNCATE TABLE highest_paid_services";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef

        private void FormExportReportHPS_FormClosed(object sender, FormClosedEventArgs e)
        {
            string sql = "TRUNCATE TABLE highest_paid_services";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef
    }//ec
}//en
