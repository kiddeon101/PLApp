namespace PLApp.Forms.IssueBankStatement
{
    partial class IssueBankStatementFromStep2
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
            dgvBankTransactions = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblAccCurrency = new Label();
            lblBankName = new Label();
            lblAccName = new Label();
            btnGenerate = new Button();
            dtpDateTo = new DateTimePicker();
            dtpDateFrom = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnSaveReport = new Button();
            lblOpenBalance = new Label();
            lblCloseBalance = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBankTransactions).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBankTransactions
            // 
            dgvBankTransactions.AllowUserToAddRows = false;
            dgvBankTransactions.BackgroundColor = Color.White;
            dgvBankTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankTransactions.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column7, Column8, Column5, Column6, id });
            dgvBankTransactions.Location = new Point(47, 220);
            dgvBankTransactions.MultiSelect = false;
            dgvBankTransactions.Name = "dgvBankTransactions";
            dgvBankTransactions.ReadOnly = true;
            dgvBankTransactions.RowHeadersVisible = false;
            dgvBankTransactions.RowTemplate.Height = 25;
            dgvBankTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBankTransactions.Size = new Size(1143, 311);
            dgvBankTransactions.TabIndex = 25;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "Line Id";
            Column1.MinimumWidth = 100;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.HeaderText = "Date";
            Column2.MinimumWidth = 120;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "In/Out";
            Column3.MinimumWidth = 100;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Amount";
            Column4.MinimumWidth = 150;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column7.HeaderText = "Recipient Acc Name";
            Column7.MinimumWidth = 150;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column8.HeaderText = "Recipient Acc Num";
            Column8.MinimumWidth = 150;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 150;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Details";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column6.HeaderText = "Balance";
            Column6.MinimumWidth = 100;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(1272, 32);
            label1.TabIndex = 26;
            label1.Text = "Generate Bank Statement";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAccCurrency);
            groupBox1.Controls.Add(lblBankName);
            groupBox1.Controls.Add(lblAccName);
            groupBox1.Controls.Add(btnGenerate);
            groupBox1.Controls.Add(dtpDateTo);
            groupBox1.Controls.Add(dtpDateFrom);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(47, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 122);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // lblAccCurrency
            // 
            lblAccCurrency.AutoSize = true;
            lblAccCurrency.Location = new Point(283, 19);
            lblAccCurrency.Name = "lblAccCurrency";
            lblAccCurrency.Size = new Size(106, 15);
            lblAccCurrency.TabIndex = 37;
            lblAccCurrency.Text = "Account Currency:";
            // 
            // lblBankName
            // 
            lblBankName.AutoSize = true;
            lblBankName.Location = new Point(100, 41);
            lblBankName.Name = "lblBankName";
            lblBankName.Size = new Size(80, 15);
            lblBankName.TabIndex = 36;
            lblBankName.Text = "lblBankName";
            // 
            // lblAccName
            // 
            lblAccName.AutoSize = true;
            lblAccName.Location = new Point(100, 19);
            lblAccName.Name = "lblAccName";
            lblAccName.Size = new Size(97, 15);
            lblAccName.TabIndex = 35;
            lblAccName.Text = "lblAccountName";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(6, 90);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 34;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // dtpDateTo
            // 
            dtpDateTo.CustomFormat = "MMMM yyyy";
            dtpDateTo.Format = DateTimePickerFormat.Custom;
            dtpDateTo.Location = new Point(269, 61);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.ShowUpDown = true;
            dtpDateTo.Size = new Size(131, 23);
            dtpDateTo.TabIndex = 33;
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.CustomFormat = "MMMM yyyy";
            dtpDateFrom.Format = DateTimePickerFormat.Custom;
            dtpDateFrom.Location = new Point(72, 61);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.ShowUpDown = true;
            dtpDateFrom.Size = new Size(131, 23);
            dtpDateFrom.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 41);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 31;
            label5.Text = "Bank Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 30;
            label4.Text = "Account Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 66);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 29;
            label3.Text = "Date From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 66);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 28;
            label2.Text = "Date To:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 202);
            label9.Name = "label9";
            label9.Size = new Size(143, 15);
            label9.TabIndex = 30;
            label9.Text = "Statement Open Balance:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 534);
            label10.Name = "label10";
            label10.Size = new Size(155, 15);
            label10.TabIndex = 31;
            label10.Text = "Statement Closing Balance:";
            // 
            // btnSaveReport
            // 
            btnSaveReport.Location = new Point(46, 578);
            btnSaveReport.Name = "btnSaveReport";
            btnSaveReport.Size = new Size(95, 38);
            btnSaveReport.TabIndex = 35;
            btnSaveReport.Text = "Save Report";
            btnSaveReport.UseVisualStyleBackColor = true;
            btnSaveReport.Click += btnSaveReport_Click;
            // 
            // lblOpenBalance
            // 
            lblOpenBalance.AutoSize = true;
            lblOpenBalance.Location = new Point(195, 202);
            lblOpenBalance.Name = "lblOpenBalance";
            lblOpenBalance.Size = new Size(143, 15);
            lblOpenBalance.TabIndex = 36;
            lblOpenBalance.Text = "Statement Open Balance:";
            // 
            // lblCloseBalance
            // 
            lblCloseBalance.AutoSize = true;
            lblCloseBalance.Location = new Point(207, 534);
            lblCloseBalance.Name = "lblCloseBalance";
            lblCloseBalance.Size = new Size(143, 15);
            lblCloseBalance.TabIndex = 37;
            lblCloseBalance.Text = "Statement Open Balance:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(149, 578);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(62, 38);
            btnClose.TabIndex = 38;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // IssueBankStatementFromStep2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1271, 645);
            Controls.Add(btnClose);
            Controls.Add(lblCloseBalance);
            Controls.Add(lblOpenBalance);
            Controls.Add(btnSaveReport);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dgvBankTransactions);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "IssueBankStatementFromStep2";
            Text = "IssueBankStatementFromStep2";
            Load += IssueBankStatementFromStep2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBankTransactions).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBankTransactions;
        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dtpDateFrom;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpDateTo;
        private Label lblBankName;
        private Label lblAccName;
        private Button btnGenerate;
        private Label lblAccCurrency;
        private Label label9;
        private Label label10;
        private Button btnSaveReport;
        private Label lblOpenBalance;
        private Label lblCloseBalance;
        private Button btnClose;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn id;
    }
}