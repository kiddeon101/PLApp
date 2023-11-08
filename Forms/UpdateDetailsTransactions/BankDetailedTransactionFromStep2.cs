using PLApp.Constants;
using PLApp.Controller;
using PLApp.Controller.BankAccountManagement;
using PLApp.Controller.BankDetailsTransaction;
using PLApp.Controller.ImportBankStatement;
using PLApp.Controller.IssueBankStatement;
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

namespace PLApp.Forms.UpdateDetailsTransactions
{
    public partial class BankDetailedTransactionFromStep2 : Form
    {
        private FormController formController;
        private ImportBankStatementController bankStatementController;
        private BankDetailedTransactionController detailedTransactionController;
        private TableContext tableContext;
        internal BankDetailedTransactionFromStep2(FormController formController, BankDetailedTransactionController detailedTransactionController)
        {
            this.formController = formController;
            this.bankStatementController = new ImportBankStatementController();
            this.detailedTransactionController = detailedTransactionController;
            this.tableContext = new TableContext();
            InitializeComponent();
        }

        private void BankDetailedTransactionFromStep2_Load(object sender, EventArgs e)
        {
            cmdMonths.SelectedIndex = 0;
            lblAcountName.Text = detailedTransactionController.bankAccount.AccountName;

        }
        private async void loadTable(int accountId, int monthIndex)
        {
            List<BankTransaction> bankTransactions = new List<BankTransaction>();
            await Task.Run(() =>
            {
                bankTransactions = bankStatementController.getBankTransactionByBankAccAndTransactionMonth(accountId, monthIndex);

            });
            dgvBankTransactions.Rows.Clear();
            foreach (BankTransaction bankTransaction in bankTransactions)
            {
                dgvBankTransactions.Rows.Add("TR" + bankTransaction.Id.ToString().PadLeft(4, '0'), bankTransaction.transactionType, bankTransaction.documentCategory, bankTransaction.voucherNumber, bankTransaction.recipientName, bankTransaction.recipientAccountNum, bankTransaction.details, bankTransaction.inwardAmount, bankTransaction.outwardAmount, bankTransaction.Id);
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            loadTable(detailedTransactionController.bankAccount.Id, cmdMonths.SelectedIndex + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel the process?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formController.mainTabControll(TAB_ACTION.REMOVE);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dgvBankTransactions.SelectedRows.Count > 0)
            {
                int transactionId = CommonTools.ConvertToInt(dgvBankTransactions.SelectedRows[0].Cells[9].Value);
                detailedTransactionController.bankTransaction = tableContext.BankTransactions.Single(x => x.Id == transactionId);
                BankDetailedTransactionFromStep3 tempForm = new BankDetailedTransactionFromStep3(formController, detailedTransactionController);
                formController.AddFormToConentPanel(tempForm);
            }
            else
            {
                MessageBox.Show("Please Select atleast one Account");
            }
        }
    }
}
