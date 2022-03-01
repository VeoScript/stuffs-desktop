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
    public partial class UpdateReport : Form
    {
        public UpdateReport()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(UCF.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static string QueryUpdate;

        //this function will insert the text with a apostrophe or single quote character
        public string convertSingleQuotes(string str)
        {
            return str.Replace("'", "''");
        }

        private void UpdateReport_Load(object sender, EventArgs e)
        {
            string DateReported;
            string DateResolved;
            string[] SplitDateReported;
            string[] SplitDateResolved;

            txtRequestingPerson.Text = Home.GetRequestingPerson.ToString();
            txtReportedIssue.Text = Home.GetReportedIssue.ToString();
            txtResolutionMade.Text = Home.GetResolutionMade.ToString();
            DateReported = Home.GetDateReported.ToString();
            SplitDateReported = DateReported.Split(" ");
            DateResolved = Home.GetDateResolved.ToString();
            SplitDateResolved = DateResolved.Split(" ");

            if (cmbMonthDateReported.Items.Contains(SplitDateReported.GetValue(0).ToString()))
            {
                cmbMonthDateReported.SelectedItem = SplitDateReported.GetValue(0).ToString();
            }

            if (cmbDayDateReported.Items.Contains(SplitDateReported.GetValue(1).ToString()))
            {
                cmbDayDateReported.SelectedItem = SplitDateReported.GetValue(1).ToString();
            }

            if (cmbYearDateReported.Items.Contains(SplitDateReported.GetValue(2).ToString()))
            {
                cmbYearDateReported.SelectedItem = SplitDateReported.GetValue(2).ToString();
            }

            if (cmbMonthDateResolved.Items.Contains(SplitDateResolved.GetValue(0).ToString()))
            {
                cmbMonthDateResolved.SelectedItem = SplitDateResolved.GetValue(0).ToString();
            }

            if (cmbDayDateResolved.Items.Contains(SplitDateResolved.GetValue(1).ToString()))
            {
                cmbDayDateResolved.SelectedItem = SplitDateResolved.GetValue(1).ToString();
            }

            if (cmbYearDateResolved.Items.Contains(SplitDateResolved.GetValue(2).ToString()))
            {
                cmbYearDateResolved.SelectedItem = SplitDateResolved.GetValue(2).ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string reportUuid = Home.GetAccountUUID.ToString();

            try
            {
                QueryUpdate = "UPDATE Reports SET requestingPerson='" + txtRequestingPerson.Text + "', reportedIssue='" + convertSingleQuotes(txtReportedIssue.Text) + "', resolutionMade='" + convertSingleQuotes(txtResolutionMade.Text) + "', dateReportedMonth='" + cmbMonthDateReported.SelectedItem + "', dateReportedDay='" + cmbDayDateReported.SelectedItem + "', dateReportedYear='" + cmbYearDateReported.SelectedItem + "', dateResolvedMonth='" + cmbMonthDateResolved.SelectedItem + "', dateResolvedDay='" + cmbDayDateResolved.SelectedItem + "', dateResolvedYear='" + cmbYearDateResolved.SelectedItem + "' WHERE uuid='" + reportUuid + "'";

                con.Open();
                cmd = new SqlCommand(QueryUpdate, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Report updated successfully.", "Update Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Home.refresh_table_onupdate = true; 

                con.Close();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string reportUuid = Home.GetAccountUUID.ToString();

            try
            {
                DialogResult = MessageBox.Show("Are you sure you want to delete this report entry?", "Delete Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    QueryUpdate = "DELETE FROM Reports WHERE uuid='" + reportUuid + "'";

                    con.Open();
                    cmd = new SqlCommand(QueryUpdate, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Report deleted successfully.", "Delete Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Home.refresh_table_onupdate = true;

                    con.Close();

                    Close();
                } 
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
