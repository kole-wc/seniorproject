using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MessageBox = System.Windows.Forms.MessageBox;


namespace pms
{
    public partial class FormCustomer : Form
    {
        DataManager m1 = new DataManager("localhost","seniorproject","root","");
        //list of customers
        List<Customer> customer = new List<Customer>();
        public FormCustomer()
        {
            InitializeComponent();
        }//ef

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadDataAll();

            refreshAll();

            resetData();
        }//ef

        private void LoadDataAll()
        {
            customer.Clear();
            string sql = "SELECT * FROM customer ORDER BY id DESC";
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string firstname = dr[1].ToString();
                string lastname = dr[2].ToString();
                string company = dr[3].ToString();
                string address = dr[4].ToString();
                string tel = dr[5].ToString();
                string phone = dr[6].ToString();
                string email = dr[7].ToString();
                string type = dr[8].ToString();
                string fullname = firstname + lastname;
                customer.Add(new Customer(id, firstname, lastname, company, address, tel, phone, email, type, fullname));
            }//eloop
        }//ef

        private void ShowInListView(List<Customer> searchCus)
        {
            lstCustomer.Items.Clear();
            foreach(Customer cus in searchCus)
            {
                ListViewItem nr = new ListViewItem(cus.id.ToString());
                nr.SubItems.Add(cus.firstName);
                nr.SubItems.Add(cus.lastName);
                nr.SubItems.Add(cus.company);
                nr.SubItems.Add(cus.address);
                nr.SubItems.Add(cus.tel);
                nr.SubItems.Add(cus.phone);
                nr.SubItems.Add(cus.email);
                nr.SubItems.Add(cus.type);
                lstCustomer.Items.Add(nr);
            }//eloop
        }//ef

        private void refreshAll()
        {
            string search = txtSearch.Text.Replace(" ","").ToLower();
            List<Customer> searchCus;
            if (search.Trim() != "")
            {
                searchCus = customer.Where(x => x.id.ToString().Contains(search) 
                || x.firstName.ToLower().Contains(search)
                || x.lastName.ToLower().Contains(search)
                || x.company.ToLower().Replace(" ","").Contains(search)
                || x.tel.Contains(search)
                || x.phone.Contains(search)
                || x.email.ToLower().Contains(search)
                || x.type.ToLower().Contains(search)
                || x.fullName.ToLower().Contains(search)).ToList();
            }
            else
            {
                searchCus = customer;
            }
            ShowInListView(searchCus);
        }//ef

        private void LoadDataAllAsc()
        {
            customer.Clear();
            string sql = "SELECT * FROM customer ORDER BY id ASC";
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string firstname = dr[1].ToString();
                string lastname = dr[2].ToString();
                string company = dr[3].ToString();
                string address = dr[4].ToString();
                string tel = dr[5].ToString();
                string phone = dr[6].ToString();
                string email = dr[7].ToString();
                string type = dr[8].ToString();
                string fullname = firstname + lastname;
                customer.Add(new Customer(id, firstname, lastname, company, address, tel, phone, email, type, fullname));
            }//eloop
        }//ef

        private void LoadDataIndividual()
        {
            customer.Clear();
            string sql = "SELECT * FROM customer WHERE type = 'Individual'";
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string firstname = dr[1].ToString();
                string lastname = dr[2].ToString();
                string company = dr[3].ToString();
                string address = dr[4].ToString();
                string tel = dr[5].ToString();
                string phone = dr[6].ToString();
                string email = dr[7].ToString();
                string type = dr[8].ToString();
                string fullname = firstname + lastname;
                customer.Add(new Customer(id, firstname, lastname, company, address, tel, phone, email, type, fullname));
            }//eloop
        }//ef

        private void LoadDataCompany()
        {
            customer.Clear();
            string sql = "SELECT * FROM customer WHERE type = 'Company'";
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string firstname = dr[1].ToString();
                string lastname = dr[2].ToString();
                string company = dr[3].ToString();
                string address = dr[4].ToString();
                string tel = dr[5].ToString();
                string phone = dr[6].ToString();
                string email = dr[7].ToString();
                string type = dr[8].ToString();
                string fullname = firstname + lastname;
                customer.Add(new Customer(id, firstname, lastname, company, address, tel, phone, email, type, fullname));
            }//eloop
        }//ef


        public void resetData() 
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFirstName2.Text = "";
            txtLastName2.Text = "";
            txtCompany.Text = "";
            txtHousenumber.Text = "";
            txtRoad.Text = "";
            txtDistrict.Text = "";
            txtSubDistrict.Text = "";
            cmbProvince.Text = "";
            txtPostCode.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            cmbProvince.Text = "";
            btnAddUpdate.Text = "Add";
            //lbl
            lblId.Visible = false;
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblCompany.Visible = false;
            lblTel.Visible = false;
            lblEmail.Visible = false;
            lblHousenumber.Visible = false;
            lblRoad.Visible = false;
            lblDistrict.Visible = false;
            lblSubDistrict.Visible = false;
            lblPostalCode.Visible = false;
            lblProvince.Visible = false;
            lblFirstName2.Visible = false;
            lblLastName2.Visible = false;
            lblContact.Visible = false;
            lblPhone.Visible = false;
            //txt
            txtId.Visible = false;
            txtFirstName.Visible = false;
            txtLastName.Visible = false;
            txtCompany.Visible = false;
            txtTel.Visible = false;
            txtEmail.Visible = false;
            txtHousenumber.Visible = false;
            txtRoad.Visible = false;
            txtDistrict.Visible = false;
            txtSubDistrict.Visible = false;
            txtPostCode.Visible = false;
            txtFirstName2.Visible = false;
            txtLastName2.Visible = false;
            txtPhone.Visible = false;
            //btn
            btnExportWhole.Text = "Export All in Excel";
            btnAddUpdate.Visible = false;
            btnReset.Visible = false;
            btnExportWhole.Visible = true;
            btnHistory.Visible = false;
            //cmb
            cmbType.Text = "Customer Type";
            cmbProvince.Visible = false;
        }//ef

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get data from the first column
            if(lstCustomer.SelectedItems.Count > 0)
            {
                string id = lstCustomer.SelectedItems[0].SubItems[0].Text;
                string firstname = lstCustomer.SelectedItems[0].SubItems[1].Text;
                string lastname = lstCustomer.SelectedItems[0].SubItems[2].Text;
                string company = lstCustomer.SelectedItems[0].SubItems[3].Text;
                string address = lstCustomer.SelectedItems[0].SubItems[4].Text;
                string tel = lstCustomer.SelectedItems[0].SubItems[5].Text;
                string phone = lstCustomer.SelectedItems[0].SubItems[6].Text;
                string email = lstCustomer.SelectedItems[0].SubItems[7].Text;
                string type = lstCustomer.SelectedItems[0].SubItems[8].Text;

                string[] addressSplit = address.Split(',');

                txtId.Text = id;
                txtFirstName.Text = firstname;
                txtLastName.Text = lastname;
                txtFirstName2.Text = firstname;
                txtLastName2.Text = lastname;
                txtCompany.Text = company;
                if (addressSplit.Count() == 5)
                {
                    txtHousenumber.Text = addressSplit[0];
                    txtDistrict.Text = addressSplit[1].TrimStart();
                    txtSubDistrict.Text = addressSplit[2].TrimStart();
                    cmbProvince.Text = addressSplit[3].TrimStart();
                    txtPostCode.Text = addressSplit[4].TrimStart();
                }//eif
                else if (addressSplit.Count() == 6)
                {
                    txtHousenumber.Text = addressSplit[0];
                    txtRoad.Text = addressSplit[1].TrimStart();
                    txtDistrict.Text = addressSplit[2].TrimStart();
                    txtSubDistrict.Text = addressSplit[3].TrimStart();
                    cmbProvince.Text = addressSplit[4].TrimStart();
                    txtPostCode.Text = addressSplit[5].TrimStart();
                }//eelse
                txtTel.Text = tel.Replace("-","");
                txtPhone.Text = phone.Replace("-", "");
                txtEmail.Text = email;
                cmbType.Text = type;

                btnAddUpdate.Text = "Edit";
                btnReset.Visible = true;
                btnAddUpdate.Visible = true;
                btnExportWhole.Visible = true;
                btnExportWhole.Text = "Export Individually in Excel";
                btnHistory.Visible = true;
                txtEmail.Visible = true;
                txtTel.Visible = true;
                lblTel.Visible = true;
                lblEmail.Visible = true;
                txtId.Visible = true;
                lblId.Visible = true;
                lblId.Visible = true;
                lblHousenumber.Visible = true;
                lblRoad.Visible = true;
                lblDistrict.Visible = true;
                lblSubDistrict.Visible = true;
                lblPostalCode.Visible = true;
                lblProvince.Visible = true;
                txtHousenumber.Visible = true;
                txtRoad.Visible = true;
                txtDistrict.Visible = true;
                txtSubDistrict.Visible = true;
                txtPostCode.Visible = true;
                cmbProvince.Visible = true;

                if (cmbType.Text == "Individual")
                {
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblCompany.Visible = false;
                    txtFirstName.Visible = true;
                    txtLastName.Visible = true;
                    txtCompany.Visible = false;
                    lblContact.Visible = false;
                    txtPhone.Visible = false;
                    lblPhone.Visible = false;
                    if (addressSplit.Count() == 5)
                    {
                        txtHousenumber.Text = addressSplit[0];
                        txtDistrict.Text = addressSplit[1].TrimStart();
                        txtSubDistrict.Text = addressSplit[2].TrimStart();
                        cmbProvince.Text = addressSplit[3].TrimStart();
                        txtPostCode.Text = addressSplit[4].TrimStart();
                    }//eif
                    else if (addressSplit.Count() == 6)
                    {
                        txtHousenumber.Text = addressSplit[0];
                        txtRoad.Text = addressSplit[1].TrimStart();
                        txtDistrict.Text = addressSplit[2].TrimStart();
                        txtSubDistrict.Text = addressSplit[3].TrimStart();
                        cmbProvince.Text = addressSplit[4].TrimStart();
                        txtPostCode.Text = addressSplit[5].TrimStart();
                    }//eelse
                }//eif
                else if(cmbType.Text == "Company")
                {
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblFirstName2.Visible = true;
                    lblLastName2.Visible = true;
                    lblCompany.Visible = true;
                    txtFirstName.Visible = false;
                    txtLastName.Visible = false;
                    txtFirstName2.Visible = true;
                    txtLastName2.Visible = true;
                    txtCompany.Visible = true;
                    lblContact.Visible = true;
                    txtPhone.Visible = true;
                    lblPhone.Visible = true;
                    if (addressSplit.Count() == 5)
                    {
                        txtHousenumber.Text = addressSplit[0];
                        txtDistrict.Text = addressSplit[1].TrimStart();
                        txtSubDistrict.Text = addressSplit[2].TrimStart();
                        cmbProvince.Text = addressSplit[3].TrimStart();
                        txtPostCode.Text = addressSplit[4].TrimStart();
                    }//eif
                    else if (addressSplit.Count() == 6)
                    {
                        txtHousenumber.Text = addressSplit[0];
                        txtRoad.Text = addressSplit[1].TrimStart();
                        txtDistrict.Text = addressSplit[2].TrimStart();
                        txtSubDistrict.Text = addressSplit[3].TrimStart();
                        cmbProvince.Text = addressSplit[4].TrimStart();
                        txtPostCode.Text = addressSplit[5].TrimStart();
                    }//eelse
                }//eeif
            }//eif
            else
            {
                resetData();
            }
        }//ef

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHousenumber.Visible = true;
            lblRoad.Visible = true;
            lblDistrict.Visible = true;
            lblSubDistrict.Visible = true;
            lblPostalCode.Visible = true;
            lblProvince.Visible = true;
            txtHousenumber.Visible = true;
            txtRoad.Visible = true;
            txtDistrict.Visible = true;
            txtSubDistrict.Visible = true;
            txtPostCode.Visible = true;
            cmbProvince.Visible = true;
            lblId.Visible = false;
            lblTel.Visible = true;
            lblEmail.Visible = true;
            txtId.Visible = false;
            txtTel.Visible = true;
            txtEmail.Visible = true;
            btnAddUpdate.Visible = true;
            btnReset.Visible = true;

            if (btnAddUpdate.Text == "Add")
            {
                if (cmbType.SelectedIndex == 0)
                {
                    txtCompany.Text = "";
                    txtFirstName2.Text = "";
                    txtLastName2.Text = "";
                    txtPhone.Text = "";
                    lblFirstName2.Visible = false;
                    lblLastName2.Visible = false;
                    txtFirstName2.Visible = false;
                    txtLastName2.Visible = false;
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblCompany.Visible = false;
                    txtFirstName.Visible = true;
                    txtLastName.Visible = true;
                    txtCompany.Visible = false;
                    lblContact.Visible = false;
                    txtPhone.Visible = false;
                    lblPhone.Visible = false;
                    cmbProvince.SelectedIndex = -1;
                }//eif
                else if (cmbType.SelectedIndex == 1)
                {
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblFirstName2.Visible = true;
                    lblLastName2.Visible = true;
                    lblCompany.Visible = true;
                    txtFirstName.Visible = false;
                    txtLastName.Visible = false;
                    txtCompany.Visible = true;
                    txtFirstName2.Visible = true;
                    txtLastName2.Visible = true;
                    lblContact.Visible = true;
                    txtPhone.Visible = true;
                    lblPhone.Visible = true;
                }//eeif
            }//eif
            else if(btnAddUpdate.Text == "Edit")
            {
                if (cmbType.SelectedIndex == 0)
                {
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblCompany.Visible = false;
                    txtFirstName.Visible = true;
                    txtLastName.Visible = true;
                    txtCompany.Visible = false;
                    lblContact.Visible = false;
                    lblFirstName2.Visible = false;
                    lblLastName2.Visible = false;
                    txtFirstName2.Visible = false;
                    txtLastName2.Visible = false;
                    txtPhone.Visible = false;
                    lblPhone.Visible = false;
                }//eif
                else if (cmbType.SelectedIndex == 1)
                {
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblFirstName2.Visible = true;
                    lblLastName2.Visible = true;
                    lblCompany.Visible = true;
                    txtFirstName.Visible = false;
                    txtLastName.Visible = false;
                    txtCompany.Visible = true;
                    txtFirstName2.Visible = true;
                    txtLastName2.Visible = true;
                    lblContact.Visible = true;
                    txtPhone.Visible = true;
                    lblPhone.Visible = true;
                }//eeif
            }//eeif
        }//ef

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();    
        }//ef

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                new MailAddress(txtEmail.Text);
                string id = txtId.Text;
                string firstname = txtFirstName.Text;
                string lastname = txtLastName.Text;
                string firstname2 = txtFirstName2.Text;
                string lastname2 = txtLastName2.Text;
                string company = txtCompany.Text;
                string address;
                if (String.IsNullOrEmpty(txtRoad.Text))
                {
                    address = txtHousenumber.Text + ", " + txtDistrict.Text + ", " + txtSubDistrict.Text + ", " + cmbProvince.Text + ", " + txtPostCode.Text;
                }
                else
                {
                    address = txtHousenumber.Text + ", " + txtRoad.Text + ", " + txtDistrict.Text + ", " + txtSubDistrict.Text + ", " + cmbProvince.Text + ", " + txtPostCode.Text;
                }
                int tel = Int32.Parse(txtTel.Text);
                string formatTel = "";
                if (txtTel.Text.Length == 10)
                {
                    formatTel = tel.ToString("0##-###-####");
                }//eif
                else if (txtTel.Text.Length == 9)
                {
                    formatTel = tel.ToString("0#-###-####");
                }//eelse
                int phone = 0;
                if (txtPhone.Text == "")
                {

                }
                else
                {
                    phone = Int32.Parse(txtPhone.Text);
                }
                string email = txtEmail.Text;
                string type = cmbType.Text;
                string empty = "";
                MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo);
                if (confirmResult == MessageBoxResult.Yes)
                {
                    if (btnAddUpdate.Text == "Add")
                    {
                        if (cmbType.SelectedIndex == 0) //Individual
                        {
                            //sql insertion string
                            string insert = "INSERT INTO customer(id,firstname,lastname,company,address,tel,phonenumber,email,type)";
                            insert += "value(null,'a1','a2','a3','a4','a5','a6','a7','a8')";
                            insert = insert.Replace("a1", firstname);
                            insert = insert.Replace("a2", lastname);
                            insert = insert.Replace("a3", company);
                            insert = insert.Replace("a4", address);
                            insert = insert.Replace("a5", formatTel);
                            insert = insert.Replace("a6", empty);
                            insert = insert.Replace("a7", email);
                            insert = insert.Replace("a8", type);
                            //MessageBox.Show(insert);
                            m1.ExecuteQuery(insert);
                            MessageBox.Show("New customer has been added.");
                            LoadDataAll();
                            refreshAll();
                            resetData();
                        }//eif
                        else if (cmbType.SelectedIndex == 1) //Company
                        {
                            firstname = txtFirstName2.Text;
                            lastname = txtLastName2.Text;
                            //sql update string
                            string insert = "INSERT INTO customer(id,firstname,lastname,company,address,tel,phonenumber,email,type)";
                            insert += "value(null,'a1','a2','a3','a4','a5','a6','a7','a8')";
                            insert = insert.Replace("a1", firstname);
                            insert = insert.Replace("a2", lastname);
                            insert = insert.Replace("a3", company);
                            insert = insert.Replace("a4", address);
                            insert = insert.Replace("a5", formatTel);
                            insert = insert.Replace("a6", phone.ToString("0##-###-####"));
                            insert = insert.Replace("a7", email);
                            insert = insert.Replace("a8", type);
                            //MessageBox.Show(insert);
                            m1.ExecuteQuery(insert);
                            MessageBox.Show("New customer has been added.");
                            LoadDataAll();
                            refreshAll();
                            resetData();
                        }//eief
                    }//eif
                    else if (btnAddUpdate.Text == "Edit")
                    {
                        if (cmbType.SelectedIndex == 0) //Individual
                        {
                            //sql update string
                            string update = "UPDATE customer SET firstname = 'b1',lastname = 'b2',company = 'b3', address = 'b4', tel = 'b5', phonenumber = 'b6',email = 'b7', type = 'b8' WHERE id = 'b0'";
                            update = update.Replace("b1", firstname);
                            update = update.Replace("b2", lastname);
                            update = update.Replace("b3", txtCompany.Text = "");
                            update = update.Replace("b4", address);
                            update = update.Replace("b5", formatTel);
                            update = update.Replace("b6", empty);
                            update = update.Replace("b7", email);
                            update = update.Replace("b8", type);
                            update = update.Replace("b0", id);
                            //MessageBox.Show(update);
                            m1.ExecuteQuery(update);
                            MessageBox.Show("Customer information has been updated.");
                            LoadDataAll();
                            refreshAll();
                            resetData();
                        }//eif
                        else if (cmbType.SelectedIndex == 1) //Company
                        {
                            firstname = txtFirstName2.Text;
                            lastname = txtLastName2.Text;
                            //sql update string
                            string update = "UPDATE customer SET firstname = 'b1',lastname = 'b2',company = 'b3', address = 'b4', tel = 'b5', phonenumber = 'b6',email = 'b7', type = 'b8' WHERE id = 'b0'";
                            update = update.Replace("b1", firstname);
                            update = update.Replace("b2", lastname);
                            update = update.Replace("b3", company);
                            update = update.Replace("b4", address);
                            update = update.Replace("b5", formatTel);
                            update = update.Replace("b6", phone.ToString("0##-###-####"));
                            update = update.Replace("b7", email);
                            update = update.Replace("b8", type);
                            update = update.Replace("b0", id);
                            //MessageBox.Show(update);
                            m1.ExecuteQuery(update);
                            MessageBox.Show("Customer information has been updated.");
                            LoadDataAll();
                            refreshAll();
                            resetData();
                        }//eief
                    }//eeif
                }//eeif
                else
                {
                    // If 'No', do something here.
                }//eelse
            }
            catch (FormatException)
            {
                MessageBox.Show("Email format, phone number, or telephone number is invalid");
            }
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            btnIndividual.Visible = false;
            btnCompany.Visible = true;
            btnAll1.Visible = true;
            btnAll2.Visible = false;
            LoadDataIndividual();
            refreshAll();
            resetData();
        }//ef

        private void btnCompany_Click(object sender, EventArgs e)
        {
            btnIndividual.Visible = true;
            btnCompany.Visible = false;
            btnAll1.Visible = false;
            btnAll2.Visible = true;
            LoadDataCompany();
            refreshAll();
            resetData();
        }//ef

        private void btnAll1_Click(object sender, EventArgs e)
        {
            btnIndividual.Visible = true;
            btnCompany.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnAll2_Click(object sender, EventArgs e)
        {
            btnIndividual.Visible = true;
            btnCompany.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            LoadDataAll();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            refreshAll();
            resetData();
        }//ef

        private void btnExportWhole_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true})
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (btnExportWhole.Text == "Export All in Excel")
                    {
                        Excel.Application app = new Excel.Application();
                        Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                        Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        ws.Cells[1, 1] = "Customer ID";
                        ws.Cells[1, 2] = "First Name";
                        ws.Cells[1, 3] = "Last Name";
                        ws.Cells[1, 4] = "Company";
                        ws.Cells[1, 5] = "Address";
                        ws.Cells[1, 6] = "Tel";
                        ws.Cells[1, 7] = "Phone number";
                        ws.Cells[1, 8] = "Email";
                        int i = 2;
                        foreach (ListViewItem items in lstCustomer.Items)
                        {
                            ws.Cells[i, 1] = items.SubItems[0].Text;
                            ws.Cells[i, 2] = items.SubItems[1].Text;
                            ws.Cells[i, 3] = items.SubItems[2].Text;
                            ws.Cells[i, 4] = items.SubItems[3].Text;
                            ws.Cells[i, 5] = items.SubItems[4].Text;
                            ws.Cells[i, 6] = items.SubItems[5].Text;
                            ws.Cells[i, 7] = items.SubItems[6].Text;
                            ws.Cells[i, 8] = items.SubItems[7].Text;
                            i++;
                        }//eloop
                        wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                    }//eif
                    else if (btnExportWhole.Text == "Export Individually in Excel")
                    {
                        if (cmbType.Text == "Company")
                        {
                            Excel.Application app = new Excel.Application();
                            Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                            Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                            app.Visible = false;
                            ws.Cells[1, 1] = "Customer ID";
                            ws.Cells[1, 2] = "First Name";
                            ws.Cells[1, 3] = "Last Name";
                            ws.Cells[1, 4] = "Company";
                            ws.Cells[1, 5] = "Address";
                            ws.Cells[1, 6] = "Tel";
                            ws.Cells[1, 7] = "Phone number";
                            ws.Cells[1, 8] = "Email";
                            int i = 2;
                            ws.Cells[i, 1] = txtId.Text;
                            ws.Cells[i, 2] = txtFirstName2.Text;
                            ws.Cells[i, 3] = txtLastName2.Text;
                            ws.Cells[i, 4] = txtCompany.Text;
                            if (String.IsNullOrEmpty(txtRoad.Text))
                            {
                                ws.Cells[i, 5] = txtHousenumber.Text + ", " + txtDistrict.Text + ", " + txtSubDistrict.Text + ", " + cmbProvince.Text + ", " + txtPostCode.Text;
                            }//eif
                            else
                            {
                                ws.Cells[i, 5] = txtHousenumber.Text + ", " + txtRoad.Text + ", " + txtDistrict.Text + ", " + txtSubDistrict.Text + ", " + cmbProvince.Text + ", " + txtPostCode.Text;
                            }//eelse
                            ws.Cells[i, 6] = "\t" + txtTel.Text;
                            ws.Cells[i, 7] = "\t" + txtPhone.Text;
                            ws.Cells[i, 8] = txtEmail.Text;
                            wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                            app.Quit();
                        }//ef
                        else
                        {
                            Excel.Application app = new Excel.Application();
                            Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                            Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                            app.Visible = false;
                            ws.Cells[1, 1] = "Customer ID";
                            ws.Cells[1, 2] = "First Name";
                            ws.Cells[1, 3] = "Last Name";
                            ws.Cells[1, 4] = "Address";
                            ws.Cells[1, 5] = "Tel";
                            ws.Cells[1, 6] = "Email";
                            int i = 2;
                            ws.Cells[i, 1] = txtId.Text;
                            ws.Cells[i, 2] = txtFirstName.Text;
                            ws.Cells[i, 3] = txtLastName.Text;
                            if (String.IsNullOrEmpty(txtRoad.Text))
                            {
                                ws.Cells[i, 4] = txtHousenumber.Text + ", " + txtDistrict.Text + ", " + txtSubDistrict.Text + ", " + cmbProvince.Text + ", " + txtPostCode.Text;
                            }//eif
                            else
                            {
                                ws.Cells[i, 4] = txtHousenumber.Text + ", " + txtRoad.Text + ", " + txtDistrict.Text + ", " + txtSubDistrict.Text + ", " + cmbProvince.Text + ", " + txtPostCode.Text;
                            }//eelse
                            ws.Cells[i, 5] = "\t" + txtTel.Text;
                            ws.Cells[i, 6] = txtEmail.Text;
                            wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                            app.Quit();
                        }//eelse
                    }//eif
                    MessageBox.Show("Succesffuly exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//eif
            }//eusing
        }//ef

        private void btnHistory_Click(object sender, EventArgs e)
        {
            string customerid = "";
            if (String.IsNullOrEmpty(txtCompany.Text))
            {
                customerid = txtId.Text + " - " + txtFirstName.Text + " " + txtLastName.Text;
            }//eif
            else
            {
                customerid = txtId.Text + " - " + txtCompany.Text;
            }//eelse
            FormCusHistory formcushistory = new FormCusHistory(customerid);
            formcushistory.ShowDialog();
        }//ef
    }//ec
}//en
