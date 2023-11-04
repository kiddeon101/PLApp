namespace PLApp
{
    partial class PLApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbcMain = new TabControl();
            tbpDashboard = new TabPage();
            label1 = new Label();
            btnReports = new Button();
            btnOpenPriceOffer = new Button();
            btnOpenInvoice = new Button();
            btnUpdateTaskList = new Button();
            btnUpdateCompanyInformation = new Button();
            tbpContent = new TabPage();
            pnlContent = new Panel();
            lblContentTitle = new Label();
            tbcMain.SuspendLayout();
            tbpDashboard.SuspendLayout();
            tbpContent.SuspendLayout();
            SuspendLayout();
            // 
            // tbcMain
            // 
            tbcMain.Controls.Add(tbpDashboard);
            tbcMain.Controls.Add(tbpContent);
            tbcMain.Location = new Point(0, 0);
            tbcMain.Margin = new Padding(0);
            tbcMain.Name = "tbcMain";
            tbcMain.Padding = new Point(0, 0);
            tbcMain.SelectedIndex = 0;
            tbcMain.Size = new Size(1272, 727);
            tbcMain.TabIndex = 0;
            // 
            // tbpDashboard
            // 
            tbpDashboard.BackColor = Color.White;
            tbpDashboard.Controls.Add(label1);
            tbpDashboard.Controls.Add(btnReports);
            tbpDashboard.Controls.Add(btnOpenPriceOffer);
            tbpDashboard.Controls.Add(btnOpenInvoice);
            tbpDashboard.Controls.Add(btnUpdateTaskList);
            tbpDashboard.Controls.Add(btnUpdateCompanyInformation);
            tbpDashboard.Location = new Point(4, 24);
            tbpDashboard.Name = "tbpDashboard";
            tbpDashboard.Padding = new Padding(3);
            tbpDashboard.Size = new Size(1264, 699);
            tbpDashboard.TabIndex = 0;
            tbpDashboard.Text = "Dasboard";
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 40);
            label1.Name = "label1";
            label1.Size = new Size(1264, 32);
            label1.TabIndex = 29;
            label1.Text = "P&&L App Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(566, 200);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(136, 58);
            btnReports.TabIndex = 27;
            btnReports.Text = "Issue Detailed Transaction List";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnOpenPriceOffer
            // 
            btnOpenPriceOffer.Location = new Point(414, 200);
            btnOpenPriceOffer.Name = "btnOpenPriceOffer";
            btnOpenPriceOffer.Size = new Size(136, 58);
            btnOpenPriceOffer.TabIndex = 26;
            btnOpenPriceOffer.Text = "Update Detailed Transaction List";
            btnOpenPriceOffer.UseVisualStyleBackColor = true;
            // 
            // btnOpenInvoice
            // 
            btnOpenInvoice.Location = new Point(718, 126);
            btnOpenInvoice.Name = "btnOpenInvoice";
            btnOpenInvoice.Size = new Size(136, 58);
            btnOpenInvoice.TabIndex = 25;
            btnOpenInvoice.Text = "Issue Bank Account Statement";
            btnOpenInvoice.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTaskList
            // 
            btnUpdateTaskList.Location = new Point(566, 126);
            btnUpdateTaskList.Name = "btnUpdateTaskList";
            btnUpdateTaskList.Size = new Size(136, 58);
            btnUpdateTaskList.TabIndex = 24;
            btnUpdateTaskList.Text = "Import Bank Account Update File";
            btnUpdateTaskList.UseVisualStyleBackColor = true;
            btnUpdateTaskList.Click += btnUpdateTaskList_Click;
            // 
            // btnUpdateCompanyInformation
            // 
            btnUpdateCompanyInformation.Location = new Point(414, 126);
            btnUpdateCompanyInformation.Name = "btnUpdateCompanyInformation";
            btnUpdateCompanyInformation.Size = new Size(136, 58);
            btnUpdateCompanyInformation.TabIndex = 23;
            btnUpdateCompanyInformation.Text = "Bank Account Management";
            btnUpdateCompanyInformation.UseVisualStyleBackColor = true;
            btnUpdateCompanyInformation.Click += btnUpdateCompanyInformation_Click;
            // 
            // tbpContent
            // 
            tbpContent.BackColor = Color.White;
            tbpContent.Controls.Add(pnlContent);
            tbpContent.Controls.Add(lblContentTitle);
            tbpContent.Location = new Point(4, 24);
            tbpContent.Name = "tbpContent";
            tbpContent.Padding = new Padding(3);
            tbpContent.Size = new Size(1264, 699);
            tbpContent.TabIndex = 1;
            tbpContent.Text = "Content";
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(0, 54);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1263, 645);
            pnlContent.TabIndex = 26;
            // 
            // lblContentTitle
            // 
            lblContentTitle.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblContentTitle.Location = new Point(2, 10);
            lblContentTitle.Name = "lblContentTitle";
            lblContentTitle.Size = new Size(1262, 32);
            lblContentTitle.TabIndex = 25;
            lblContentTitle.Text = "[title]";
            lblContentTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PLApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1271, 727);
            Controls.Add(tbcMain);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            MaximumSize = new Size(1287, 766);
            MinimumSize = new Size(1287, 766);
            Name = "PLApp";
            Text = "P&L App";
            Load += PLApp_Load;
            tbcMain.ResumeLayout(false);
            tbpDashboard.ResumeLayout(false);
            tbpContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcMain;
        private TabPage tbpDashboard;
        private TabPage tbpContent;
        private Label label1;
        private Button btnReports;
        private Button btnOpenPriceOffer;
        private Button btnOpenInvoice;
        private Button btnUpdateTaskList;
        private Button btnUpdateCompanyInformation;
        private Label lblContentTitle;
        private Panel pnlContent;
    }
}