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
    public partial class FormCusHistory : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //lists
        List<Sales> sales = new List<Sales>();
        List<Service> services = new List<Service>();
        public FormCusHistory(string customerid)
        {
            InitializeComponent();
            lblId.Text = customerid;
        }//ef

        private void FormCusHistory_Load(object sender, EventArgs e)
        {
            lblId.Visible = false;
            LoadDataSales();
            LoadDataService();
            ShowInListView();
        }//ef

        private void LoadDataSales()
        {
            string sql = "SELECT * FROM sales WHERE customer = 'i0' ORDER BY order_date DESC";
            sql = sql.Replace("i0", lblId.Text);
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string customer = dr[1].ToString();
                string status = dr[2].ToString();
                double amount = double.Parse(dr[3].ToString());
                string order_date = dr[4].ToString();
                sales.Add(new Sales(id, customer, status, amount, order_date));
            }//eloop
        }//ef

        private void LoadDataService()
        {
            string sql = "SELECT * FROM service WHERE customer = 'i0' ORDER BY startdate DESC";
            sql = sql.Replace("i0", lblId.Text);
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string description = dr[1].ToString();
                string status = dr[2].ToString();
                string type = dr[3].ToString();
                string customer = dr[4].ToString();
                double amount = double.Parse(dr[5].ToString());
                string startdate = dr[6].ToString();
                services.Add(new Service(id, description, status, type, customer, amount, startdate));
            }//eloop
        }//ef

        private void ShowInListView()
        {
            lstSales.Items.Clear();
            foreach (Sales sales in sales)
            {
                ListViewItem nr = new ListViewItem(sales.id.ToString());
                nr.SubItems.Add(sales.status);
                nr.SubItems.Add(sales.amount.ToString("N0"));
                nr.SubItems.Add(sales.order_date.ToString());

                lstSales.Items.Add(nr);
            }//eloop

            lstService.Items.Clear();
            foreach (Service services in services)
            {
                ListViewItem nr = new ListViewItem(services.id.ToString());
                nr.SubItems.Add(services.description);
                nr.SubItems.Add(services.status);
                nr.SubItems.Add(services.type);
                nr.SubItems.Add(services.amount.ToString("N0"));
                nr.SubItems.Add(services.startdate);

                lstService.Items.Add(nr);
            }//eloop
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnExportOrder_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                    Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Sales ID";
                    ws.Cells[1, 2] = "Status";
                    ws.Cells[1, 3] = "Amount";
                    ws.Cells[1, 4] = "Order Date";
                    int i = 2;
                    foreach (ListViewItem items in lstSales.Items)
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

        private void btnExportService_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                    Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Service ID";
                    ws.Cells[1, 2] = "Description";
                    ws.Cells[1, 3] = "Status";
                    ws.Cells[1, 4] = "Type";
                    ws.Cells[1, 5] = "Amount";
                    ws.Cells[1, 6] = "Start Date";
                    int i = 2;
                    foreach (ListViewItem items in lstService.Items)
                    {
                        ws.Cells[i, 1] = items.SubItems[0].Text;
                        ws.Cells[i, 2] = items.SubItems[1].Text;
                        ws.Cells[i, 3] = items.SubItems[2].Text;
                        ws.Cells[i, 4] = items.SubItems[3].Text;
                        ws.Cells[i, 5] = items.SubItems[4].Text;
                        ws.Cells[i, 6] = items.SubItems[5].Text;
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
