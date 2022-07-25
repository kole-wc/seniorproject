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
    public partial class FormService : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of customers
        List<Service> services = new List<Service>();
        public FormService()
        {
            InitializeComponent();
        }//ef

        private void FormService_Load(object sender, EventArgs e)
        {
            LoadCustomer();

            LoadDataAll();

            refreshAll();

            resetData();
        }//ef

        private void LoadDataAll()
        {
            services.Clear();
            string sql = "SELECT * FROM service ORDER BY startdate DESC";
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

        private void LoadDataAllId()
        {
            services.Clear();
            string sql = "SELECT * FROM service ORDER BY Id DESC";
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

        private void LoadDataAllProc()
        {
            services.Clear();
            string sql = "SELECT * FROM service WHERE status = 'Processing'";
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

        private void LoadDataAllDeli()
        {
            services.Clear();
            string sql = "SELECT * FROM service WHERE status = 'Ongoing'";
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

        private void LoadDataAllComp()
        {
            services.Clear();
            string sql = "SELECT * FROM service WHERE status = 'Completed'";
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

        private void LoadDataAllCan()
        {
            services.Clear();
            string sql = "SELECT * FROM service WHERE status = 'Cancelled'";
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

        private void LoadDataAllCrane()
        {
            services.Clear();
            string sql = "SELECT * FROM service WHERE type = 'Crane'";
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

        private void LoadDataAllElevator()
        {
            services.Clear();
            string sql = "SELECT * FROM service WHERE type = 'Elevator'";
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

        private void LoadDataAllAsc()
        {
            services.Clear();
            string sql = "SELECT * FROM service ORDER BY startdate ASC";
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
            List<Service> searchService;
            if (search.Trim() != "")
            {
                searchService = services.Where(x => x.id.ToString().Contains(search)
                || x.customer.ToLower().Contains(search)
                || x.description.ToLower().Contains(search)).ToList();
            }
            else
            {
                searchService = services;
            }
            ShowInListView(searchService);
        }//ef

        private void ShowInListView(List<Service> searchService)
        {
            lstService.Items.Clear();
            foreach (Service services in searchService)
            {
                ListViewItem nr = new ListViewItem(services.id.ToString());
                nr.SubItems.Add(services.description);
                nr.SubItems.Add(services.status);
                nr.SubItems.Add(services.type);
                nr.SubItems.Add(services.customer); 
                nr.SubItems.Add(services.amount.ToString("N0"));
                nr.SubItems.Add(services.startdate);

                lstService.Items.Add(nr);
            }//eloop
        }//ef

        public void resetData()
        {
            txtId.Text = "";
            cmbType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbCustomer.SelectedIndex = -1;
            txtAmount.Text = "";
            txtDesc.Text = "";
            btnAddUpdate.Text = "Add";
            //lbl
            lblId.Visible = false;
            lblDesc.Visible = false;
            lblStatus.Visible = false;
            lblCustomer.Visible = false;
            lblAmount.Visible = false;
            //txt
            txtId.Visible = false;
            txtDesc.Visible = false;
            txtAmount.Visible = false;
            //btn
            btnExport.Text = "Export All in Excel";
            btnAddUpdate.Visible = false;
            btnReset.Visible = false;
            btnExport.Visible = true;
            btnServiceDetails.Visible = false;
            //cmb
            cmbType.Text = "Service Type";
            cmbStatus.Text = "Processing";
            cmbStatus.Visible = false;
            cmbCustomer.Visible = false;
            dateTime.Value = DateTime.Now;
            dateTime.Visible = false;
        }//ef

        private void lstService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstService.SelectedItems.Count > 0)
            {
                string id = lstService.SelectedItems[0].SubItems[0].Text;
                string description = lstService.SelectedItems[0].SubItems[1].Text;
                string status = lstService.SelectedItems[0].SubItems[2].Text;
                string type = lstService.SelectedItems[0].SubItems[3].Text;
                string customer = lstService.SelectedItems[0].SubItems[4].Text;
                string amount = lstService.SelectedItems[0].SubItems[5].Text;
                string startdate = lstService.SelectedItems[0].SubItems[6].Text;

                txtId.Text = id;
                txtDesc.Text = description;
                cmbStatus.Text = status;
                cmbType.Text = type;
                cmbCustomer.Text = customer;
                txtAmount.Text = amount.Replace(",", "");
                dateTime.Text = startdate;

                btnAddUpdate.Text = "Update";
                //lbl
                lblId.Visible = true;
                lblDesc.Visible = true;
                lblStatus.Visible = true;
                lblCustomer.Visible = true;
                lblAmount.Visible = true;
                //txt
                txtId.Visible = true;
                txtDesc.Visible = true;
                txtAmount.Visible = true;
                //btn
                btnExport.Text = "Export Individually in Excel";
                btnAddUpdate.Visible = true;
                btnReset.Visible = true;
                btnServiceDetails.Visible = true;
                //cmb
                cmbStatus.Visible = true;
                cmbCustomer.Visible = true;

                dateTime.Visible = true;
            }//eif
            else
            {
                resetData();
            }//elese
        }//ef

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string description = txtDesc.Text;
            string status = cmbStatus.Text;
            string type = cmbType.Text;
            string customer = cmbCustomer.Text;
            string amount = txtAmount.Text;
            string startdate = dateTime.Value.ToString("yyyy-MM-dd");
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo);
            if (confirmResult == MessageBoxResult.Yes)
            {
                if (btnAddUpdate.Text == "Add")
                {
                    //sql insertion string
                    string insert = "INSERT INTO service(id,description,status,type,customer,amount,startdate)";
                    insert += "value(null,'a1','a2','a3','a4','a5','a6')";
                    insert = insert.Replace("a1", description);
                    insert = insert.Replace("a2", status);
                    insert = insert.Replace("a3", type);
                    insert = insert.Replace("a4", customer);
                    insert = insert.Replace("a5", amount);
                    insert = insert.Replace("a6", startdate);
                    //MessageBox.Show(insert);
                    m1.ExecuteQuery(insert);
                    LoadDataAllId();
                    refreshAll();

                    string serviceid = lstService.Items[0].SubItems[0].Text;
                    txtId.Text = serviceid;
                    FormNewService formnewservice = new FormNewService(txtId.Text);
                    formnewservice.ShowDialog();
                    //MessageBox.Show("New service has been added.");
                    LoadDataAll();
                    refreshAll();
                    resetData();
                }//eif
                else if (btnAddUpdate.Text == "Update")
                {
                    //sql update string
                    string update = "UPDATE service SET description = 'b1',status = 'b2',type = 'b3',customer = 'b4', amount = 'b5', startdate = 'b6' WHERE id = 'b0'";
                    update = update.Replace("b1", description);
                    update = update.Replace("b2", status);
                    update = update.Replace("b3", type);
                    update = update.Replace("b4", customer);
                    update = update.Replace("b5", amount);
                    update = update.Replace("b6", startdate);
                    update = update.Replace("b0", id);
                    //MessageBox.Show(update);
                    m1.ExecuteQuery(update);
                    MessageBox.Show("Service information has been updated.");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }//ef

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            refreshAll();
            resetData();
        }//ef

        private void btnAll1_Click(object sender, EventArgs e)
        {
            btnCrane.Visible = true;
            btnElevator.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnAll2_Click(object sender, EventArgs e)
        {
            btnCrane.Visible = true;
            btnElevator.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnCrane_Click(object sender, EventArgs e)
        {
            btnElevator.Visible = true;
            btnCrane.Visible = false;
            btnAll1.Visible = true;
            btnAll2.Visible = false;
            LoadDataAllCrane();
            refreshAll();
            resetData();
        }//ef

        private void btnElevator_Click(object sender, EventArgs e)
        {
            btnElevator.Visible = false;
            btnCrane.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = true;
            LoadDataAllElevator();
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

        private void btnOldest_Click(object sender, EventArgs e)
        {
            btnOldest.Visible = false;
            btnNewest.Visible = true;
            LoadDataAllAsc();
            refreshAll();
            resetData();
        }//ef

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbl
            lblDesc.Visible = true;
            lblStatus.Visible = true;
            lblCustomer.Visible = true;
            lblAmount.Visible = false;
            //txt
            txtDesc.Visible = true;
            txtAmount.Visible = false;
            //btn
            btnAddUpdate.Visible = true;
            btnReset.Visible = true;
            btnExport.Visible = true;
            //cmb
            cmbStatus.Visible = true;
            cmbCustomer.Visible = true;
            dateTime.Visible = false;
            cmbStatus.Text = "Processing";
        }//ef

        private void btnServiceDetails_Click(object sender, EventArgs e)
        {
            string serviceid = txtId.Text;
            FormServiceDetails formservicedetails = new FormServiceDetails(txtId.Text);
            formservicedetails.ShowDialog();
        }//ef

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = true;
            btnCancelled.Visible = true;
            kryptonButton2.Visible = false;
            kryptonButton1.Visible = false;
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
            kryptonButton2.Visible = true;
            kryptonButton1.Visible = false;
            btnAll3.Visible = false;
            btnAll4.Visible = false;
            LoadDataAllProc();
            refreshAll();
            resetData();
        }//ef

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = true;
            btnCancelled.Visible = true;
            kryptonButton2.Visible = false;
            kryptonButton1.Visible = false;
            btnAll3.Visible = false;
            btnAll4.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnDeli_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = false;
            btnComp.Visible = true;
            btnCancelled.Visible = true;
            kryptonButton2.Visible = false;
            kryptonButton1.Visible = true;
            btnAll3.Visible = false;
            btnAll4.Visible = false;
            LoadDataAllDeli();
            refreshAll();
            resetData();
        }//ef

        private void btnAll3_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = true;
            btnCancelled.Visible = true;
            kryptonButton2.Visible = false;
            kryptonButton1.Visible = false;
            btnAll3.Visible = false;
            btnAll4.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnComp_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = false;
            btnCancelled.Visible = true;
            kryptonButton2.Visible = false;
            kryptonButton1.Visible = false;
            btnAll3.Visible = true;
            btnAll4.Visible = false;
            LoadDataAllComp();
            refreshAll();
            resetData();
        }//ef

        private void btnAll4_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = true;
            btnCancelled.Visible = true;
            kryptonButton2.Visible = false;
            kryptonButton1.Visible = false;
            btnAll3.Visible = false;
            btnAll4.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnDeli.Visible = true;
            btnComp.Visible = true;
            btnCancelled.Visible = false;
            kryptonButton2.Visible = false;
            kryptonButton1.Visible = false;
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
                        ws.Cells[1, 2] = "Description";
                        ws.Cells[1, 3] = "Status";
                        ws.Cells[1, 4] = "Type";
                        ws.Cells[1, 5] = "Customer";
                        ws.Cells[1, 6] = "Amount";
                        ws.Cells[1, 7] = "Start Date";
                        int i = 2;
                        foreach (ListViewItem items in lstService.Items)
                        {
                            ws.Cells[i, 1] = items.SubItems[0].Text;
                            ws.Cells[i, 2] = items.SubItems[1].Text;
                            ws.Cells[i, 3] = items.SubItems[2].Text;
                            ws.Cells[i, 4] = items.SubItems[3].Text;
                            ws.Cells[i, 5] = items.SubItems[4].Text;
                            ws.Cells[i, 6] = items.SubItems[5].Text;
                            ws.Cells[i, 7] = items.SubItems[6].Text;
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
                        ws.Cells[1, 2] = "Description";
                        ws.Cells[1, 3] = "Status";
                        ws.Cells[1, 4] = "Type";
                        ws.Cells[1, 5] = "Customer";
                        ws.Cells[1, 6] = "Amount";
                        ws.Cells[1, 7] = "Start Date";
                        int i = 2;
                        ws.Cells[i, 1] = txtId.Text;
                        ws.Cells[i, 2] = txtDesc.Text;
                        ws.Cells[i, 3] = cmbStatus.Text;
                        ws.Cells[i, 4] = cmbType.Text;
                        ws.Cells[i, 5] = cmbCustomer.Text;
                        ws.Cells[i, 6] = txtAmount.Text;
                        ws.Cells[i, 7] = dateTime.Text;
                        wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                    }//eif
                    MessageBox.Show("Succesffuly exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//eif
            }//eusing
        }//ef
    }//ec
}//en
