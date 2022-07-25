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
    public partial class FormOrder : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of sales
        List<Product> products = new List<Product>();
        //list of order
        List<Order> orders = new List<Order>();
        public FormOrder(string orderid)
        {
            InitializeComponent();
            txtOrderId.Text = orderid;
        }//ef

        private void FormOrder_Load(object sender, EventArgs e)
        {
            LoadDataAll();
            refreshAll();
        }//ef

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
                    int mtrOrderId = int.Parse(txtOrderId.Text);
                    int mtrProdId = int.Parse(lstProduct.SelectedItems[0].SubItems[0].Text);
                    string mtrName = lstProduct.SelectedItems[0].SubItems[1].Text;
                    double mtrPrice = double.Parse(lstProduct.SelectedItems[0].SubItems[2].Text) * int.Parse(txtQty.Text);
                    int mtrQty = int.Parse(txtQty.Text);
                    string mtrType = lstProduct.SelectedItems[0].SubItems[3].Text;

                    orders.Add(new Order(0, mtrOrderId, mtrProdId, mtrName, mtrPrice, mtrQty, mtrType));
                }//eif
                lstOrder.Items.Clear();
                double total = 0;
                foreach (Order orders in orders)
                {
                    ListViewItem nr = new ListViewItem(orders.product_id.ToString());
                    nr.SubItems.Add(orders.name);
                    nr.SubItems.Add(orders.price.ToString("N0"));
                    nr.SubItems.Add(orders.qty.ToString());
                    nr.SubItems.Add(orders.type);
                    lstOrder.Items.Add(nr);

                    total += (orders.price * 1.07);

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
            if (lstOrder.SelectedItems.Count > 0)
            {
                //Material
                int mtrOrderId = int.Parse(txtOrderId.Text);
                int mtrProdId = int.Parse(lstOrder.SelectedItems[0].SubItems[0].Text);
                string mtrName = lstOrder.SelectedItems[0].SubItems[1].Text;
                double mtrPrice = double.Parse(lstOrder.SelectedItems[0].SubItems[2].Text);
                int mtrQty = int.Parse(lstOrder.SelectedItems[0].SubItems[3].Text);
                string mtrType = lstOrder.SelectedItems[0].SubItems[4].Text;

                orders.RemoveAll(o => o.product_id == mtrProdId);
            }//eif
            lstOrder.Items.Clear();
            double total = 0;
            foreach (Order orders in orders)
            {
                ListViewItem nr = new ListViewItem(orders.product_id.ToString());
                nr.SubItems.Add(orders.name);
                nr.SubItems.Add(orders.price.ToString());
                nr.SubItems.Add(orders.qty.ToString());
                nr.SubItems.Add(orders.type);
                lstOrder.Items.Add(nr);

                total += (orders.price * 1.07);
            }//eloop
            txtTotal.Text = total.ToString("N0");
        }//ef

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //sql insertion string
            string sql = "INSERT INTO order_details(id,sales_id,product_id,name,price,quantity,type) values ";
            foreach (Order orders in orders)
            {
                var insert = "(null,'a1','a2','a3','a4','a5','a6'),";
                insert = insert.Replace("a1", orders.sales_id.ToString());
                insert = insert.Replace("a2", orders.product_id.ToString());
                insert = insert.Replace("a3", orders.name);
                insert = insert.Replace("a4", orders.price.ToString());
                insert = insert.Replace("a5", orders.qty.ToString());
                insert = insert.Replace("a6", orders.type);
                sql += insert;
            }//loop
            sql = sql.Substring(0, sql.Length - 1) + ";";
            m1.ExecuteQuery(sql);
            
            //sql update string
            string update = "UPDATE sales SET amount = 'b3' WHERE id = 'b0'";
            update = update.Replace("b3", txtTotal.Text.Replace(",",""));
            update = update.Replace("b0", txtOrderId.Text);
            //MessageBox.Show(update);
            m1.ExecuteQuery(update);
            MessageBox.Show("New order has been added.");

            orders.Clear();
            this.DialogResult = DialogResult.OK;
        }//ef

        private void btnCancel_Click(object sender, EventArgs e)
        {
            orders.Clear();
            string sql = "DELETE FROM sales WHERE id =  'd0'";
            sql = sql.Replace("d0", txtOrderId.Text);
            m1.ExecuteNonQuery(sql);

            this.DialogResult = DialogResult.OK;
        }//ef

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }//ec
}//en
