﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace stuffs
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(UCF.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static string QuerySelect;
        public static bool refresh_table_oncreate = false;
        public static bool refresh_table_onupdate = false;

        public static string GetAccountID;

        public static string GetAccountUUID;
        public static string GetRequestingPerson;
        public static string GetReportedIssue;
        public static string GetResolutionMade;
        public static string GetDateReported;
        public static string GetDateResolved;

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

        public void LoadTable()
        {
            try
            {
                con.Close();
                con.Open();
                QuerySelect = "SELECT * FROM Reports WHERE reportBy='" + Login.GetAccountUsername.ToString() + "'";
                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.Refresh();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["uuid"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["requestingPerson"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["reportedIssue"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["resolutionMade"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item["dateReportedMonth"].ToString() + " " + item["dateReportedDay"].ToString() + " " + item["dateReportedYear"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item["dateResolvedMonth"].ToString() + " " + item["dateResolvedDay"].ToString() + " " + item["dateResolvedYear"].ToString();
                }

                dt.AcceptChanges();
                con.Close();

                lblCountReports.Text = dataGridView1.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Too fast, take it slow to update in every entry to avoid this message", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SearchResults()
        {
            try
            {
                con.Close();
                con.Open();
                QuerySelect = "SELECT * FROM Reports WHERE reportBy='" + Login.GetAccountUsername.ToString() + "' AND dateReportedMonth='" + cmbSearchMonth.SelectedItem + "' AND dateReportedYear='" + cmbSearchYear.SelectedItem + "'";
                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.Refresh();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["uuid"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["requestingPerson"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["reportedIssue"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["resolutionMade"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item["dateReportedMonth"].ToString() + " " + item["dateReportedDay"].ToString() + " " + item["dateReportedYear"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item["dateResolvedMonth"].ToString() + " " + item["dateResolvedDay"].ToString() + " " + item["dateResolvedYear"].ToString();
                }

                dt.AcceptChanges();
                con.Close();

                lblCountReports.Text = dataGridView1.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Too fast, take it slow to update in every entry to avoid this message", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SearchFunction()
        {
            if (cmbSearchYear.SelectedIndex == 0 && cmbSearchMonth.SelectedIndex == 0)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                LoadTable();

                lblGenerateTxt.Text = "All reports will be displayed in current records";
                lblDisplayMonthYear.Text = "";
            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                SearchResults();

                lblGenerateTxt.Text = "Generated reports from the month of";
                lblDisplayMonthYear.Text = cmbSearchMonth.Text + " " + cmbSearchYear.Text;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblGenerateTxt.Text = "All reports will be displayed in current records";
            lblDisplayMonthYear.Text = "";

            lblAccountName.Text = Login.GetAccountName.ToString();
            LoadTable();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cmbSearchYear.SelectedIndex > 0 && cmbSearchMonth.SelectedIndex > 0)
            {
                if (refresh_table_oncreate || refresh_table_onupdate)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    SearchResults();
                    refresh_table_oncreate = false;
                    refresh_table_onupdate = false;
                }
            }
            else
            {
                if (refresh_table_oncreate || refresh_table_onupdate)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    LoadTable();
                    refresh_table_oncreate = false;
                    refresh_table_onupdate = false;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbSearchYear.SelectedIndex = -1;
            cmbSearchMonth.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            LoadTable();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogForms.CreateReport cr = new DialogForms.CreateReport();
            cr.ShowDialog();
        }

        private void cmbSearchMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFunction();
        }

        private void cmbSearchYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFunction();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                GetAccountUUID = row.Cells[1].Value.ToString();
                GetRequestingPerson = row.Cells[2].Value.ToString();
                GetReportedIssue = row.Cells[3].Value.ToString();
                GetResolutionMade = row.Cells[4].Value.ToString();
                GetDateReported = row.Cells[5].Value.ToString();
                GetDateResolved = row.Cells[6].Value.ToString();

                DialogForms.UpdateReport ur = new DialogForms.UpdateReport();
                ur.ShowDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }

        private void ExportToPDF()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                
                if (cmbSearchYear.SelectedIndex > 0 && cmbSearchMonth.SelectedIndex > 0)
                {
                    sfd.FileName = "Monthly Report" + " - " + cmbSearchMonth.Text + " " + cmbSearchYear.Text;
                } 
                else
                {
                    sfd.FileName = "All Reports.pdf";
                }

                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            //foreach (DataGridViewColumn column in dataGridView1.Columns)
                            //{
                            //    if (!column.Visible) continue;

                            //    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            //    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                            //    pdfTable.AddCell(cell);
                            //}

                            //foreach (DataGridViewRow row in dataGridView1.Rows)
                            //{
                            //    foreach (DataGridViewCell cell in row.Cells)
                            //    {
                            //        if (!dataGridView1.Columns[cell.ColumnIndex].Visible) continue;

                            //        pdfTable.AddCell(new Phrase(cell.Value.ToString()));
                            //    }
                            //}

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(250, 192, 86);
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.LETTER, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data exported successfully!", "Export to PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No record to export!", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
