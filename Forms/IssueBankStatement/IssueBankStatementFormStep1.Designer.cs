namespace PLApp.Forms.IssueBankStatement
{
    partial class IssueBankStatementFormStep1
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
            button1 = new Button();
            btnAction = new Button();
            dgvBankAccounts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            txtAccName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBankAccounts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(1272, 32);
            label1.TabIndex = 3;
            label1.Text = "Select Bank Account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(147, 525);
            button1.Name = "button1";
            button1.Size = new Size(79, 26);
            button1.TabIndex = 31;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAction
            // 
            btnAction.Location = new Point(62, 525);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(79, 26);
            btnAction.TabIndex = 30;
            btnAction.Text = "Next";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // dgvBankAccounts
            // 
            dgvBankAccounts.AllowUserToAddRows = false;
            dgvBankAccounts.BackgroundColor = Color.White;
            dgvBankAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankAccounts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, id });
            dgvBankAccounts.Location = new Point(62, 92);
            dgvBankAccounts.MultiSelect = false;
            dgvBankAccounts.Name = "dgvBankAccounts";
            dgvBankAccounts.ReadOnly = true;
            dgvBankAccounts.RowHeadersVisible = false;
            dgvBankAccounts.RowTemplate.Height = 25;
            dgvBankAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBankAccounts.Size = new Size(1134, 427);
            dgvBankAccounts.TabIndex = 29;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.HeaderText = "Account Id";
            Column1.MinimumWidth = 100;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.HeaderText = "Account Name";
            Column2.MinimumWidth = 120;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Bank Name";
            Column3.MinimumWidth = 100;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Account Currency";
            Column4.MinimumWidth = 150;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Account Open Balance Amount";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Account Open Balance Date";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column7.HeaderText = "Balance";
            Column7.MinimumWidth = 150;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 150;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // txtAccName
            // 
            txtAccName.Location = new Point(315, 59);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(159, 23);
            txtAccName.TabIndex = 28;
            txtAccName.KeyDown += txtAccName_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 62);
            label2.Name = "label2";
            label2.Size = new Size(251, 15);
            label2.TabIndex = 27;
            label2.Text = "Search Account Name(Press Enter to Search):";
            // 
            // IssueBankStatementFormStep1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1271, 645);
            Controls.Add(button1);
            Controls.Add(btnAction);
            Controls.Add(dgvBankAccounts);
            Controls.Add(txtAccName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "IssueBankStatementFormStep1";
            Text = "IssueBankStatementFormStep1";
            Load += IssueBankStatementFormStep1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBankAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnAction;
        private DataGridView dgvBankAccounts;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn id;
        private TextBox txtAccName;
        private Label label2;
    }
}