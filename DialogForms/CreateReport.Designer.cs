namespace stuffs.DialogForms
{
    partial class CreateReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtRequestingPerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReportedIssue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResolutionMade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMonthDateReported = new System.Windows.Forms.ComboBox();
            this.cmbDayDateReported = new System.Windows.Forms.ComboBox();
            this.cmbYearDateReported = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMonthDateResolved = new System.Windows.Forms.ComboBox();
            this.cmbDayDateResolved = new System.Windows.Forms.ComboBox();
            this.cmbYearDateResolved = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requesting Person";
            // 
            // txtRequestingPerson
            // 
            this.txtRequestingPerson.Location = new System.Drawing.Point(25, 55);
            this.txtRequestingPerson.Name = "txtRequestingPerson";
            this.txtRequestingPerson.Size = new System.Drawing.Size(254, 23);
            this.txtRequestingPerson.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reported Issue";
            // 
            // txtReportedIssue
            // 
            this.txtReportedIssue.Location = new System.Drawing.Point(25, 117);
            this.txtReportedIssue.Multiline = true;
            this.txtReportedIssue.Name = "txtReportedIssue";
            this.txtReportedIssue.Size = new System.Drawing.Size(254, 83);
            this.txtReportedIssue.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resolution Made";
            // 
            // txtResolutionMade
            // 
            this.txtResolutionMade.Location = new System.Drawing.Point(25, 233);
            this.txtResolutionMade.Multiline = true;
            this.txtResolutionMade.Name = "txtResolutionMade";
            this.txtResolutionMade.Size = new System.Drawing.Size(254, 83);
            this.txtResolutionMade.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(309, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date Reported";
            // 
            // cmbMonthDateReported
            // 
            this.cmbMonthDateReported.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonthDateReported.FormattingEnabled = true;
            this.cmbMonthDateReported.Items.AddRange(new object[] {
            "",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonthDateReported.Location = new System.Drawing.Point(309, 55);
            this.cmbMonthDateReported.Name = "cmbMonthDateReported";
            this.cmbMonthDateReported.Size = new System.Drawing.Size(137, 23);
            this.cmbMonthDateReported.TabIndex = 4;
            // 
            // cmbDayDateReported
            // 
            this.cmbDayDateReported.DropDownHeight = 100;
            this.cmbDayDateReported.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayDateReported.FormattingEnabled = true;
            this.cmbDayDateReported.IntegralHeight = false;
            this.cmbDayDateReported.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDayDateReported.Location = new System.Drawing.Point(452, 55);
            this.cmbDayDateReported.Name = "cmbDayDateReported";
            this.cmbDayDateReported.Size = new System.Drawing.Size(58, 23);
            this.cmbDayDateReported.TabIndex = 5;
            // 
            // cmbYearDateReported
            // 
            this.cmbYearDateReported.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearDateReported.FormattingEnabled = true;
            this.cmbYearDateReported.Items.AddRange(new object[] {
            "",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbYearDateReported.Location = new System.Drawing.Point(516, 55);
            this.cmbYearDateReported.Name = "cmbYearDateReported";
            this.cmbYearDateReported.Size = new System.Drawing.Size(97, 23);
            this.cmbYearDateReported.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(309, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date Resolved";
            // 
            // cmbMonthDateResolved
            // 
            this.cmbMonthDateResolved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonthDateResolved.FormattingEnabled = true;
            this.cmbMonthDateResolved.Items.AddRange(new object[] {
            "",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonthDateResolved.Location = new System.Drawing.Point(309, 117);
            this.cmbMonthDateResolved.Name = "cmbMonthDateResolved";
            this.cmbMonthDateResolved.Size = new System.Drawing.Size(137, 23);
            this.cmbMonthDateResolved.TabIndex = 7;
            // 
            // cmbDayDateResolved
            // 
            this.cmbDayDateResolved.DropDownHeight = 100;
            this.cmbDayDateResolved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayDateResolved.FormattingEnabled = true;
            this.cmbDayDateResolved.IntegralHeight = false;
            this.cmbDayDateResolved.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDayDateResolved.Location = new System.Drawing.Point(452, 117);
            this.cmbDayDateResolved.Name = "cmbDayDateResolved";
            this.cmbDayDateResolved.Size = new System.Drawing.Size(58, 23);
            this.cmbDayDateResolved.TabIndex = 8;
            // 
            // cmbYearDateResolved
            // 
            this.cmbYearDateResolved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearDateResolved.FormattingEnabled = true;
            this.cmbYearDateResolved.Items.AddRange(new object[] {
            "",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbYearDateResolved.Location = new System.Drawing.Point(516, 117);
            this.cmbYearDateResolved.Name = "cmbYearDateResolved";
            this.cmbYearDateResolved.Size = new System.Drawing.Size(97, 23);
            this.cmbYearDateResolved.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(538, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(457, 287);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateReport
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(639, 345);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbYearDateResolved);
            this.Controls.Add(this.cmbDayDateResolved);
            this.Controls.Add(this.cmbYearDateReported);
            this.Controls.Add(this.cmbMonthDateResolved);
            this.Controls.Add(this.cmbDayDateReported);
            this.Controls.Add(this.cmbMonthDateReported);
            this.Controls.Add(this.txtResolutionMade);
            this.Controls.Add(this.txtReportedIssue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRequestingPerson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(655, 384);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(655, 384);
            this.Name = "CreateReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRequestingPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReportedIssue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResolutionMade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMonthDateReported;
        private System.Windows.Forms.ComboBox cmbDayDateReported;
        private System.Windows.Forms.ComboBox cmbYearDateReported;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMonthDateResolved;
        private System.Windows.Forms.ComboBox cmbDayDateResolved;
        private System.Windows.Forms.ComboBox cmbYearDateResolved;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}