using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MessageBox = System.Windows.Forms.MessageBox;

namespace pms
{
    public partial class FormSales : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of sales
        List<Sales> sales = new List<Sales>();
        public FormSales()
        {
            InitializeComponent();
        }//ef

        private void FormSales_Load(object sender, EventArgs e)
        {
            LoadCustomer();

            LoadDataAll();

            refreshAll();

            btnOrderDetails.Visible = false;
            btnExport.Visible = true;
            btnReset.Visible = false;
            txtId.Visible = false;
            lblId.Visible = false;
            txtAmount.Visible = false;
            lblAmount.Visible = false;
            dateTime.Value = DateTime.Now;
            cmbStatus.Text = "Processing";
        }//ef

        private void LoadDataAll()
        {
            sales.Clear();
            string sql = "SELECT * FROM sales ORDER BY order_date DESC";
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

        private void LoadDataAllId()
        {
            sales.Clear();
            string sql = "SELECT * FROM sales ORDER BY id DESC";
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

        private void LoadDataAllAsc()
        {
            sales.Clear();
            string sql = "SELECT * FROM sales ORDER BY order_date ASC";
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

        private void LoadDataAllProc()
        {
            sales.Clear();
            string sql = "SELECT * FROM sales WHERE status = 'Processing'";
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

        private void LoadDataAllDeli()
        {
            sales.Clear();
            string sql = "SELECT * FROM sales WHERE status = 'Delivering'";
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

        private void LoadDataAllComp()
        {
            sales.Clear();
            string sql = "SELECT * FROM sales WHERE status = 'Completed'";
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

        private void LoadDataAllCan()
        {
            sales.Clear();
            string sql = "SELECT * FROM sales WHERE status = 'Cancelled'";
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

        private void LoadCustomer()
        {
            string sql = "SELECT id, firstname, lastname, company FROM customer";
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string firstname = dr[1].ToString();
                string lastname = dr[2].ToString();
                string company = dr[3].ToString();
                string customer;
                if (String.IsNullOrEmpty(company))
                {
                    customer = id + " - " + firstname + " " + lastname;
                }//eif
                else
                {
                    customer = id + " - " + company;
                }//eelse
                cmbCustomer.Items.Add(customer);
            }//eloop
        }//ef

        private void refreshAll()
        {
            string search = txtSearch.Text.Replace(" ", "").ToLower();
            List<Sales> searchSales;
            if (search.Trim() != "")
            {
                searchSales = sales.Where(x => x.id.ToString().Contains(search)
                || x.customer.ToLower().Contains(search)).ToList();
            }
            else
            {
                searchSales = sales;
            }
            ShowInListView(searchSales);
        }

        private void ShowInListView(List<Sales> searchSales)
        {
            lstSales.Items.Clear();
            foreach(Sales sales in searchSales)
            {
                ListViewItem nr = new ListViewItem(sales.id.ToString());
                nr.SubItems.Add(sales.customer);
                nr.SubItems.Add(sales.status);
                nr.SubItems.Add(sales.amount.ToString("N0"));
                nr.SubItems.Add(sales.order_date.ToString());

                lstSales.Items.Add(nr);
            }//eloop
        }//ef

        public void resetData()
        {
            txtId.Text = "";
            cmbCustomer.Text = "";
            cmbStatus.Text = "";
            txtAmount.Text = "";
            btnOrderDetails.Visible = false;
            btnExport.Visible = true;
            btnExport.Text = "Export All in Excel";
            btnReset.Visible = false;
            txtId.Visible = false;
            lblId.Visible = false;
            txtAmount.Visible = false;
            lblAmount.Visible = false;
            btnAddUpdate.Text = "Add";
            dateTime.Value = DateTime.Now;
            cmbCustomer.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }//ef

        private void lstSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSales.SelectedItems.Count > 0)
            {
                string id = lstSales.SelectedItems[0].SubItems[0].Text;
                string customer = lstSales.SelectedItems[0].SubItems[1].Text;
                string status = lstSales.SelectedItems[0].SubItems[2].Text;
                string amount = lstSales.SelectedItems[0].SubItems[3].Text;
                string order_date = lstSales.SelectedItems[0].SubItems[4].Text;

                txtId.Text = id;
                cmbCustomer.Text = customer;
                cmbStatus.Text = status;
                txtAmount.Text = amount.Replace(",", "");
                dateTime.Text = order_date;

                btnAddUpdate.Text = "Update";
                btnExport.Text = "Export Individually in Excel";
                btnOrderDetails.Visible = true;
                btnExport.Visible = true;
                btnReset.Visible = true;
                txtId.Visible = true;
                lblId.Visible = true;
                txtAmount.Visible = true;
                lblAmount.Visible = true;
            }//eif
            else
            {
                resetData();
            }//elese
        }//ef

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }//ef

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string customer = cmbCustomer.Text;
            string status = cmbStatus.Text;
            string amount = txtAmount.Text;
            string order_date = dateTime.Value.ToString("yyyy-MM-dd");
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo);
            if (confirmResult == MessageBoxResult.Yes)
            {
                if (btnAddUpdate.Text == "Add")
                {
                    //sql insertion string
                    string insert = "INSERT INTO sales(id,customer,status,amount,order_date)";
                    insert += "value(null,'a1','a2','a3','a4')";
                    insert = insert.Replace("a1", customer);
                    insert = insert.Replace("a2", status);
                    insert = insert.Replace("a3", amount);
                    insert = insert.Replace("a4", order_date);
                    //MessageBox.Show(insert);
                    m1.ExecuteQuery(insert);
                    LoadDataAllId();
                    refreshAll();

                    string orderid = lstSales.Items[0].SubItems[0].Text;
                    txtId.Text = orderid;
                    FormOrder formorder = new FormOrder(txtId.Text);
                    formorder.ShowDialog();

                    //MessageBox.Show(orderid);
                    //MessageBox.Show("New order has been added.");
                    LoadDataAll();
                    refreshAll();
                    resetData();
                }//eif
                else if (btnAddUpdate.Text == "Update")
                {
                    //sql update string
                    string update = "UPDATE sales SET customer = 'b1',status = 'b2',amount = 'b3',order_date = 'b4' WHERE id = 'b0'";
                    update = update.Replace("b1", customer);
                    update = update.Replace("b2", status);
                    update = update.Replace("b3", amount);
                    update = update.Replace("b4", order_date);
                    update = update.Replace("b0", id);
                    //MessageBox.Show(update);
                    m1.ExecuteQuery(update);
                    MessageBox.Show("Sales information has been updated.");
                    LoadDataAll();
                    refreshAll();
                    resetData();
                }//eeif
            }//eeif
            else
            {
                // If 'No', do something here.
            }//eelse
        }//ef

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            refreshAll();
            resetData();
        }//ef

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnAll1_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = true;
            btnCancelled.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            btnAll3.Visible = false;
            btnAll4.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnAll2_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = true;
            btnCancelled.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            btnAll3.Visible = false;
            btnAll4.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnAll3_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = true;
            btnCancelled.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            btnAll3.Visible = false;
            btnAll4.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnProc_Click(object sender, EventArgs e)
        {
            btnProc.Visible = false;
            btnDeli.Visible = true;
            btnComp.Visible = true;
            btnCancelled.Visible = true;
            btnAll1.Visible = true;
            btnAll2.Visible = false;
            btnAll3.Visible = false;
            btnAll4.Visible = false;
            LoadDataAllProc();
            refreshAll();
            resetData();
        }//ef

        private void btnDeli_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = false;
            btnComp.Visible = true;
            btnCancelled.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = true;
            btnAll3.Visible = false;
            btnAll4.Visible = false;
            LoadDataAllDeli();
            refreshAll();
            resetData();
        }//ef

        private void btnComp_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = false;
            btnCancelled.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            btnAll3.Visible = true;
            btnAll4.Visible = false;
            LoadDataAllComp();
            refreshAll();
            resetData();
        }//ef

        private void btnOldest_Click(object sender, EventArgs e)
        {
            btnOldest.Visible = false;
            btnNewest.Visible = true;
            LoadDataAllAsc();
            refreshAll();
            resetData();
        }//ef

        private void btnNewest_Click(object sender, EventArgs e)
        {
            btnOldest.Visible = true;
            btnNewest.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            string orderid = txtId.Text;
            FormOrderDetails formorderdetails = new FormOrderDetails(txtId.Text);
            formorderdetails.ShowDialog();
        }//ef

        private void btnAll4_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = true;
            btnCancelled.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            btnAll3.Visible = false;
            btnAll4.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = true;
            btnCancelled.Visible = false;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            btnAll3.Visible = false;
            btnAll4.Visible = true;
            LoadDataAllCan();
            refreshAll();
            resetData();
        }//ef

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (btnExport.Text == "Export All in Excel")
                    {
                        Excel.Application app = new Excel.Application();
                        Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                        Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        ws.Cells[1, 1] = "ID";
                        ws.Cells[1, 2] = "Customer";
                        ws.Cells[1, 3] = "Status";
                        ws.Cells[1, 4] = "Amount";
                        ws.Cells[1, 5] = "Order Date";
                        int i = 2;
                        foreach (ListViewItem items in lstSales.Items)
                        {
                            ws.Cells[i, 1] = items.SubItems[0].Text;
                            ws.Cells[i, 2] = items.SubItems[1].Text;
                            ws.Cells[i, 3] = items.SubItems[2].Text;
                            ws.Cells[i, 4] = items.SubItems[3].Text;
                            ws.Cells[i, 5] = items.SubItems[4].Text;
                            i++;
                        }//eloop
                        wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                    }//eif
                    else if (btnExport.Text == "Export Individually in Excel")
                    {
                        Excel.Application app = new Excel.Application();
                        Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                        Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        ws.Cells[1, 1] = "ID";
                        ws.Cells[1, 2] = "Customer";
                        ws.Cells[1, 3] = "Status";
                        ws.Cells[1, 4] = "Amount";
                        ws.Cells[1, 5] = "Order Date";
                        int i = 2;
                        ws.Cells[i, 1] = txtId.Text;
                        ws.Cells[i, 2] = cmbCustomer.Text;
                        ws.Cells[i, 3] = cmbStatus.Text;
                        ws.Cells[i, 4] = txtAmount.Text;
                        ws.Cells[i, 5] = dateTime.Text;
                        wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                    }//eif
                    MessageBox.Show("Succesffuly exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//eif
            }//eusing
        }//ef
    }//ec
}//en
