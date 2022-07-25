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
    public partial class FormMaintenance : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of sales
        List<Maintenance> maintenances = new List<Maintenance>();
        
        public FormMaintenance()
        {
            InitializeComponent();
        }//ef

        private void FormMaintenance_Load(object sender, EventArgs e)
        {
            LoadService();

            LoadDataAll();

            refreshAll();

            resetData();
        }//ef

        private void LoadDataAll()
        {
            maintenances.Clear();
            string sql = "SELECT * FROM maintenance ORDER BY request_date DESC";
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

        private void LoadDataAllAsc()
        {
            maintenances.Clear();
            string sql = "SELECT * FROM maintenance ORDER BY request_date ASC";
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

        private void LoadDataAllProc()
        {
            maintenances.Clear();
            string sql = "SELECT * FROM maintenance WHERE status = 'Processing'";
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

        private void LoadDataAllOng()
        {
            maintenances.Clear();
            string sql = "SELECT * FROM maintenance WHERE status = 'Ongoing'";
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

        private void LoadDataAllComp()
        {
            maintenances.Clear();
            string sql = "SELECT * FROM maintenance WHERE status = 'Completed'";
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

        private void LoadService()
        {
            string sql = "SELECT id, description FROM service";
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string description = dr[1].ToString();
                string service = id + " - " + description;
                cmbService.Items.Add(service);
            }//eloop
        }//ef

        private void refreshAll()
        {
            string search = txtSearch.Text.Replace(" ", "").ToLower();
            List<Maintenance> searchMaintenance;
            if (search.Trim() != "")
            {
                searchMaintenance = maintenances.Where(x => x.id.ToString().Contains(search)
                || x.service.ToString().ToLower().Contains(search)).ToList();
            }//eif
            else
            {
                searchMaintenance = maintenances;
            }//eelse
            ShowInListView(searchMaintenance);
        }//ef

        private void ShowInListView(List<Maintenance> searchMaintenance)
        {
            lstMaintenance.Items.Clear();
            foreach (Maintenance maintenances in searchMaintenance)
            {
                ListViewItem nr = new ListViewItem(maintenances.id.ToString());
                nr.SubItems.Add(maintenances.service);
                nr.SubItems.Add(maintenances.problem);
                nr.SubItems.Add(maintenances.status);
                nr.SubItems.Add(maintenances.request_date);

                lstMaintenance.Items.Add(nr);
            }//eloop
        }//ef

        public void resetData()
        {
            txtId.Text = "";
            txtProblem.Text = "";
            cmbStatus.SelectedIndex = -1;
            cmbService.SelectedIndex = -1;
            cmbService.Text = "Select Service";
            btnAddUpdate.Text = "Add";
            btnExport.Text = "Export All in Excel";
            txtId.Visible = false;
            lblId.Visible = false;
            btnReset.Visible = false;
            btnExport.Visible = true;
            btnHistory.Visible = false;
            txtProblem.Visible = false;
            lblProblem.Visible = false;
            lblStatus.Visible = false;
            cmbStatus.Visible = false;
            dateTime.Visible = false;
            lblDate.Visible = false;
            btnAddUpdate.Visible = false;
            dateTime.Value = DateTime.Now;
            cmbStatus.Text = "Processing";
        }//ef

        private void lstMaintenance_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstMaintenance.SelectedItems.Count > 0)
            {
                string id = lstMaintenance.SelectedItems[0].SubItems[0].Text;
                string service = lstMaintenance.SelectedItems[0].SubItems[1].Text;
                string problem = lstMaintenance.SelectedItems[0].SubItems[2].Text;
                string status = lstMaintenance.SelectedItems[0].SubItems[3].Text;
                string request_date = lstMaintenance.SelectedItems[0].SubItems[4].Text;

                txtId.Text = id;
                cmbService.Text = service;
                txtProblem.Text = problem;
                cmbStatus.Text = status;
                dateTime.Text = request_date;

                btnAddUpdate.Text = "Update";
                btnExport.Text = "Export Individually in Excel";
                btnHistory.Visible = true;
                btnExport.Visible = true;
                btnReset.Visible = true;
                txtId.Visible = true;
                lblId.Visible = true;
                txtProblem.Visible = true;
                lblProblem.Visible = true;
                lblStatus.Visible = true;
                cmbStatus.Visible = true;
                dateTime.Visible = true;
                lblDate.Visible = true;
                btnAddUpdate.Visible = true;
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
            string service = cmbService.Text;
            string problem = txtProblem.Text.Replace("'", "''");
            string status = cmbStatus.Text;
            string request_date = dateTime.Value.ToString("yyyy-MM-dd");

            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo);
            if (confirmResult == MessageBoxResult.Yes)
            {
                if (btnAddUpdate.Text == "Add")
                {
                    //sql insertion string
                    string insert = "INSERT INTO maintenance(id,service,problem,status,request_date)";
                    insert += "value(null,'a1','a2','a3','a4')";
                    insert = insert.Replace("a1", service);
                    insert = insert.Replace("a2", problem);
                    insert = insert.Replace("a3", status);
                    insert = insert.Replace("a4", request_date);
                    //MessageBox.Show(insert);
                    m1.ExecuteQuery(insert);
                    MessageBox.Show("New maintenance has been added.");
                    LoadDataAll();
                    refreshAll();
                    resetData();
                }//eif
                else if (btnAddUpdate.Text == "Update")
                {
                    //sql update string
                    string update = "UPDATE maintenance SET service = 'b1',problem = 'b2',status = 'b3',request_date = 'b4' WHERE id = 'b0'";
                    update = update.Replace("b1", service);
                    update = update.Replace("b2", problem);
                    update = update.Replace("b3", status);
                    update = update.Replace("b4", request_date);
                    update = update.Replace("b0", id);
                    //MessageBox.Show(update);
                    m1.ExecuteQuery(update);
                    MessageBox.Show("Maintenance information has been updated.");
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }//ef

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            refreshAll();
            resetData();
        }//ef

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            txtProblem.Visible = true;
            lblProblem.Visible = true;
            lblStatus.Visible = true;
            cmbStatus.Visible = true;
            dateTime.Visible = true;
            lblDate.Visible = true;
            btnAddUpdate.Visible = true;
            cmbStatus.Text = "Processing";
        }//ef

        private void btnAll1_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnOng.Visible = true;
            btnComp.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            btnAll3.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnAll2_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnOng.Visible = true;
            btnComp.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            btnAll3.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnAll3_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnOng.Visible = true;
            btnComp.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            btnAll3.Visible = false;
            LoadDataAll();
            refreshAll();
            resetData();
        }//ef

        private void btnProc_Click(object sender, EventArgs e)
        {
            btnProc.Visible = false;
            btnOng.Visible = true;
            btnComp.Visible = true;
            btnAll1.Visible = true;
            btnAll2.Visible = false;
            btnAll3.Visible = false;
            LoadDataAllProc();
            refreshAll();
            resetData();
        }//ef

        private void btnOng_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnOng.Visible = false;
            btnComp.Visible = true;
            btnAll1.Visible = false;
            btnAll2.Visible = true;
            btnAll3.Visible = false;
            LoadDataAllOng();
            refreshAll();
            resetData();
        }//ef

        private void btnComp_Click(object sender, EventArgs e)
        {
            btnProc.Visible = true;
            btnOng.Visible = true;
            btnComp.Visible = false;
            btnAll1.Visible = false;
            btnAll2.Visible = false;
            btnAll3.Visible = true;
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
                        ws.Cells[1, 2] = "Service";
                        ws.Cells[1, 3] = "Problem";
                        ws.Cells[1, 4] = "Status";
                        ws.Cells[1, 5] = "Request Date";
                        int i = 2;
                        foreach (ListViewItem items in lstMaintenance.Items)
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
                        ws.Cells[1, 2] = "Service";
                        ws.Cells[1, 3] = "Problem";
                        ws.Cells[1, 4] = "Status";
                        ws.Cells[1, 5] = "Request Date";
                        int i = 2;
                        ws.Cells[i, 1] = txtId.Text;
                        ws.Cells[i, 2] = cmbService.Text;
                        ws.Cells[i, 3] = txtProblem.Text;
                        ws.Cells[i, 4] = cmbStatus.Text;
                        ws.Cells[i, 5] = dateTime.Text;
                        wb.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                    }//eif
                    MessageBox.Show("Succesffuly exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//eif
            }//eusing
        }//ef

        private void btnHistory_Click(object sender, EventArgs e)
        {
            string serviceid = cmbService.Text;
            FormMTNHistory formbtnhistory = new FormMTNHistory(cmbService.Text);
            formbtnhistory.ShowDialog();
        }//ef
    }//ec
}//en
