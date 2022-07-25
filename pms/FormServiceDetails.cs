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
    public partial class FormServiceDetails : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of service
        List<NewService> newservice = new List<NewService>();
        public FormServiceDetails(string serviceid)
        {
            InitializeComponent();
            txtServiceId.Text = serviceid;
        }//ef

        private void FormServiceDetails_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowInListView();
        }//ef

        private void LoadData()
        {
            string sql = "SELECT * FROM service_details WHERE service_id = 'i0' ORDER BY id DESC";
            sql = sql.Replace("i0", txtServiceId.Text);
            DataTable t1 = m1.GetDataTable(sql);

            double fees = 0;
            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                int salesid = int.Parse(dr[1].ToString());
                fees = double.Parse(dr[2].ToString());
                int productid = int.Parse(dr[3].ToString());
                string name = dr[4].ToString();
                double price = int.Parse(dr[5].ToString());
                int qty = int.Parse(dr[6].ToString());
                string type = dr[7].ToString();
                newservice.Add(new NewService(id, salesid, fees, productid, name, price, qty, type));
            }//eloop
            txtFees.Text = fees.ToString("N0");
        }//ef

        private void ShowInListView()
        {
            lstOrderDetails.Items.Clear();
            double total = 0;
            foreach (NewService newservice in newservice)
            {
                ListViewItem nr = new ListViewItem(newservice.productid.ToString());
                nr.SubItems.Add(newservice.name.ToString());
                nr.SubItems.Add(newservice.price.ToString("N0"));
                nr.SubItems.Add(newservice.qty.ToString());
                nr.SubItems.Add(newservice.type);

                lstOrderDetails.Items.Add(nr);

                total += (newservice.price * 1.07);
            }//eloop
            total = total + double.Parse(txtFees.Text);
            txtTotal.Text = total.ToString("N0");
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }//ef

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                    Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Order ID";
                    ws.Cells[1, 2] = txtServiceId.Text;
                    ws.Cells[3, 1] = "Product ID";
                    ws.Cells[3, 2] = "Product Name";
                    ws.Cells[3, 3] = "Amount (Baht)";
                    ws.Cells[3, 4] = "Quantity";
                    ws.Cells[3, 5] = "Type";
                    ws.Cells[3, 7] = "Fees";
                    ws.Cells[3, 8] = "Total Tax & Fees Included (Baht)";
                    int i = 4;
                    foreach (ListViewItem items in lstOrderDetails.Items)
                    {
                        ws.Cells[i, 1] = items.SubItems[0].Text;
                        ws.Cells[i, 2] = items.SubItems[1].Text;
                        ws.Cells[i, 3] = items.SubItems[2].Text;
                        ws.Cells[i, 4] = items.SubItems[3].Text;
                        ws.Cells[i, 5] = items.SubItems[4].Text;
                        i++;
                    }//eloop
                    ws.Cells[4, 7] = txtFees.Text;
                    ws.Cells[4, 8] = txtTotal.Text;
                    wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Succesfully exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//eif
            }//eusing
        }//ef
    }//ec
}//en
