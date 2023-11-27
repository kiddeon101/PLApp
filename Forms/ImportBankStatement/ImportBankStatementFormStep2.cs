using Microsoft.IdentityModel.Tokens;
using PLApp.Constants;
using PLApp.Controller;
using PLApp.Controller.BankAccountManagement;
using PLApp.Controller.ImportBankStatement;
using PLApp.Entity;
using PLApp.Entity.TableEntity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PLApp.Forms.ImportBankStatement
{
    public partial class ImportBankStatementFormStep2 : Form
    {
        private FormController formController;
        private ImportBankStatementController importBankStatementController;
        private TableContext tableContext;
        internal ImportBankStatementFormStep2(FormController formController, ImportBankStatementController importBankStatementController)
        {
            this.importBankStatementController = importBankStatementController;
            this.tableContext = new TableContext();
            this.formController = formController;
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Statement";
            ofd.Filter = "Excel Files(*.xlsx) | *.xlsx";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtExcelPath.Text = ofd.FileName;
            }
        }

        private async void btnLoadData_Click(object sender, EventArgs e)
        {
            List<BankTransaction> bankTransactions = new List<BankTransaction>();

            if (!txtExcelPath.Text.IsNullOrEmpty())
            {
                if (cmbImportType.SelectedIndex == 0)
                {
                    //Process China bank statement
                    await Task.Run(() =>
                    {
                        bankTransactions = importBankStatementController.getDataFromExcel(txtExcelPath.Text);

                    });

                }
                else if (cmbImportType.SelectedIndex == 1)
                {
                    //Process USD Account Statement                 
                    bankTransactions = importBankStatementController.getStatementFromExcel(txtExcelPath.Text, cmbImportType.SelectedIndex);

                    dgvBankTransactions.Rows.Clear();
                }
                dgvBankTransactions.Rows.Clear();
                int rowCnt = 0;
                foreach (BankTransaction transaction in bankTransactions)
                {
                    dgvBankTransactions.Rows.Add(transaction.transactionDate.ToString("dd/MM/yyyy"), transaction.transactionType, transaction.documentCategory, transaction.voucherNumber, transaction.recipientName, transaction.recipientAccountNum, transaction.details, transaction.outwardAmount, transaction.inwardAmount, transaction.hasConflict.ToString());


                    DataGridViewRow row = (DataGridViewRow)dgvBankTransactions.Rows[rowCnt];
                    if (transaction.hasConflict)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    rowCnt++;
                }


            }
        }

        private void dgvBankTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBankTransactions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBankTransactions.Rows.Count > 0)
            {
                if (e.ColumnIndex == 9)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvBankTransactions.Rows[e.RowIndex];
                    //check if changed color
                    if (dgvBankTransactions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "True")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }

        }

        private void ImportBankStatementFormStep2_Load(object sender, EventArgs e)
        {
            lblAccountName.Text = importBankStatementController.bankAccount.AccountName;
            lblAccountNumber.Text = importBankStatementController.bankAccount.BankName;
            lblCurrency.Text = importBankStatementController.bankAccount.AccountCurrency;
            cmbImportType.SelectedIndex = 0;
        }

        private void btnStartImport_Click(object sender, EventArgs e)
        {
            List<BankTransaction> bankTransactions = new List<BankTransaction>();
            foreach (DataGridViewRow dataGridViewRow in dgvBankTransactions.Rows)
            {
                bool hasConflict = CommonTools.ConvertToBool(dataGridViewRow.Cells[9].Value);
                if (!hasConflict)
                {
                    BankTransaction transaction = new BankTransaction();
                    transaction.transactionDate = CommonTools.ConvertToDate(dataGridViewRow.Cells[0].Value);
                    transaction.transactionType = CommonTools.ConvertToString(dataGridViewRow.Cells[1].Value);
                    transaction.documentCategory = CommonTools.ConvertToInt(dataGridViewRow.Cells[2].Value);
                    transaction.voucherNumber = CommonTools.ConvertToInt(dataGridViewRow.Cells[3].Value);
                    transaction.recipientName = CommonTools.ConvertToString(dataGridViewRow.Cells[4].Value);
                    transaction.recipientAccountNum = CommonTools.ConvertToString(dataGridViewRow.Cells[5].Value);
                    transaction.details = CommonTools.ConvertToString(dataGridViewRow.Cells[6].Value);
                    transaction.outwardAmount = CommonTools.ConvertToDouble(dataGridViewRow.Cells[7].Value);
                    transaction.inwardAmount = CommonTools.ConvertToDouble(dataGridViewRow.Cells[8].Value);
                    transaction.bankAccountId = importBankStatementController.bankAccount.Id;
                    transaction.statementType = cmbImportType.SelectedIndex;
                    bankTransactions.Add(transaction);
                }
            }
            importBankStatementController.saveStatement(bankTransactions);
            MessageBox.Show("Successfully Saved Bank Transactions");
            formController.mainTabControll(TAB_ACTION.REMOVE);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel the process?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formController.mainTabControll(TAB_ACTION.REMOVE);
            }
        }
    }
}
