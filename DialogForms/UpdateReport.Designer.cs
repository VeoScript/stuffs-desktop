﻿namespace stuffs.DialogForms
{
    partial class UpdateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateReport));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbYearDateResolved = new System.Windows.Forms.ComboBox();
            this.cmbDayDateResolved = new System.Windows.Forms.ComboBox();
            this.cmbYearDateReported = new System.Windows.Forms.ComboBox();
            this.cmbMonthDateResolved = new System.Windows.Forms.ComboBox();
            this.cmbDayDateReported = new System.Windows.Forms.ComboBox();
            this.cmbMonthDateReported = new System.Windows.Forms.ComboBox();
            this.txtResolutionMade = new System.Windows.Forms.TextBox();
            this.txtReportedIssue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRequestingPerson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(376, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(538, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.cmbYearDateResolved.Location = new System.Drawing.Point(516, 155);
            this.cmbYearDateResolved.Name = "cmbYearDateResolved";
            this.cmbYearDateResolved.Size = new System.Drawing.Size(97, 23);
            this.cmbYearDateResolved.TabIndex = 9;
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
            this.cmbDayDateResolved.Location = new System.Drawing.Point(452, 155);
            this.cmbDayDateResolved.Name = "cmbDayDateResolved";
            this.cmbDayDateResolved.Size = new System.Drawing.Size(58, 23);
            this.cmbDayDateResolved.TabIndex = 8;
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
            this.cmbYearDateReported.Location = new System.Drawing.Point(516, 77);
            this.cmbYearDateReported.Name = "cmbYearDateReported";
            this.cmbYearDateReported.Size = new System.Drawing.Size(97, 23);
            this.cmbYearDateReported.TabIndex = 6;
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
            this.cmbMonthDateResolved.Location = new System.Drawing.Point(309, 155);
            this.cmbMonthDateResolved.Name = "cmbMonthDateResolved";
            this.cmbMonthDateResolved.Size = new System.Drawing.Size(137, 23);
            this.cmbMonthDateResolved.TabIndex = 7;
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
            this.cmbDayDateReported.Location = new System.Drawing.Point(452, 77);
            this.cmbDayDateReported.Name = "cmbDayDateReported";
            this.cmbDayDateReported.Size = new System.Drawing.Size(58, 23);
            this.cmbDayDateReported.TabIndex = 5;
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
            this.cmbMonthDateReported.Location = new System.Drawing.Point(309, 77);
            this.cmbMonthDateReported.Name = "cmbMonthDateReported";
            this.cmbMonthDateReported.Size = new System.Drawing.Size(137, 23);
            this.cmbMonthDateReported.TabIndex = 4;
            // 
            // txtResolutionMade
            // 
            this.txtResolutionMade.Location = new System.Drawing.Point(25, 232);
            this.txtResolutionMade.Multiline = true;
            this.txtResolutionMade.Name = "txtResolutionMade";
            this.txtResolutionMade.Size = new System.Drawing.Size(254, 83);
            this.txtResolutionMade.TabIndex = 3;
            // 
            // txtReportedIssue
            // 
            this.txtReportedIssue.Location = new System.Drawing.Point(25, 116);
            this.txtReportedIssue.Multiline = true;
            this.txtReportedIssue.Name = "txtReportedIssue";
            this.txtReportedIssue.Size = new System.Drawing.Size(254, 83);
            this.txtReportedIssue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution Made";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reported Issue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(309, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Resolved";
            // 
            // txtRequestingPerson
            // 
            this.txtRequestingPerson.Location = new System.Drawing.Point(25, 54);
            this.txtRequestingPerson.Name = "txtRequestingPerson";
            this.txtRequestingPerson.Size = new System.Drawing.Size(254, 23);
            this.txtRequestingPerson.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(309, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date Reported";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Requesting Person";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(457, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(309, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Month";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(452, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Day";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(516, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(309, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Month";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(452, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Day";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(516, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Year";
            // 
            // UpdateReport
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(639, 345);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRequestingPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReportedIssue);
            this.Controls.Add(this.txtResolutionMade);
            this.Controls.Add(this.cmbMonthDateReported);
            this.Controls.Add(this.cmbDayDateReported);
            this.Controls.Add(this.cmbMonthDateResolved);
            this.Controls.Add(this.cmbYearDateReported);
            this.Controls.Add(this.cmbDayDateResolved);
            this.Controls.Add(this.cmbYearDateResolved);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(655, 384);
            this.MinimumSize = new System.Drawing.Size(655, 384);
            this.Name = "UpdateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Report";
            this.Load += new System.EventHandler(this.UpdateReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbYearDateResolved;
        private System.Windows.Forms.ComboBox cmbDayDateResolved;
        private System.Windows.Forms.ComboBox cmbYearDateReported;
        private System.Windows.Forms.ComboBox cmbMonthDateResolved;
        private System.Windows.Forms.ComboBox cmbDayDateReported;
        private System.Windows.Forms.ComboBox cmbMonthDateReported;
        private System.Windows.Forms.TextBox txtResolutionMade;
        private System.Windows.Forms.TextBox txtReportedIssue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRequestingPerson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}