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
    public partial class FormReportMFM : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of highest paid
        List<MostFreqMaintenance> mfm = new List<MostFreqMaintenance>();
        public FormReportMFM()
        {
            InitializeComponent();
        }//ef

        private void FormReportMFM_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowInListView();
            dateTime.Format = DateTimePickerFormat.Custom;
            //dateTime.ShowUpDown = true;
            lstMFM.Columns[0].TextAlign = HorizontalAlignment.Right;
        }//ef

        private void LoadData()
        {
            mfm.Clear();
            string sql = "SELECT service.id, service.customer,  COUNT(maintenance.service) as frequency, maintenance.request_date " +
                         "FROM service INNER JOIN maintenance ON service.id = maintenance.service WHERE request_date " +
                         "BETWEEN 'd1' AND 'd2' GROUP BY service.id ORDER BY frequency DESC";
            
                sql = sql.Replace("d1", dateTime.Value.Year.ToString() + "-01" + "-01");
                sql = sql.Replace("d2", dateTime.Value.Year.ToString() + "-12" + "-31");
            
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string customer = dr[1].ToString();
                int freq = int.Parse(dr[2].ToString());
                string date = dr[3].ToString();
                mfm.Add(new MostFreqMaintenance(id, customer, freq, date));
            }//eloop
        }//ef

        private void ShowInListView()
        {
            string empty = "";
            lstMFM.Items.Clear();
            foreach (MostFreqMaintenance mfm in mfm)
            {
                ListViewItem nr = new ListViewItem(empty);
                nr.SubItems.Add(mfm.id.ToString());
                nr.SubItems.Add(mfm.customer);
                nr.SubItems.Add(mfm.date);
                nr.SubItems.Add(mfm.freq.ToString());

                lstMFM.Items.Add(nr);
            }//eloop
        }//ef

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnExport_Click(object sender, EventArgs e)
        {
            //sql insertion string
            string sql = "INSERT INTO most_frequent_maintenance(id,service_id,customer,frequency,date) values ";
            foreach (MostFreqMaintenance mfm in mfm)
            {
                var insert = "(null,'a1','a2','a3','a4'),";
                insert = insert.Replace("a1", mfm.id.ToString());
                insert = insert.Replace("a2", mfm.customer.ToString());
                insert = insert.Replace("a3", mfm.freq.ToString());
                insert = insert.Replace("a4", mfm.date);
                
                sql += insert;
            }//loop
            sql = sql.Substring(0, sql.Length - 1) + ";";
            m1.ExecuteQuery(sql);
            new FormExportReportMFM().ShowDialog();
        }//ef

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
            ShowInListView();
        }//ef
    }//ec
}//en
