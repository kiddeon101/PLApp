namespace PLApp.Forms.UpdateDetailsTransactions
{
    partial class DetailedTransactionInfoForm
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
            label2 = new Label();
            lblTitle = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpYear = new DateTimePicker();
            label5 = new Label();
            dtpMonth = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtDetails = new RichTextBox();
            txtPurchaseOrder = new TextBox();
            txtInvoiceNum = new TextBox();
            txtProjectNum = new TextBox();
            txtCustomer = new TextBox();
            lblTransactionType = new Label();
            btnAction = new Button();
            txtAmount = new TextBox();
            txtCategory = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cmbTransactionType = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 55);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 36;
            label2.Text = "Transaction Type:";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(-1, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(600, 32);
            lblTitle.TabIndex = 38;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 83);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 39;
            label1.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 108);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 40;
            label3.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 138);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 41;
            label4.Text = "For the account of year:";
            // 
            // dtpYear
            // 
            dtpYear.CustomFormat = "yyyy";
            dtpYear.Format = DateTimePickerFormat.Custom;
            dtpYear.Location = new Point(200, 132);
            dtpYear.Name = "dtpYear";
            dtpYear.ShowUpDown = true;
            dtpYear.Size = new Size(86, 23);
            dtpYear.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 164);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 43;
            label5.Text = "For the account of Month:";
            // 
            // dtpMonth
            // 
            dtpMonth.CustomFormat = "MM";
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.Location = new Point(200, 158);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.ShowUpDown = true;
            dtpMonth.Size = new Size(86, 23);
            dtpMonth.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 188);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 45;
            label7.Text = "Customer:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 214);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 46;
            label8.Text = "Project Number:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 240);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 47;
            label9.Text = "Invoice Number:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 266);
            label10.Name = "label10";
            label10.Size = new Size(142, 15);
            label10.TabIndex = 48;
            label10.Text = "Pruchase Order Number:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(50, 294);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 49;
            label11.Text = "Details:";
            // 
            // txtDetails
            // 
            txtDetails.Location = new Point(200, 291);
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(235, 72);
            txtDetails.TabIndex = 50;
            txtDetails.Text = "";
            // 
            // txtPurchaseOrder
            // 
            txtPurchaseOrder.Location = new Point(200, 263);
            txtPurchaseOrder.Name = "txtPurchaseOrder";
            txtPurchaseOrder.Size = new Size(125, 23);
            txtPurchaseOrder.TabIndex = 51;
            // 
            // txtInvoiceNum
            // 
            txtInvoiceNum.Location = new Point(200, 237);
            txtInvoiceNum.Name = "txtInvoiceNum";
            txtInvoiceNum.Size = new Size(125, 23);
            txtInvoiceNum.TabIndex = 52;
            // 
            // txtProjectNum
            // 
            txtProjectNum.Location = new Point(200, 211);
            txtProjectNum.Name = "txtProjectNum";
            txtProjectNum.Size = new Size(125, 23);
            txtProjectNum.TabIndex = 53;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(200, 185);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(125, 23);
            txtCustomer.TabIndex = 54;
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Location = new Point(500, 55);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(88, 15);
            lblTransactionType.TabIndex = 57;
            lblTransactionType.Text = "Transaction Id:";
            lblTransactionType.Visible = false;
            // 
            // btnAction
            // 
            btnAction.Location = new Point(51, 387);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(83, 30);
            btnAction.TabIndex = 58;
            btnAction.Text = "Action";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(200, 105);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 23);
            txtAmount.TabIndex = 59;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(200, 80);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(125, 23);
            txtCategory.TabIndex = 60;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Items.AddRange(new object[] { "Incomming", "Outgoing" });
            cmbTransactionType.Location = new Point(200, 51);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(121, 23);
            cmbTransactionType.TabIndex = 61;
            // 
            // DetailedTransactionInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 450);
            Controls.Add(cmbTransactionType);
            Controls.Add(txtCategory);
            Controls.Add(txtAmount);
            Controls.Add(btnAction);
            Controls.Add(lblTransactionType);
            Controls.Add(txtCustomer);
            Controls.Add(txtProjectNum);
            Controls.Add(txtInvoiceNum);
            Controls.Add(txtPurchaseOrder);
            Controls.Add(txtDetails);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpMonth);
            Controls.Add(label5);
            Controls.Add(dtpYear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(label2);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DetailedTransactionInfoForm";
            Text = "DetailedTransactionInfoForm";
            Load += DetailedTransactionInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lblTitle;
        private Label label1;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpYear;
        private Label label5;
        private DateTimePicker dtpMonth;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private RichTextBox txtDetails;
        private TextBox txtPurchaseOrder;
        private TextBox txtInvoiceNum;
        private TextBox txtProjectNum;
        private TextBox txtCustomer;
        private Label lblTransactionType;
        private Button btnAction;
        private TextBox txtAmount;
        private TextBox txtCategory;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cmbTransactionType;
    }
}