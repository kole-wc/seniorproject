using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pms;
using System.Web;
using System.Web.UI;
using MySql.Data.MySqlClient;

namespace pms
{
    public partial class FormUser : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        //list of users
        List<User> users = new List<User>();
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            lblID.Visible = false;
            btnModify.Visible = false;
            refreshAll();
        }

        private void refreshAll() {
            string sql = "select * from user";
            DataTable t1 = m1.GetDataTable(sql);

            lstUser.Items.Clear();

            foreach (DataRow row in t1.Rows)
            {
                string id           = row[0].ToString();
                string firstname    = row[1].ToString();
                string lastname     = row[2].ToString();
                string username     = row[3].ToString();
                string role         = row[6].ToString();

                ListViewItem newRow = new ListViewItem(id);

                newRow.SubItems.Add(firstname);
                newRow.SubItems.Add(lastname);
                newRow.SubItems.Add(username);
                newRow.SubItems.Add(role);
                lstUser.Items.Add(newRow);

            }//eloop


        }//ef

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUser.SelectedItems.Count > 0)
            {
                
                string firstname    = lstUser.SelectedItems[0].SubItems[1].Text;
                string lastname     = lstUser.SelectedItems[0].SubItems[2].Text;
                string username     = lstUser.SelectedItems[0].SubItems[3].Text;
                string role         = lstUser.SelectedItems[0].SubItems[4].Text;

                lblID.Text          = lstUser.SelectedItems[0].SubItems[0].Text;

                txtFirstName.Text   = firstname;
                txtLastName.Text    = lastname;
                txtUsername.Text    = username;
                cmbRole.Text        = role;

                btnRegister.Visible = false;
                btnModify.Visible = true;
                lblPass.Visible = false;
                lblReenter.Visible = false;
                txtPassword.Visible = false;
                txtReenterPassword.Visible = false;


            }//eif
            else
            {
                resetData();
            }//elese
        }

        private void resetData()
        {
            txtFirstName.Text       = "";
            txtLastName.Text        = "";
            txtUsername.Text        = "";
            cmbRole.Text            = "";
            txtPassword.Text        = "";
            txtReenterPassword.Text = "";
            
            btnRegister.Visible     = true;
            btnModify.Visible       = false;

            lblPass.Visible = true;
            lblReenter.Visible = true;
            txtPassword.Visible = true;
            txtReenterPassword.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //take username and password from textbox
            string firstname    = txtFirstName.Text;
            string lastname     = txtLastName.Text;
            string username     = txtUsername.Text;
            string password     = txtPassword.Text;
            string reenter      = txtReenterPassword.Text;
            string role         = cmbRole.Text; 

            
                if (password == reenter)
                {
                    HashSalt en_password = Utility.GenerateSaltedHash(64, txtPassword.Text);
                    String passwordHash = en_password.Hash;
                    String passwordSalt = en_password.Salt;
                    //MessageBox.Show(passwordHash);
                    //MessageBox.Show(passwordSalt);

                    string insert = "INSERT INTO user(id,firstname,lastname,username,password,salt,role)";
                    insert += "value(null,'a1','a2','a3','a4','a5','a6')";
                    insert = insert.Replace("a1", firstname);
                    insert = insert.Replace("a2", lastname);
                    insert = insert.Replace("a3", username);
                    insert = insert.Replace("a4", passwordHash);
                    insert = insert.Replace("a5", passwordSalt);
                    insert = insert.Replace("a6", role);
                    //MessageBox.Show(insert);
                    m1.ExecuteQuery(insert);
                    refreshAll();
                    MessageBox.Show("New User has been added.");
                    resetData();


                }//ef
                else
                {
                    txtReenterPassword.Text = "";
                    MessageBox.Show("Please reenter password!");
                }//ef
            //}//ef

            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //enable edit firstname
            string sql = "update user set firstname = 'd1' where id = 'd0'";
            sql = sql.Replace("d1", txtFirstName.Text);
            sql = sql.Replace("d0", lblID.Text);
            m1.ExecuteNonQuery(sql);
            //MessageBox.Show(sql);

            //enable edit lastname
            sql = "update user set lastname = 'd2' where id = 'd0'";
            sql = sql.Replace("d0", lblID.Text);
            sql = sql.Replace("d2", txtLastName.Text);
            m1.ExecuteNonQuery(sql);
            //MessageBox.Show(sql);

            //enable edit username
            sql = "update user set username = 'd3' where id = 'd0'";
            sql = sql.Replace("d0", lblID.Text);
            sql = sql.Replace("d3", txtUsername.Text);
            m1.ExecuteNonQuery(sql);
            //MessageBox.Show(sql);


            MessageBox.Show("The user information has been updated!");
            refreshAll();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
