using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using PLApp.Entity;
using PLApp.Entity.TableEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PLApp.Forms.DBBackupRestore
{
    public partial class DBBackupRestoreForm : Form
    {
        SqlConnection conn = new SqlConnection();
        string servenName = "";
        string username = "";
        string password = "";
        public DBBackupRestoreForm()
        {
            InitializeComponent();
        }

        private void btnBackupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBackupLoc.Text = folderBrowserDialog.SelectedPath;
                btn_backup.Enabled = true;
            }
        }

        public void loadXML()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config.xml");
                var serverNode = doc.DocumentElement.SelectSingleNode("/server").ChildNodes;
                servenName = serverNode.Item(0).InnerText;
                username = serverNode.Item(1).InnerText;
                password = serverNode.Item(2).InnerText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load config data");
            }

        }

        private void DBBackupRestoreForm_Load(object sender, EventArgs e)
        {
            loadXML();
            string sqlConnString = string.Format("Server={0};Database=PLAppDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;User Id={1}; Password={2};MultipleActiveResultSets=true", servenName, username, password);
            conn = new SqlConnection(sqlConnString);
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            string database = conn.Database.ToString();
            if (txtBackupLoc.Text == string.Empty)
            {
                MessageBox.Show("Please enter backup file loc");
            }
            else
            {
                string dbName = "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss");


                using (TableContext context= new TableContext())
                {
                    DBBackupHistory dBBackupHistory = new DBBackupHistory();
                    dBBackupHistory.backupDate = DateTime.Now;
                    dBBackupHistory.fileName = dbName;
                    context.BackupHistory.Add(dBBackupHistory);
                    context.SaveChanges();
                }
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK= '" + txtBackupLoc.Text + "\\" + dbName + ".bak'";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Database backuped successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    btn_backup.Enabled = false;
                }


            }
        }

        private void btnRestoreBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQL SERVER database backup files|*.bak";
            openFileDialog.Title = "Database Restore";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtRestoreLoc.Text = openFileDialog.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtRestoreLoc.Text.IsNullOrEmpty())
            {
                return;
            }
            string filename = Path.GetFileName(txtRestoreLoc.Text).Replace(".bak","");

            //import latest version
            //bool isLatest = false;
            //try
            //{
            //    using (TableContext context = new TableContext())
            //    {
            //        isLatest = context.BackupHistory.OrderBy(i => i.backupDate).Last().fileName == filename || context.BackupHistory.Count() == 0;
            //        if (!isLatest)
            //        {
            //            MessageBox.Show("Unable to restore DB since it is not the newest version");
            //            return;
            //        }
            //    }
            //}catch(Exception ex)
            //{

            //}
            

            string database = conn.Database.ToString();
            conn.Open();
            try
            {
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, conn);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtRestoreLoc.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, conn);
                cmd2.ExecuteNonQuery();


                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, conn);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Finished Restoring Database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
