using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace stuffs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(UCF.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static string QueryInsert;
        public static string QuerySelect;

        public static string GetAccountID;
        public static string GetAccountUsername;
        public static string GetAccountName;

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void ClearAll()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                MessageBox.Show("Username is required.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if(txtPassword.Text == "")
            {
                MessageBox.Show("Password is required.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    QuerySelect = "SELECT * FROM UserAccount WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        reader.Read();
                        GetAccountID = reader["id"].ToString();
                        GetAccountName = reader["name"].ToString();
                        GetAccountUsername = reader["username"].ToString();

                        Home h = new Home();
                        h.Show();
                        ClearAll();
                        reader.Close();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or Password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearAll();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount c = new CreateAccount();
            c.Show();
            Hide();
        }
    }
}
