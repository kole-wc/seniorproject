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
    public partial class FormReportHPS : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of highest paid
        List<HighestPaid> highestpaids = new List<HighestPaid>();
        public FormReportHPS()
        {
            InitializeComponent();
        }//.ef

        private void FormReportHPS_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowInListView();
            dateTime.Format = DateTimePickerFormat.Custom;
            //dateTime.ShowUpDown = true;
            lstHPS.Columns[0].TextAlign = HorizontalAlignment.Right;
        }//ef

        private void LoadData()
        {
            highestpaids.Clear();
            string sql = "SELECT id, type, customer, amount, startdate FROM service WHERE startdate BETWEEN 'd1' AND 'd2' ORDER BY amount DESC;";
            if (dateTime.Value.Month.ToString().Length == 1)
            {
                sql = sql.Replace("d1", dateTime.Value.Year.ToString() + "-0" + dateTime.Value.Month.ToString() + "-01");
                sql = sql.Replace("d2", dateTime.Value.Year.ToString() + "-0" + dateTime.Value.Month.ToString() + "-31");
            }//eif
            else
            {
                sql = sql.Replace("d1", dateTime.Value.Year.ToString() + "-" + dateTime.Value.Month.ToString() + "-01");
                sql = sql.Replace("d2", dateTime.Value.Year.ToString() + "-" + dateTime.Value.Month.ToString() + "-31");
            }
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string type = dr[1].ToString();
                string customer = dr[2].ToString();
                double amount = double.Parse(dr[3].ToString());
                string date = dr[4].ToString();
                highestpaids.Add(new HighestPaid(id, customer, type, amount, date));
            }//eloop
        }//ef

        private void ShowInListView()
        {
            string empty = "";
            lstHPS.Items.Clear();
            foreach (HighestPaid highestpaids in highestpaids)
            {
                ListViewItem nr = new ListViewItem(empty);
                nr.SubItems.Add(highestpaids.id.ToString());
                nr.SubItems.Add(highestpaids.customer);
                nr.SubItems.Add(highestpaids.type);
                nr.SubItems.Add(highestpaids.amount.ToString("N0"));

                lstHPS.Items.Add(nr);
            }//eloop
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnExport_Click(object sender, EventArgs e)
        {
            //sql insertion string
            string sql = "INSERT INTO highest_paid_services(id,service_id,customer,type,amount,date) values ";
            foreach (HighestPaid highestpaids in highestpaids)
            {
                var insert = "(null,'a1','a2','a3','a4','a5'),";
                insert = insert.Replace("a1", highestpaids.id.ToString());
                insert = insert.Replace("a2", highestpaids.customer.ToString());
                insert = insert.Replace("a3", highestpaids.type);
                insert = insert.Replace("a4", highestpaids.amount.ToString());
                insert = insert.Replace("a5", highestpaids.date);

                sql += insert;
            }//loop
            sql = sql.Substring(0, sql.Length - 1) + ";";
            m1.ExecuteQuery(sql);
            new FormExportReportHPS().ShowDialog();
        }//ef

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
            ShowInListView();
        }//ef
    }//ec
}//en
