namespace PLApp.Forms.UpdateDetailsTransactions
{
    partial class BankDetailedTransactionFromStep3
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
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTranactionId = new Label();
            lblTransactionType = new Label();
            lblTransactionAmount = new Label();
            dgvBankDetailedTransactions = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewButtonColumn();
            Column11 = new DataGridViewButtonColumn();
            btnAdd = new Button();
            label8 = new Label();
            lblSumDetailedTransaction = new Label();
            btnFinish = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBankDetailedTransactions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-2, 9);
            label1.Name = "label1";
            label1.Size = new Size(1271, 32);
            label1.TabIndex = 29;
            label1.Text = "Detailed Transactions";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 61);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 31;
            label4.Text = "Transaction Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 79);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 32;
            label2.Text = "Transaction Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 99);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 33;
            label3.Text = "Transaction Amount:";
            // 
            // lblTranactionId
            // 
            lblTranactionId.AutoSize = true;
            lblTranactionId.Location = new Point(151, 61);
            lblTranactionId.Name = "lblTranactionId";
            lblTranactionId.Size = new Size(88, 15);
            lblTranactionId.TabIndex = 34;
            lblTranactionId.Text = "Transaction Id:";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Location = new Point(151, 79);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(88, 15);
            lblTransactionType.TabIndex = 35;
            lblTransactionType.Text = "Transaction Id:";
            // 
            // lblTransactionAmount
            // 
            lblTransactionAmount.AutoSize = true;
            lblTransactionAmount.Location = new Point(151, 99);
            lblTransactionAmount.Name = "lblTransactionAmount";
            lblTransactionAmount.Size = new Size(88, 15);
            lblTransactionAmount.TabIndex = 36;
            lblTransactionAmount.Text = "Transaction Id:";
            // 
            // dgvBankDetailedTransactions
            // 
            dgvBankDetailedTransactions.AllowUserToAddRows = false;
            dgvBankDetailedTransactions.BackgroundColor = Color.White;
            dgvBankDetailedTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankDetailedTransactions.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column12, Column10, Column11 });
            dgvBankDetailedTransactions.Location = new Point(22, 126);
            dgvBankDetailedTransactions.MultiSelect = false;
            dgvBankDetailedTransactions.Name = "dgvBankDetailedTransactions";
            dgvBankDetailedTransactions.RowHeadersVisible = false;
            dgvBankDetailedTransactions.RowTemplate.Height = 25;
            dgvBankDetailedTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBankDetailedTransactions.Size = new Size(1203, 382);
            dgvBankDetailedTransactions.TabIndex = 37;
            dgvBankDetailedTransactions.CellClick += dgvBankDetailedTransactions_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "Category";
            Column1.MinimumWidth = 100;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.False;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.HeaderText = "Amount";
            Column2.MinimumWidth = 90;
            Column2.Name = "Column2";
            Column2.Width = 90;
            // 
            // Column3
            // 
            Column3.HeaderText = "For the Acc of Year";
            Column3.MinimumWidth = 95;
            Column3.Name = "Column3";
            Column3.Width = 95;
            // 
            // Column4
            // 
            Column4.HeaderText = "For the Acc of Month";
            Column4.MinimumWidth = 95;
            Column4.Name = "Column4";
            Column4.Width = 95;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column5.HeaderText = "Customer";
            Column5.MinimumWidth = 95;
            Column5.Name = "Column5";
            Column5.Width = 95;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column6.HeaderText = "Project #";
            Column6.MinimumWidth = 95;
            Column6.Name = "Column6";
            Column6.Width = 95;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column7.HeaderText = "Invoice #";
            Column7.MinimumWidth = 95;
            Column7.Name = "Column7";
            Column7.Width = 95;
            // 
            // Column8
            // 
            Column8.HeaderText = "Purchase Order #";
            Column8.MinimumWidth = 130;
            Column8.Name = "Column8";
            Column8.Width = 130;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column9.HeaderText = "Details";
            Column9.MinimumWidth = 100;
            Column9.Name = "Column9";
            // 
            // Column12
            // 
            Column12.HeaderText = "id";
            Column12.Name = "Column12";
            Column12.Visible = false;
            // 
            // Column10
            // 
            Column10.HeaderText = "";
            Column10.MinimumWidth = 60;
            Column10.Name = "Column10";
            Column10.Text = "Update";
            Column10.UseColumnTextForButtonValue = true;
            Column10.Width = 60;
            // 
            // Column11
            // 
            Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column11.HeaderText = "";
            Column11.MinimumWidth = 60;
            Column11.Name = "Column11";
            Column11.Text = "Delete";
            Column11.UseColumnTextForButtonValue = true;
            Column11.Width = 60;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(22, 514);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 28);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(365, 61);
            label8.Name = "label8";
            label8.Size = new Size(163, 15);
            label8.TabIndex = 39;
            label8.Text = "Sum of Detailed Transaction:";
            // 
            // lblSumDetailedTransaction
            // 
            lblSumDetailedTransaction.AutoSize = true;
            lblSumDetailedTransaction.Location = new Point(534, 61);
            lblSumDetailedTransaction.Name = "lblSumDetailedTransaction";
            lblSumDetailedTransaction.Size = new Size(88, 15);
            lblSumDetailedTransaction.TabIndex = 40;
            lblSumDetailedTransaction.Text = "Transaction Id:";
            // 
            // btnFinish
            // 
            btnFinish.Location = new Point(117, 514);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(89, 28);
            btnFinish.TabIndex = 41;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(212, 514);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 28);
            btnClose.TabIndex = 42;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // BankDetailedTransactionFromStep3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1271, 645);
            Controls.Add(btnClose);
            Controls.Add(btnFinish);
            Controls.Add(lblSumDetailedTransaction);
            Controls.Add(label8);
            Controls.Add(btnAdd);
            Controls.Add(dgvBankDetailedTransactions);
            Controls.Add(lblTransactionAmount);
            Controls.Add(lblTransactionType);
            Controls.Add(lblTranactionId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BankDetailedTransactionFromStep3";
            Text = "UpdateAddBankDetailedTransactionForm";
            Load += BankDetailedTransactionFromStep3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBankDetailedTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label lblTranactionId;
        private Label lblTransactionType;
        private Label lblTransactionAmount;
        private DataGridView dgvBankDetailedTransactions;
        private Button btnAdd;
        private Label label8;
        private Label lblSumDetailedTransaction;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewButtonColumn Column10;
        private DataGridViewButtonColumn Column11;
        private Button btnFinish;
        private Button btnClose;
    }
}