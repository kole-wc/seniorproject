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
    public partial class FormOrderDetails : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of orderdetails
        List<OrderDetails> orderdetails = new List<OrderDetails>();

        public FormOrderDetails(string orderid)
        {
            InitializeComponent();
            txtOrderId.Text = orderid;
        }//ef

        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowInListView();
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM order_details WHERE sales_id = 'i0' ORDER BY id DESC";
            sql = sql.Replace("i0", txtOrderId.Text);
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                int salesid = int.Parse(dr[1].ToString());
                int productid = int.Parse(dr[2].ToString());
                string name = dr[3].ToString();
                double price = int.Parse(dr[4].ToString());
                int qty = int.Parse(dr[5].ToString());
                string type = dr[6].ToString();
                orderdetails.Add(new OrderDetails(id, salesid, productid, name, price, qty, type));
            }//eloop
        }//ef

        private void ShowInListView()
        {
            lstOrderDetails.Items.Clear();
            double total = 0;
            foreach (OrderDetails orderdetails in orderdetails)
            {
                ListViewItem nr = new ListViewItem(orderdetails.productid.ToString());
                nr.SubItems.Add(orderdetails.name.ToString());
                nr.SubItems.Add(orderdetails.price.ToString("N0"));
                nr.SubItems.Add(orderdetails.qty.ToString());
                nr.SubItems.Add(orderdetails.type);

                lstOrderDetails.Items.Add(nr);

                total += (orderdetails.price * 1.07);
            }//eloop
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
                    ws.Cells[1, 2] = txtOrderId.Text;
                    ws.Cells[3, 1] = "Product ID";
                    ws.Cells[3, 2] = "Product Name";
                    ws.Cells[3, 3] = "Amount (Baht)";
                    ws.Cells[3, 4] = "Quantity";
                    ws.Cells[3, 5] = "Type";
                    ws.Cells[3, 7] = "Total Tax Included (Baht)";
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
                    ws.Cells[4, 7] = txtTotal.Text;
                    wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Succesfully exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//eif
            }//eusing
        }//ef
    }//ec
}//en
