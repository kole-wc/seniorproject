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
    public partial class FormReportCR : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list
        List<CustomerRetention> customerretention = new List<CustomerRetention>();
        public FormReportCR()
        {
            InitializeComponent();
        }//ef

        private void FormReportCR_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowInListView();
            dateTime.Format = DateTimePickerFormat.Custom;
            //dateTime.ShowUpDown = true;
            lstCR.Columns[0].TextAlign = HorizontalAlignment.Right;
        }//ef

        private void LoadData()
        {
            customerretention.Clear();
            string sql = "SELECT customer.id, customer.firstname, customer.lastname, customer.company, COUNT(sales.customer) as sales, COUNT(service.customer) as service, ((COUNT(sales.customer)*0.25)+(COUNT(service.customer)*0.75)) as weighted , service.startdate"
                        + " FROM customer INNER JOIN sales ON customer.id = sales.customer INNER JOIN service ON customer.id = service.customer  WHERE startdate BETWEEN 'd1' AND 'd2' GROUP BY customer.id ORDER BY weighted DESC;";
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
                string firstName = dr[1].ToString();
                string lastName = dr[2].ToString();
                string company = dr[3].ToString();
                int ordercomp = int.Parse(dr[4].ToString());
                int servcomp = int.Parse(dr[5].ToString());
                double weighted = double.Parse(dr[6].ToString());
                string date = dr[7].ToString();
                customerretention.Add(new CustomerRetention(id, firstName, lastName, company, servcomp, ordercomp, weighted, date));
            }//eloop
        }//ef

        private void ShowInListView()
        {
            string empty = "";
            lstCR.Items.Clear();
            foreach (CustomerRetention customerretention in customerretention)
            {
                ListViewItem nr = new ListViewItem(empty);
                nr.SubItems.Add(customerretention.id.ToString());
                nr.SubItems.Add(customerretention.firstName);
                nr.SubItems.Add(customerretention.lastName);
                nr.SubItems.Add(customerretention.company);
                nr.SubItems.Add(customerretention.servcomp.ToString());
                nr.SubItems.Add(customerretention.ordercomp.ToString());
                nr.SubItems.Add(customerretention.weighted.ToString());

                lstCR.Items.Add(nr);
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
            string sql = "INSERT INTO customer_retention(id,customer_id,firstname,lastname,company,ordercomp,servcomp,weighted,date) values ";
            foreach (CustomerRetention customerretention in customerretention)
            {
                var insert = "(null,'a1','a2','a3','a4','a5','a6','a7','a8'),";
                insert = insert.Replace("a1", customerretention.id.ToString());
                insert = insert.Replace("a2", customerretention.firstName);
                insert = insert.Replace("a3", customerretention.lastName);
                insert = insert.Replace("a4", customerretention.company);
                insert = insert.Replace("a5", customerretention.ordercomp.ToString());
                insert = insert.Replace("a6", customerretention.servcomp.ToString());
                insert = insert.Replace("a7", customerretention.weighted.ToString());
                insert = insert.Replace("a8", customerretention.date);
                sql += insert;
            }//loop
            sql = sql.Substring(0, sql.Length - 1) + ";";
            m1.ExecuteQuery(sql);
            new FormExportReportCR().ShowDialog();
        }//ef

        private void lstCR_SelectedIndexChanged(object sender, EventArgs e)
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

        //private void ShowInListView()
        //{
        //    lstCR.Items.Clear();
        //    double total = 0;
        //    foreach (Customer customer in customer)
        //    {
        //        ListViewItem nr = new ListViewItem(customer.id.ToString());
        //        nr.SubItems.Add(customer.firstName);
        //        nr.SubItems.Add(customer.lastName);
        //        nr.SubItems.Add(customer.company);
        //        foreach (Service service in service)
        //        {
        //            string cusid = service.customer;

        //        }
        //        nr.SubItems.Add(orderdetails.qty.ToString());
        //        nr.SubItems.Add(orderdetails.type);

        //        lstOrderDetails.Items.Add(nr);

        //        total += (orderdetails.price * 1.07);
        //    }//eloop
        //    txtTotal.Text = total.ToString("N0");
        //}//ef
    }//ec
}//en
