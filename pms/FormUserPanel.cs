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
    public partial class FormUserPanel : Form
    {
        public FormUserPanel()
        {
            InitializeComponent();
        }//ef

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            new FormCustomer().ShowDialog();
        }//ef

        private void btnService_Click(object sender, EventArgs e)
        {
            new FormService().ShowDialog();
        }//ef

        private void btnSales_Click(object sender, EventArgs e)
        {
            new FormSales().ShowDialog();
        }//ef

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            new FormMaintenance().ShowDialog();
        }//ef

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            new FormSupplier().ShowDialog();
        }//ef

        private void btnReport_Click(object sender, EventArgs e)
        {
            new FormReport().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().ShowDialog();
            Application.Exit();
        }//ef

        private void FormUserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }//ef

    }//ec
}//en
