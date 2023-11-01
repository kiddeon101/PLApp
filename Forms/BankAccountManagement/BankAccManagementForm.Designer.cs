namespace PLApp.Forms.BankAccountManagement
{
    partial class BankAccManagementForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dgvBankAccounts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            update = new DataGridViewButtonColumn();
            del = new DataGridViewButtonColumn();
            label2 = new Label();
            txtAccName = new TextBox();
            btnAction = new Button();
            TimerUserInput = new System.Windows.Forms.Timer(components);
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBankAccounts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-1, 10);
            label1.Name = "label1";
            label1.Size = new Size(1272, 32);
            label1.TabIndex = 1;
            label1.Text = "Bank Management Information Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvBankAccounts
            // 
            dgvBankAccounts.AllowUserToAddRows = false;
            dgvBankAccounts.BackgroundColor = Color.White;
            dgvBankAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankAccounts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, id, update, del });
            dgvBankAccounts.Location = new Point(67, 105);
            dgvBankAccounts.MultiSelect = false;
            dgvBankAccounts.Name = "dgvBankAccounts";
            dgvBankAccounts.ReadOnly = true;
            dgvBankAccounts.RowHeadersVisible = false;
            dgvBankAccounts.RowTemplate.Height = 25;
            dgvBankAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBankAccounts.Size = new Size(1134, 366);
            dgvBankAccounts.TabIndex = 2;
            dgvBankAccounts.CellClick += dgvBankAccounts_CellClick;
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
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // update
            // 
            update.HeaderText = "";
            update.MinimumWidth = 50;
            update.Name = "update";
            update.ReadOnly = true;
            update.Text = "Update";
            update.UseColumnTextForButtonValue = true;
            update.Width = 50;
            // 
            // del
            // 
            del.HeaderText = "";
            del.MinimumWidth = 50;
            del.Name = "del";
            del.ReadOnly = true;
            del.Text = "Delete";
            del.UseColumnTextForButtonValue = true;
            del.Width = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 74);
            label2.Name = "label2";
            label2.Size = new Size(251, 15);
            label2.TabIndex = 16;
            label2.Text = "Search Account Name(Press Enter to Search):";
            // 
            // txtAccName
            // 
            txtAccName.Location = new Point(320, 71);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(159, 23);
            txtAccName.TabIndex = 21;
            txtAccName.KeyDown += txtAccName_KeyDown;
            // 
            // btnAction
            // 
            btnAction.Location = new Point(67, 486);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(128, 36);
            btnAction.TabIndex = 22;
            btnAction.Text = "Add Bank Account";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1119, 71);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 28);
            btnClose.TabIndex = 23;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // BankAccManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1271, 645);
            Controls.Add(btnClose);
            Controls.Add(btnAction);
            Controls.Add(txtAccName);
            Controls.Add(label2);
            Controls.Add(dgvBankAccounts);
            Controls.Add(label1);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BankAccManagementForm";
            Text = "BankAccManagementForm";
            Load += BankAccManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBankAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvBankAccounts;
        private Label label2;
        private TextBox txtAccName;
        private Button btnAction;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn id;
        private DataGridViewButtonColumn update;
        private DataGridViewButtonColumn del;
        private System.Windows.Forms.Timer TimerUserInput;
        private Button btnClose;
    }
}