using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MessageBox = System.Windows.Forms.MessageBox;

namespace pms
{
    public partial class FormSupplier : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of customers
        List<Supplier> suppliers = new List<Supplier>();
        public FormSupplier()
        {
            InitializeComponent();
        }//ef

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            LoadDataAll();

            refreshAll();

            resetData();
        }//ef

        private void LoadDataAll()
        {
            suppliers.Clear();
            string sql = "SELECT * FROM supplier ORDER BY id DESC";
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string name = dr[1].ToString();
                string address = dr[2].ToString();
                string tel = dr[3].ToString();
                string email = dr[4].ToString();
                string type = dr[5].ToString();
                suppliers.Add(new Supplier(id, name, address, tel, email, type));
            }//eloop
        }//ef

        private void refreshAll()
        {
            string search = txtSearch.Text.Replace(" ", "").ToLower();
            List<Supplier> searchSupplier;
            if (search.Trim() != "")
            {
                searchSupplier = suppliers.Where(x => x.id.ToString().Contains(search)
                || x.name.ToString().ToLower().Contains(search)
                || x.tel.Contains(search)
                || x.email.ToLower().Contains(search)
                || x.type.ToLower().Contains(search)).ToList();
            }
            else
            {
                searchSupplier = suppliers;
            }
            ShowInListView(searchSupplier);
        }//ef

        private void ShowInListView(List<Supplier> searchSupplier)
        {
            lstSupplier.Items.Clear();
            foreach (Supplier suppliers in searchSupplier)
            {
                ListViewItem nr = new ListViewItem(suppliers.id.ToString());
                nr.SubItems.Add(suppliers.name);
                nr.SubItems.Add(suppliers.address);
                nr.SubItems.Add(suppliers.tel);
                nr.SubItems.Add(suppliers.email);
                nr.SubItems.Add(suppliers.type);

                lstSupplier.Items.Add(nr);
            }//eloop
        }//ef

        public void resetData()
        {
            //lbl
            lblId.Visible = false;
            lblSupName.Visible = false;
            lblTel.Visible = false;
            lblEmail.Visible = false;
            lblHousenumber.Visible = false;
            lblRoad.Visible = false;
            lblDistrict.Visible = false;
            lblSubDistrict.Visible = false;
            lblPostalCode.Visible = false;
            lblProvince.Visible = false;
            //txt
            txtId.Visible = false;
            txtSupplier.Visible = false;
            txtTel.Visible = false;
            txtEmail.Visible = false;
            txtHousenumber.Visible = false;
            txtRoad.Visible = false;
            txtDistrict.Visible = false;
            txtSubDistrict.Visible = false;
            txtPostCode.Visible = false;
            //btn
            btnExport.Visible = true;
            btnExport.Text = "Export All in Excel";
            btnReset.Visible = false;
            btnAddUpdate.Visible = false;
            btnAddUpdate.Text = "Add";
            //cmb
            cmbType.Text = "Supplier Type";
            cmbProvince.Visible = false;
        }//ef

        public void resetText()
        {
            txtId.Text = "";
            txtSupplier.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            txtHousenumber.Text = "";
            txtRoad.Text = "";
            txtDistrict.Text = "";
            txtSubDistrict.Text = "";
            txtPostCode.Text = "";
            cmbProvince.SelectedIndex = -1;
        }

        private void lstSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get data from the first column
            if (lstSupplier.SelectedItems.Count > 0)
            {
                string id = lstSupplier.SelectedItems[0].SubItems[0].Text;
                string name = lstSupplier.SelectedItems[0].SubItems[1].Text;
                string address = lstSupplier.SelectedItems[0].SubItems[2].Text;
                string tel = lstSupplier.SelectedItems[0].SubItems[3].Text;
                string email = lstSupplier.SelectedItems[0].SubItems[4].Text;
                string type = lstSupplier.SelectedItems[0].SubItems[5].Text;

                string[] addressSplit = address.Split(',');
                
                txtId.Text = id;
                txtSupplier.Text = name;
                if (addressSplit.Count() == 6)
                {
                    txtHousenumber.Text = addressSplit[0];
                    txtRoad.Text = addressSplit[1].TrimStart();
                    txtDistrict.Text = addressSplit[2].TrimStart();
                    txtSubDistrict.Text = addressSplit[3].TrimStart();
                    cmbProvince.Text = addressSplit[4].TrimStart();
                    txtPostCode.Text = addressSplit[5].TrimStart();
                }//eif
                else if (addressSplit.Count() == 5)
                {
                    txtHousenumber.Text = addressSplit[0];
                    txtDistrict.Text = addressSplit[1].TrimStart();
                    txtSubDistrict.Text = addressSplit[2].TrimStart();
                    cmbProvince.Text = addressSplit[3].TrimStart();
                    txtPostCode.Text = addressSplit[4].TrimStart();
                }//eelse
                txtTel.Text = tel.Replace("-", "");
                txtEmail.Text = email;
                cmbType.Text = type;

                btnExport.Text = "Export Individually in Excel";
                btnAddUpdate.Visible = true;
                btnAddUpdate.Text = "Edit";
                btnReset.Visible = true;
                btnExport.Visible = true;
                lblId.Visible = true;
                lblSupName.Visible = true;
                lblTel.Visible = true;
                lblEmail.Visible = true;
                lblHousenumber.Visible = true;
                lblRoad.Visible = true;
                lblDistrict.Visible = true;
                lblSubDistrict.Visible = true;
                lblPostalCode.Visible = true;
                lblProvince.Visible = true;
                txtId.Visible = true;
                txtSupplier.Visible = true;
                txtTel.Visible = true;
                txtEmail.Visible = true;
                txtHousenumber.Visible = true;
                txtRoad.Visible = true;
                txtDistrict.Visible = true;
                txtSubDistrict.Visible = true;
                txtPostCode.Visible = true;
                cmbProvince.Visible = true;
            }//eif
            else
            {
                resetData();
                resetText();
            }//eelse
        }//ef

        private void LoadDataAllAsc()
        {
            suppliers.Clear();
            string sql = "SELECT * FROM supplier ORDER BY id ASC";
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string name = dr[1].ToString();
                string address = dr[2].ToString();
                string tel = dr[3].ToString();
                string email = dr[4].ToString();
                string type = dr[5].ToString();
                suppliers.Add(new Supplier(id, name, address, tel, email, type));
            }//eloop
        }//ef

        private void LoadDataAllMaterial()
        {
            suppliers.Clear();
            string sql = "SELECT * FROM supplier WHERE type = 'Material'";
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string name = dr[1].ToString();
                string address = dr[2].ToString();
                string tel = dr[3].ToString();
                string email = dr[4].ToString();
                string type = dr[5].ToString();
                suppliers.Add(new Supplier(id, name, address, tel, email, type));
            }//eloop
        }//ef

        private void LoadDataAllMachine()
        {
            suppliers.Clear();
            string sql = "SELECT * FROM supplier WHERE type = 'Machine'";
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string name = dr[1].ToString();
                string address = dr[2].ToString();
                string tel = dr[3].ToString();
                string email = dr[4].ToString();
                string type = dr[5].ToString();
                suppliers.Add(new Supplier(id, name, address, tel, email, type));
            }//eloop
        }//ef

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                new MailAddress(txtEmail.Text);
                string id = txtId.Text;
                string name = txtSupplier.Text;
                string address;
                if (String.IsNullOrEmpty(txtRoad.Text))
                {
                    address = txtHousenumber.Text + ", " + txtDistrict.Text + ", " + txtSubDistrict.Text + ", " + cmbProvince.Text + ", " + txtPostCode.Text;
                }
                else
                {
                    address = txtHousenumber.Text + ", " + txtRoad.Text + ", " + txtDistrict.Text + ", " + txtSubDistrict.Text + ", " + cmbProvince.Text + ", " + txtPostCode.Text;
                }
                int tel = 0;
                if (txtTel.Text == "")
                {

                }
                else
                {
                    tel = Int32.Parse(txtTel.Text);
                }
                string email = txtEmail.Text;
                string type = cmbType.Text;

                MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo);
                if (confirmResult == MessageBoxResult.Yes)
                {
                    if (btnAddUpdate.Text == "Add")
                    {
                        //sql insertion string
                        string insert = "INSERT INTO supplier(id,name,address,tel,email,type)";
                        insert += "value(null,'a1','a2','a3','a4','a5')";
                        insert = insert.Replace("a1", name);
                        insert = insert.Replace("a2", address);
                        insert = insert.Replace("a3", tel.ToString("0#-###-####"));
                        insert = insert.Replace("a4", email);
                        insert = insert.Replace("a5", type);
                        //MessageBox.Show(insert);
                        m1.ExecuteQuery(insert);
                        MessageBox.Show("New supplier has been added.");
                        LoadDataAll();
                        refreshAll();
                        //resetData();
                    }//eif
                    else if (btnAddUpdate.Text == "Edit")
                    {
                        //sql update string
                        string update = "UPDATE supplier SET name = 'b1',address = 'b2',tel = 'b3',email = 'b4', type ='b5' WHERE id = 'b0'";
                        update = update.Replace("b1", name);
                        update = update.Replace("b2", address);
                        update = update.Replace("b3", tel.ToString("0#-###-####"));
                        update = update.Replace("b4", email);
                        update = update.Replace("b5", type);
                        update = update.Replace("b0", id);
                        //MessageBox.Show(update);
                        m1.ExecuteQuery(update);
                        MessageBox.Show("Supplier information has been updated.");
                        LoadDataAll();
                        refreshAll();
                        //resetData();
                    }//eeif
                }//eeif
                else
                {
                    // If 'No', do something here.
                }//eelse
            }
            /*catch (Exception)
            {
                int tel;
                if (!int.TryParse(txtTel.Text, out tel))
                    MessageBox.Show("Please enter only number for phone number or telephone number");
                if (!txtEmail.Text.Contains("@"))
                    MessageBox.Show("Email should be in email format");
            }//ecatch*/
            catch (FormatException)
            {
                MessageBox.Show("Email format, phone number, or telephone number is invalid");
            }
        }//ef

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSupName.Visible = true;
            lblTel.Visible = true;
            lblEmail.Visible = true;
            lblHousenumber.Visible = true;
            lblRoad.Visible = true;
            lblDistrict.Visible = true;
            lblSubDistrict.Visible = true;
            lblPostalCode.Visible = true;
            lblProvince.Visible = true;
            txtSupplier.Visible = true;
            txtTel.Visible = true;
            txtEmail.Visible = true;
            txtHousenumber.Visible = true;
            txtRoad.Visible = true;
            txtDistrict.Visible = true;
            txtSubDistrict.Visible = true;
            txtPostCode.Visible = true;
            cmbProvince.Visible = true;
            btnReset.Visible = true;
            btnAddUpdate.Visible = true;
        }//ef

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
            resetText();
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnAll2_Click(object sender, EventArgs e)
        {
            btnMachine.Visible = true;
            btnMaterial.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnAll1_Click(object sender, EventArgs e)
        {
            btnMachine.Visible = true;
            btnMaterial.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            btnMachine.Visible = true;
            btnMaterial.Visible = false;
            btnAll1.Visible = false;
            btnAll2.Visible = true;
            LoadDataAllMaterial();
            refreshAll();
            resetData();
        }//ef

        private void btnMachine_Click(object sender, EventArgs e)
        {
            btnMachine.Visible = false;
            btnMaterial.Visible = true;
            btnAll1.Visible = true;
            btnAll2.Visible = false;
            LoadDataAllMachine();
            refreshAll();
            resetData();
        }//ef

        private void btnSort_Click(object sender, EventArgs e)
        {
            btnSort.Visible = false;
            btnSortOldest.Visible = true;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnSortOldest_Click(object sender, EventArgs e)
        {
            btnSort.Visible = true;
            btnSortOldest.Visible = false;
            LoadDataAllAsc();
            refreshAll();
            resetData();
        }//ef

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
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
                        ws.Cells[1, 1] = "Customer ID";
                        ws.Cells[1, 2] = "Supplier Name";
                        ws.Cells[1, 3] = "Address";
                        ws.Cells[1, 4] = "Tel";
                        ws.Cells[1, 5] = "Email";
                        ws.Cells[1, 6] = "Type";
                        int i = 2;
                        foreach (ListViewItem items in lstSupplier.Items)
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
                    }//eif
                    else if (btnExport.Text == "Export Individually in Excel")
                    {
                        Excel.Application app = new Excel.Application();
                        Excel.Workbook wb = app.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                        Excel.Worksheet ws = (Excel.Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        ws.Cells[1, 1] = "Customer ID";
                        ws.Cells[1, 2] = "Supplier Name";
                        ws.Cells[1, 3] = "Address";
                        ws.Cells[1, 4] = "Tel";
                        ws.Cells[1, 5] = "Email";
                        ws.Cells[1, 6] = "Type";
                        int i = 2;
                        ws.Cells[i, 1] = txtId.Text;
                        ws.Cells[i, 2] = txtSupplier.Text;
                        if (String.IsNullOrEmpty(txtRoad.Text))
                        {
                            ws.Cells[i, 3] = txtHousenumber.Text + ", " + txtDistrict.Text + ", " + txtSubDistrict.Text + ", " + cmbProvince.Text + ", " + txtPostCode.Text;
                        }//eif
                        else
                        {
                            ws.Cells[i, 3] = txtHousenumber.Text + ", " + txtRoad.Text + ", " + txtDistrict.Text + ", " + txtSubDistrict.Text + ", " + cmbProvince.Text + ", " + txtPostCode.Text;
                        }//eelse
                        ws.Cells[i, 4] = "\t" + txtTel.Text;
                        ws.Cells[i, 5] = txtEmail.Text;
                        ws.Cells[i, 6] = cmbType.Text;
                        wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                    }//eif
                    MessageBox.Show("Succesffuly exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//eif
            }//eusing
        }//ef
    }//ec
}//en


