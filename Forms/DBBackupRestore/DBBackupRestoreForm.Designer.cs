namespace PLApp.Forms.DBBackupRestore
{
    partial class DBBackupRestoreForm
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
            groupBox3 = new GroupBox();
            btnRestore = new Button();
            label1 = new Label();
            txtRestoreLoc = new TextBox();
            btnRestoreBrowse = new Button();
            groupBox1 = new GroupBox();
            btn_backup = new Button();
            label2 = new Label();
            txtBackupLoc = new TextBox();
            btnBackupBrowse = new Button();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRestore);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtRestoreLoc);
            groupBox3.Controls.Add(btnRestoreBrowse);
            groupBox3.Location = new Point(58, 161);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(489, 100);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Restore Database";
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(277, 58);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(79, 23);
            btnRestore.TabIndex = 14;
            btnRestore.Text = "Restore";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 33);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 12;
            label1.Text = "Location:";
            // 
            // txtRestoreLoc
            // 
            txtRestoreLoc.Location = new Point(118, 30);
            txtRestoreLoc.Name = "txtRestoreLoc";
            txtRestoreLoc.Size = new Size(139, 23);
            txtRestoreLoc.TabIndex = 11;
            // 
            // btnRestoreBrowse
            // 
            btnRestoreBrowse.Location = new Point(277, 29);
            btnRestoreBrowse.Name = "btnRestoreBrowse";
            btnRestoreBrowse.Size = new Size(79, 23);
            btnRestoreBrowse.TabIndex = 13;
            btnRestoreBrowse.Text = "Browse";
            btnRestoreBrowse.UseVisualStyleBackColor = true;
            btnRestoreBrowse.Click += btnRestoreBrowse_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_backup);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBackupLoc);
            groupBox1.Controls.Add(btnBackupBrowse);
            groupBox1.Location = new Point(58, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 100);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Backup Database";
            // 
            // btn_backup
            // 
            btn_backup.Location = new Point(277, 58);
            btn_backup.Name = "btn_backup";
            btn_backup.Size = new Size(79, 23);
            btn_backup.TabIndex = 14;
            btn_backup.Text = "Backup";
            btn_backup.UseVisualStyleBackColor = true;
            btn_backup.Click += btn_backup_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 33);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 12;
            label2.Text = "Location:";
            // 
            // txtBackupLoc
            // 
            txtBackupLoc.Location = new Point(118, 30);
            txtBackupLoc.Name = "txtBackupLoc";
            txtBackupLoc.Size = new Size(139, 23);
            txtBackupLoc.TabIndex = 11;
            // 
            // btnBackupBrowse
            // 
            btnBackupBrowse.Location = new Point(277, 29);
            btnBackupBrowse.Name = "btnBackupBrowse";
            btnBackupBrowse.Size = new Size(79, 23);
            btnBackupBrowse.TabIndex = 13;
            btnBackupBrowse.Text = "Browse";
            btnBackupBrowse.UseVisualStyleBackColor = true;
            btnBackupBrowse.Click += btnBackupBrowse_Click;
            // 
            // DBBackupRestoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 365);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "DBBackupRestoreForm";
            Text = "DBBackupRestoreForm";
            Load += DBBackupRestoreForm_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button btnRestore;
        private Label label1;
        private TextBox txtRestoreLoc;
        private Button btnRestoreBrowse;
        private GroupBox groupBox1;
        private Button btn_backup;
        private Label label2;
        private TextBox txtBackupLoc;
        private Button btnBackupBrowse;
    }
}