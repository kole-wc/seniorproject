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
    public partial class FormExportReportMFM : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        public FormExportReportMFM()
        {
            InitializeComponent();
        }//ef

        private void FormExportReportMFM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.most_frequent_maintenance' table. You can move, or remove it, as needed.
            this.most_frequent_maintenanceTableAdapter.Fill(this.DataSet.most_frequent_maintenance);

            this.reportViewer1.RefreshReport();
        }//ef

        private void btnDone_Click(object sender, EventArgs e)
        {
            string sql = "TRUNCATE TABLE most_frequent_maintenance";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            string sql = "TRUNCATE TABLE most_frequent_maintenance";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef

        private void FormExportReportMFM_FormClosed(object sender, FormClosedEventArgs e)
        {
            string sql = "TRUNCATE TABLE most_frequent_maintenance";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef
    }//ec
}//en
