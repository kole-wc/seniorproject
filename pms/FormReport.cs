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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }//ef

        private void btnCusRetention_Click(object sender, EventArgs e)
        {
            new FormReportCR().ShowDialog();
        }//ef

        private void btnPaidService_Click(object sender, EventArgs e)
        {
            new FormReportHPS().ShowDialog();
        }//ef

        private void btnBestSelling_Click(object sender, EventArgs e)
        {
            new FormReportBS().ShowDialog();
        }//ef

        private void btnLeastSelling_Click(object sender, EventArgs e)
        {
            new FormReportLS().ShowDialog();
        }//ef

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            new FormReportMFM().ShowDialog();
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }//ef
    }//ec
}//en
