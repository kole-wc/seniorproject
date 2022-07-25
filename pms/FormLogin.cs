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
    public partial class FormLogin : Form
    {
        DataManager m1 = new DataManager("localhost", "seniorproject", "root", "");
        public FormLogin()
        {
            InitializeComponent();
        }//ef

        //login function
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //take username and password from textbox
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //getting data from "user" table in the database
            string sql = "SELECT * FROM user WHERE username = 'un'";
            sql = sql.Replace("un", username);
            //MessageBox.Show(sql);
            DataTable t1 = m1.GetDataTable(sql);

            if (t1.Rows.Count < 1)
            {
                MessageBox.Show("Username does not exist.");
                return;
                resetData();
            }

            //MessageBox.Show(password);
            string passwordHash = t1.Rows[0][4].ToString();
            //MessageBox.Show(passwordHash);
            string passwordSalt = t1.Rows[0][5].ToString();
            //MessageBox.Show(passwordSalt);


            bool isMatch = Utility.VerifyPassword(password, passwordHash, passwordSalt);
            if (isMatch)
            {
                string role = t1.Rows[0][6].ToString();
                if (role == "admin")
                {
                    this.Hide();
                    new FormAdminPanel().ShowDialog();
                }//eif
                else if (role == "user")
                {
                    this.Hide();
                    new FormUserPanel().ShowDialog();
                }//eif
            }
            else
            {
                MessageBox.Show("Incorrect password.");
                resetPassword();
            }
        }//ef

        //reset data function
        private void resetData()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }//ef

        private void resetPassword()
        {
            txtPassword.Text = "";
        }//ef

        private void FormLogin_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
                    "Please make sure that XAMPP is up and running." + Environment.NewLine + "Otherwise the application will not work or crash."
            );
            resetData();
        }//ef
    }//ec
}//en
