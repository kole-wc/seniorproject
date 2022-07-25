using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace pms
{
    public partial class FormMTNHistory : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        List<Maintenance> maintenances = new List<Maintenance>();
        public FormMTNHistory(string serviceid)
        {
            InitializeComponent();
            lblId.Text = serviceid;
        }//ef

        private void FormMTNHistory_Load(object sender, EventArgs e)
        {
            lblId.Visible = false;
            LoadData();
            ShowInListView();
        }//ef

        private void LoadData()
        {
            maintenances.Clear();
            string sql = "SELECT * FROM maintenance WHERE service = 'i0' ORDER BY request_date DESC";
            sql = sql.Replace("i0", lblId.Text);
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string service = dr[1].ToString();
                string problem = dr[2].ToString();
                string status = dr[3].ToString();
                string request_date = dr[4].ToString();
                maintenances.Add(new Maintenance(id, service, problem, status, request_date));
            }//eloop
        }//ef

        private void ShowInListView()
        {
            lstMaintenance.Items.Clear();
            foreach (Maintenance maintenances in maintenances)
            {
                ListViewItem nr = new ListViewItem(maintenances.id.ToString());
                nr.SubItems.Add(maintenances.problem);
                nr.SubItems.Add(maintenances.status);
                nr.SubItems.Add(maintenances.request_date);

                lstMaintenance.Items.Add(nr);
            }//eloop
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                    Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Maintenance ID";
                    ws.Cells[1, 2] = "Problem";
                    ws.Cells[1, 3] = "Status";
                    ws.Cells[1, 4] = "Request Date";
                    int i = 2;
                    foreach (ListViewItem items in lstMaintenance.Items)
                    {
                        ws.Cells[i, 1] = items.SubItems[0].Text;
                        ws.Cells[i, 2] = items.SubItems[1].Text;
                        ws.Cells[i, 3] = items.SubItems[2].Text;
                        ws.Cells[i, 4] = items.SubItems[3].Text;
                        i++;
                    }//eloop
                    wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Succesffuly exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//eif
            }//eusing
        }//ef
    }//ec
}//en
