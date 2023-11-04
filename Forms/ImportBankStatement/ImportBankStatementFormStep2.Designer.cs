namespace PLApp.Forms.ImportBankStatement
{
    partial class ImportBankStatementFormStep2
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
            Column10 = new DataGridViewComboBoxColumn();
            label2 = new Label();
            label3 = new Label();
            txtExcelPath = new TextBox();
            btnLoadData = new Button();
            btnBrowse = new Button();
            btnStartImport = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBankTransactions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-2, 12);
            label1.Name = "label1";
            label1.Size = new Size(1273, 32);
            label1.TabIndex = 3;
            label1.Text = "Import Bank Transaction";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvBankTransactions
            // 
            dgvBankTransactions.AllowUserToAddRows = false;
            dgvBankTransactions.BackgroundColor = Color.White;
            dgvBankTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankTransactions.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dgvBankTransactions.Location = new Point(30, 145);
            dgvBankTransactions.MultiSelect = false;
            dgvBankTransactions.Name = "dgvBankTransactions";
            dgvBankTransactions.RowHeadersVisible = false;
            dgvBankTransactions.RowTemplate.Height = 25;
            dgvBankTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBankTransactions.Size = new Size(1210, 366);
            dgvBankTransactions.TabIndex = 4;
            dgvBankTransactions.CellClick += dgvBankTransactions_CellClick;
            dgvBankTransactions.CellValueChanged += dgvBankTransactions_CellValueChanged;
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
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Recipient Name";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Recipient Account";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Details";
            Column7.MinimumWidth = 150;
            Column7.Name = "Column7";
            Column7.Width = 150;
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
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column10.HeaderText = "Has Conflict";
            Column10.Items.AddRange(new object[] { "True", "False" });
            Column10.MinimumWidth = 80;
            Column10.Name = "Column10";
            Column10.Resizable = DataGridViewTriState.False;
            Column10.SortMode = DataGridViewColumnSortMode.Automatic;
            Column10.Width = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 127);
            label2.Name = "label2";
            label2.Size = new Size(162, 15);
            label2.TabIndex = 17;
            label2.Text = "Please Verify Imported Data.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 66);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 18;
            label3.Text = "Bank Statement Path";
            // 
            // txtExcelPath
            // 
            txtExcelPath.Location = new Point(155, 58);
            txtExcelPath.Name = "txtExcelPath";
            txtExcelPath.Size = new Size(273, 23);
            txtExcelPath.TabIndex = 22;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(112, 84);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(76, 27);
            btnLoadData.TabIndex = 23;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(30, 84);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(76, 27);
            btnBrowse.TabIndex = 24;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnStartImport
            // 
            btnStartImport.Location = new Point(30, 517);
            btnStartImport.Name = "btnStartImport";
            btnStartImport.Size = new Size(128, 36);
            btnStartImport.TabIndex = 25;
            btnStartImport.Text = "Start  Import";
            btnStartImport.UseVisualStyleBackColor = true;
            btnStartImport.Click += btnStartImport_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(164, 517);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(72, 36);
            btnClose.TabIndex = 26;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ImportBankStatementFormStep2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1271, 645);
            Controls.Add(btnClose);
            Controls.Add(btnStartImport);
            Controls.Add(btnBrowse);
            Controls.Add(btnLoadData);
            Controls.Add(txtExcelPath);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvBankTransactions);
            Controls.Add(label1);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ImportBankStatementFormStep2";
            Text = "ImportBankStatementFormStep2";
            Load += ImportBankStatementFormStep2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBankTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvBankTransactions;
        private Label label2;
        private Label label3;
        private TextBox txtExcelPath;
        private Button btnLoadData;
        private Button btnBrowse;
        private Button btnStartImport;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewComboBoxColumn Column10;
        private Button btnClose;
    }
}