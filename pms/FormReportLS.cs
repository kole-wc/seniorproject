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
    public partial class FormReportLS : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of selling
        List<Selling> selling = new List<Selling>();
        public FormReportLS()
        {
            InitializeComponent();
        }//ef

        private void FormReportLS_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowInListView();
            dateTime.Format = DateTimePickerFormat.Custom;
            //dateTime.ShowUpDown = true;
            lstSelling.Columns[0].TextAlign = HorizontalAlignment.Right;
        }//ef

        private void LoadData()
        {
            selling.Clear();
            string sql = "SELECT sales.id, order_details.sales_id, order_details.product_id, order_details.name, order_details.type, SUM(order_details.quantity), SUM(order_details.price), sales.order_date FROM order_details " +
                         "INNER JOIN sales ON sales.id = order_details.sales_id WHERE order_date BETWEEN 'd1' AND 'd2' GROUP BY product_id ORDER BY SUM(quantity) ASC";
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
                int id = int.Parse(dr[2].ToString());
                string name = dr[3].ToString();
                string type = dr[4].ToString();
                int qty = int.Parse(dr[5].ToString());
                double total = double.Parse(dr[6].ToString());
                string date = dr[7].ToString();

                selling.Add(new Selling(id, name, type, qty, total, date));
            }//eloop
        }//ef
        private void ShowInListView()
        {
            string empty = "";
            lstSelling.Items.Clear();
            foreach (Selling selling in selling)
            {
                ListViewItem nr = new ListViewItem(empty);
                nr.SubItems.Add(selling.id.ToString());
                nr.SubItems.Add(selling.name);
                nr.SubItems.Add(selling.type);
                nr.SubItems.Add(selling.qty.ToString());
                nr.SubItems.Add(selling.total.ToString("N0"));

                lstSelling.Items.Add(nr);
            }//eloop
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void lblMonthDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //sql insertion string
            string sql = "INSERT INTO selling(id,product_id,name,type,quantity,total,date) values ";
            foreach (Selling selling in selling)
            {
                var insert = "(null,'a1','a2','a3','a4','a5','a6'),";
                insert = insert.Replace("a1", selling.id.ToString());
                insert = insert.Replace("a2", selling.name);
                insert = insert.Replace("a3", selling.type);
                insert = insert.Replace("a4", selling.qty.ToString());
                insert = insert.Replace("a5", selling.total.ToString());
                insert = insert.Replace("a6", selling.date.ToString());
                sql += insert;
            }//loop
            sql = sql.Substring(0, sql.Length - 1) + ";";
            m1.ExecuteQuery(sql);
            new FormExportReportLS().ShowDialog();
        }//ef

        private void lstSelling_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMonth_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
            ShowInListView();
        }//ef
    }//ec
}//en
