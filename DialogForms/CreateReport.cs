using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace stuffs.DialogForms
{
    public partial class CreateReport : Form
    {
        public CreateReport()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(UCF.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static string QueryInsert;

        //this function will insert the text with a apostrophe or single quote character
        public string convertSingleQuotes(string str)
        {
            return str.Replace("'", "''");
        }

        private void ClearAll()
        {
            txtRequestingPerson.Clear();
            txtReportedIssue.Clear();
            txtResolutionMade.Clear();
            cmbMonthDateReported.SelectedIndex = -1;
            cmbDayDateReported.SelectedIndex = -1;
            cmbYearDateReported.SelectedIndex = -1;
            cmbMonthDateResolved.SelectedIndex = -1;
            cmbDayDateResolved.SelectedIndex = -1;
            cmbYearDateResolved.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateReport_Load(object sender, EventArgs e)
        {
            cmbMonthDateReported.SelectedItem = Home.GetMonth;
            cmbYearDateReported.SelectedItem = Home.GetYear;
            cmbMonthDateResolved.SelectedItem = Home.GetMonth;
            cmbYearDateResolved.SelectedItem = Home.GetYear;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtRequestingPerson.Text == "")
            {
                MessageBox.Show("Requesting person field is required!", "Create Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequestingPerson.Focus();
            }
            else if (txtReportedIssue.Text == "")
            {
                MessageBox.Show("Reported issue field is required!", "Create Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReportedIssue.Focus();
            }
            else if (txtResolutionMade.Text == "")
            {
                MessageBox.Show("Resolution made field is required!", "Create Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResolutionMade.Focus();
            }
            else if (cmbMonthDateReported.SelectedIndex < 0)
            {
                MessageBox.Show("Reported month field is required!", "Create Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMonthDateReported.Focus();
            }
            else if (cmbDayDateReported.SelectedIndex < 0)
            {
                MessageBox.Show("Reported day field is required!", "Create Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDayDateReported.Focus();
            }
            else if (cmbYearDateReported.SelectedIndex < 0)
            {
                MessageBox.Show("Reported year field is required!", "Create Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbYearDateReported.Focus();
            }
            else if (cmbMonthDateResolved.SelectedIndex < 0)
            {
                MessageBox.Show("Resolved month field is required!", "Create Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMonthDateResolved.Focus();
            }
            else if (cmbDayDateResolved.SelectedIndex < 0)
            {
                MessageBox.Show("Resolved day field is required!", "Create Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDayDateResolved.Focus();
            }
            else if (cmbYearDateResolved.SelectedIndex < 0)
            {
                MessageBox.Show("Resolved year field is required!", "Create Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbYearDateResolved.Focus();
            }
            else
            {
                try
                {
                    Guid guid = Guid.NewGuid();
                    string account_uuid = guid.ToString();

                    QueryInsert = "INSERT INTO Reports(uuid, reportBy, requestingPerson, reportedIssue, resolutionMade, dateReportedMonth, dateReportedDay, dateReportedYear, dateResolvedMonth, dateResolvedDay, dateResolvedYear) VALUES('" + account_uuid + "', '" + Login.GetAccountUsername.ToString() + "', '" + txtRequestingPerson.Text + "', '" + convertSingleQuotes(txtReportedIssue.Text) + "', '" + convertSingleQuotes(txtResolutionMade.Text) + "', '" + cmbMonthDateReported.SelectedItem + "', '" + cmbDayDateReported.SelectedItem + "', '" + cmbYearDateReported.SelectedItem + "', '" + cmbMonthDateResolved.SelectedItem + "', '" + cmbDayDateResolved.SelectedItem + "', '" + cmbYearDateResolved.SelectedItem + "')";
                    con.Open();
                    cmd = new SqlCommand(QueryInsert, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Report saved successfully.", "Create Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Home.refresh_table_oncreate = true;

                    ClearAll();

                    con.Close();

                    Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }
    }
}
