namespace PLApp.Forms.UpdateDetailsTransactions
{
    partial class BankDetailedTransactionFromStep2
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
            label1 = new Label();
            dgvBankTransactions = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label2 = new Label();
            cmdMonths = new ComboBox();
            lblAcountName = new Label();
            btnGenerate = new Button();
            btnNext = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBankTransactions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(1272, 32);
            label1.TabIndex = 28;
            label1.Text = "Select Bank Transaction";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvBankTransactions
            // 
            dgvBankTransactions.AllowUserToAddRows = false;
            dgvBankTransactions.BackgroundColor = Color.White;
            dgvBankTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankTransactions.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, id });
            dgvBankTransactions.Location = new Point(35, 149);
            dgvBankTransactions.MultiSelect = false;
            dgvBankTransactions.Name = "dgvBankTransactions";
            dgvBankTransactions.RowHeadersVisible = false;
            dgvBankTransactions.RowTemplate.Height = 25;
            dgvBankTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBankTransactions.Size = new Size(1210, 312);
            dgvBankTransactions.TabIndex = 29;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "Transaction Date";
            Column1.MinimumWidth = 100;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.False;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.HeaderText = "Transaction Type";
            Column2.MinimumWidth = 120;
            Column2.Name = "Column2";
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Document Category";
            Column3.MinimumWidth = 100;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Voucher Number";
            Column4.MinimumWidth = 100;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column5.HeaderText = "Recipient Name";
            Column5.Name = "Column5";
            Column5.Width = 120;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column6.HeaderText = "Recipient Account";
            Column6.Name = "Column6";
            Column6.Width = 130;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Details";
            Column7.MinimumWidth = 150;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Outward Amount";
            Column8.MinimumWidth = 100;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Inward Amount";
            Column9.MinimumWidth = 100;
            Column9.Name = "Column9";
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 84);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 30;
            label4.Text = "Select Month:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 58);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 31;
            label2.Text = "Account Name:";
            // 
            // cmdMonths
            // 
            cmdMonths.FormattingEnabled = true;
            cmdMonths.Items.AddRange(new object[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" });
            cmdMonths.Location = new Point(129, 81);
            cmdMonths.Name = "cmdMonths";
            cmdMonths.Size = new Size(121, 23);
            cmdMonths.TabIndex = 32;
            // 
            // lblAcountName
            // 
            lblAcountName.AutoSize = true;
            lblAcountName.Location = new Point(129, 58);
            lblAcountName.Name = "lblAcountName";
            lblAcountName.Size = new Size(91, 15);
            lblAcountName.TabIndex = 33;
            lblAcountName.Text = "lblAcountName";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(35, 113);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 34;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(35, 479);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 35;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // button2
            // 
            button2.Location = new Point(129, 479);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 36;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BankDetailedTransactionFromStep2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1271, 645);
            Controls.Add(button2);
            Controls.Add(btnNext);
            Controls.Add(btnGenerate);
            Controls.Add(lblAcountName);
            Controls.Add(cmdMonths);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(dgvBankTransactions);
            Controls.Add(label1);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BankDetailedTransactionFromStep2";
            Text = "BankDetailedTransactionFromStep2";
            Load += BankDetailedTransactionFromStep2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBankTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvBankTransactions;
        private Label label4;
        private Label label2;
        private ComboBox cmdMonths;
        private Label lblAcountName;
        private Button btnGenerate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn id;
        private Button btnNext;
        private Button button2;
    }
}