namespace PLApp.Forms.BankAccountManagement
{
    partial class AddUpdateBankAccount
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
            txtOpenBalanceAmount = new TextBox();
            txtAccCurrency = new TextBox();
            txtBankName = new TextBox();
            txtAccName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAction = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            dtpOpenAccDate = new DateTimePicker();
            cmbCurrency = new ComboBox();
            SuspendLayout();
            // 
            // txtOpenBalanceAmount
            // 
            txtOpenBalanceAmount.Location = new Point(236, 168);
            txtOpenBalanceAmount.Name = "txtOpenBalanceAmount";
            txtOpenBalanceAmount.Size = new Size(137, 23);
            txtOpenBalanceAmount.TabIndex = 23;
            // 
            // txtAccCurrency
            // 
            txtAccCurrency.Location = new Point(236, 139);
            txtAccCurrency.Name = "txtAccCurrency";
            txtAccCurrency.Size = new Size(60, 23);
            txtAccCurrency.TabIndex = 22;
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(236, 110);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(137, 23);
            txtBankName.TabIndex = 21;
            // 
            // txtAccName
            // 
            txtAccName.Location = new Point(236, 81);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(137, 23);
            txtAccName.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 203);
            label6.Name = "label6";
            label6.Size = new Size(161, 15);
            label6.TabIndex = 19;
            label6.Text = "Account Open Balance Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 171);
            label5.Name = "label5";
            label5.Size = new Size(178, 15);
            label5.TabIndex = 18;
            label5.Text = "Account Open Balance Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 142);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 17;
            label4.Text = "Account Currency:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 113);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 16;
            label3.Text = "Bank Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 84);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 15;
            label2.Text = "Account Name:";
            // 
            // btnAction
            // 
            btnAction.Location = new Point(49, 245);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(75, 23);
            btnAction.TabIndex = 14;
            btnAction.Text = "Save";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(135, 245);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(504, 32);
            lblTitle.TabIndex = 26;
            lblTitle.Text = "[Title]";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpOpenAccDate
            // 
            dtpOpenAccDate.Location = new Point(236, 197);
            dtpOpenAccDate.Name = "dtpOpenAccDate";
            dtpOpenAccDate.Size = new Size(200, 23);
            dtpOpenAccDate.TabIndex = 27;
            // 
            // cmbCurrency
            // 
            cmbCurrency.FormattingEnabled = true;
            cmbCurrency.Items.AddRange(new object[] { "USD", "CNY" });
            cmbCurrency.Location = new Point(302, 139);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new Size(121, 23);
            cmbCurrency.TabIndex = 28;
            // 
            // AddUpdateBankAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(503, 349);
            Controls.Add(cmbCurrency);
            Controls.Add(dtpOpenAccDate);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(txtOpenBalanceAmount);
            Controls.Add(txtAccCurrency);
            Controls.Add(txtBankName);
            Controls.Add(txtAccName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAction);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            Name = "AddUpdateBankAccount";
            Text = "AddUpdateBankAccount";
            Load += AddUpdateBankAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtOpenBalanceAmount;
        private TextBox txtAccCurrency;
        private TextBox txtBankName;
        private TextBox txtAccName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAction;
        private Button btnCancel;
        private Label lblTitle;
        private DateTimePicker dtpOpenAccDate;
        private ComboBox cmbCurrency;
    }
}