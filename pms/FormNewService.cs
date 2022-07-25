using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pms
{
    public partial class FormNewService : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of sales
        List<Product> products = new List<Product>();
        //list of service
        List<NewService> newservice = new List<NewService>();
        public FormNewService(string serviceid)
        {
            InitializeComponent();
            txtServiceId.Text = serviceid;
        }//ef

        private void FromNewService_Load(object sender, EventArgs e)
        {
            LoadDataAll();
            refreshAll();
        }

        private void LoadDataAll()
        {
            products.Clear();
            string sql = "SELECT * FROM product ORDER BY id DESC";
            DataTable t1 = m1.GetDataTable(sql);

            foreach (DataRow dr in t1.Rows)
            {
                int id = int.Parse(dr[0].ToString());
                string name = dr[1].ToString();
                double price = double.Parse(dr[2].ToString());
                string type = dr[3].ToString();
                products.Add(new Product(id, name, price, type));
            }//eloop
        }//ef

        private void refreshAll()
        {
            string search = txtSearch.Text.Replace(" ", "").ToLower();
            List<Product> searchProducts;
            if (search.Trim() != "")
            {
                searchProducts = products.Where(x => x.id.ToString().Contains(search)
                || x.name.ToLower().Contains(search)).ToList();
            }
            else
            {
                searchProducts = products;
            }
            ShowInListView(searchProducts);
        }//ef

        private void ShowInListView(List<Product> searchProducts)
        {
            lstProduct.Items.Clear();
            foreach (Product products in searchProducts)
            {
                ListViewItem nr = new ListViewItem(products.id.ToString());
                nr.SubItems.Add(products.name);
                nr.SubItems.Add(products.price.ToString("N0"));
                nr.SubItems.Add(products.type);

                lstProduct.Items.Add(nr);
            }//eloop
        }//ef

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            refreshAll();
        }//ef

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstProduct.SelectedItems.Count > 0)
                {
                    //Material
                    int mtrServiceId = int.Parse(txtServiceId.Text);
                    int mtrProdId = int.Parse(lstProduct.SelectedItems[0].SubItems[0].Text);
                    string mtrName = lstProduct.SelectedItems[0].SubItems[1].Text;
                    double mtrPrice = double.Parse(lstProduct.SelectedItems[0].SubItems[2].Text) * int.Parse(txtQty.Text);
                    int mtrQty = int.Parse(txtQty.Text);
                    string mtrType = lstProduct.SelectedItems[0].SubItems[3].Text;

                    newservice.Add(new NewService(0, mtrServiceId, 0, mtrProdId, mtrName, mtrPrice, mtrQty, mtrType));
                }//eif
                lstOrder.Items.Clear();
                double total = 0;
                foreach (NewService newservice in newservice)
                {
                    ListViewItem nr = new ListViewItem(newservice.productid.ToString());
                    nr.SubItems.Add(newservice.name);
                    nr.SubItems.Add(newservice.price.ToString("N0"));
                    nr.SubItems.Add(newservice.qty.ToString());
                    nr.SubItems.Add(newservice.type);
                    lstOrder.Items.Add(nr);

                    total += (newservice.price * 1.07);

                }//loop
                txtTotal.Text = total.ToString("N0");
                txtQty.Text = "";
            }
            catch (Exception)
            {
                if (txtQty.Text == "")
                    MessageBox.Show("Please enter the quantity");
            }//ecatch
        }//ef

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstProduct.SelectedItems.Count > 0)
            {
                //Material
                int mtrServiceId = int.Parse(txtServiceId.Text);
                int mtrProdId = int.Parse(lstOrder.SelectedItems[0].SubItems[0].Text);
                string mtrName = lstOrder.SelectedItems[0].SubItems[1].Text;
                double mtrPrice = double.Parse(lstOrder.SelectedItems[0].SubItems[2].Text);
                int mtrQty = int.Parse(lstOrder.SelectedItems[0].SubItems[3].Text);
                string mtrType = lstOrder.SelectedItems[0].SubItems[4].Text;

                newservice.RemoveAll(o => o.productid == mtrProdId);
            }//eif
            lstOrder.Items.Clear();
            double total = 0;
            foreach (NewService newservice in newservice)
            {
                ListViewItem nr = new ListViewItem(newservice.productid.ToString());
                nr.SubItems.Add(newservice.name);
                nr.SubItems.Add(newservice.price.ToString("N0"));
                nr.SubItems.Add(newservice.qty.ToString());
                nr.SubItems.Add(newservice.type);
                lstOrder.Items.Add(nr);

                total += (newservice.price * 1.07);

            }//loop
            txtTotal.Text = total.ToString("N0");
        }//ef

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //sql insertion string
                string sql = "INSERT INTO service_details(id,service_id,fees,product_id,name,price,qty,type) values ";
                foreach (NewService newservice in newservice)
                {
                    var insert = "(null,'a1','a2','a3','a4','a5','a6','a7'),";
                    insert = insert.Replace("a1", newservice.serviceid.ToString());
                    insert = insert.Replace("a2", txtFees.Text);
                    insert = insert.Replace("a3", newservice.productid.ToString());
                    insert = insert.Replace("a4", newservice.name);
                    insert = insert.Replace("a5", newservice.price.ToString());
                    insert = insert.Replace("a6", newservice.qty.ToString());
                    insert = insert.Replace("a7", newservice.type);
                    sql += insert;
                }//loop
                sql = sql.Substring(0, sql.Length - 1) + ";";
                m1.ExecuteQuery(sql);

                //sql update string
                double grandtotal = 0;
                double total = double.Parse(txtTotal.Text.Replace(",", ""));
                double fees = double.Parse(txtFees.Text.Replace(",", ""));
                grandtotal = total + fees;
                //MessageBox.Show(grandtotal.ToString());
                string update = "UPDATE service SET amount = 'b3' WHERE id = 'b0'";
                update = update.Replace("b3", grandtotal.ToString());
                update = update.Replace("b0", txtServiceId.Text);
                //MessageBox.Show(update);
                m1.ExecuteQuery(update);
                MessageBox.Show("New service has been added.");

                newservice.Clear();
                this.DialogResult = DialogResult.OK;
            }//etry
            catch (Exception)
            {
                if (txtFees.Text == "")
                    MessageBox.Show("Please enter service fees");
            }//ecatch
        }//ef

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newservice.Clear();
            string sql = "DELETE FROM sales WHERE id =  'd0'";
            sql = sql.Replace("d0", txtServiceId.Text);
            m1.ExecuteNonQuery(sql);

            this.DialogResult = DialogResult.OK;
        }//ef
    }//ec
}//en
