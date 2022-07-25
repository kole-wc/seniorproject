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
    public partial class FormExportReportLS : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        public FormExportReportLS()
        {
            InitializeComponent();
        }//ef

        private void FormExportReportLS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.selling' table. You can move, or remove it, as needed.
            this.sellingTableAdapter.Fill(this.DataSet.selling);

            this.reportViewer1.RefreshReport();
        }//ef

        private void btnDone_Click(object sender, EventArgs e)
        {
            string sql = "TRUNCATE TABLE selling";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            string sql = "TRUNCATE TABLE selling";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef

        private void FormExportReportLS_FormClosed(object sender, FormClosedEventArgs e)
        {
            string sql = "TRUNCATE TABLE selling";
            m1.ExecuteNonQuery(sql);
            this.DialogResult = DialogResult.OK;
        }//ef
    }//ec
}//en
