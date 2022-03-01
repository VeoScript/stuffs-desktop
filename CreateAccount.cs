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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(UCF.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static string QueryInsert;
        public static string QuerySelect;

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
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtRePassword.Clear();
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name is required!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Username is required!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password is required!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else if (txtRePassword.Text == "")
            {
                MessageBox.Show("Re-enter Password is required!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRePassword.Focus();
            }
            else if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Password not matched, Try again", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtRePassword.Clear();
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    QuerySelect = "SELECT * FROM UserAccount WHERE username='" + txtUsername.Text + "'";
                    con.Open();
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("This account is already registered.", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearAll();
                    }
                    else
                    {
                        con.Close();
                        QueryInsert = "INSERT INTO UserAccount(name, username, password) VALUES('" + txtName.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "')";

                        con.Open();
                        cmd = new SqlCommand(QueryInsert, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Successfully Registered.", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();

                        Login l = new Login();
                        l.Show();
                        Hide();
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

        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            Hide();
        }
    }
}
