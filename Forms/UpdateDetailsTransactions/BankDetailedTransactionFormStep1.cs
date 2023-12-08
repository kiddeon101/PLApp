using PLApp.Controller.BankAccountManagement;
using PLApp.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLApp.Controller.BankDetailsTransaction;
using PLApp.Entity;
using PLApp.Entity.TableEntity;
using PLApp.Constants;
using PLApp.Controller.IssueBankStatement;
using PLApp.Forms.IssueBankStatement;

namespace PLApp.Forms.UpdateDetailsTransactions
{
    public partial class BankDetailedTransactionFormStep1 : Form
    {
        private FormController formController;
        private BankManagementController bankManagementController;
        private BankDetailedTransactionController detailedTransactionController;
        private IssueBankStatementController issueBankStatementController;
        private TableContext tableContext;

        internal BankDetailedTransactionFormStep1(FormController formController)
        {
            bankManagementController = new BankManagementController();
            detailedTransactionController = new BankDetailedTransactionController();
            issueBankStatementController = new IssueBankStatementController();
            tableContext = new TableContext();
            this.formController = formController;
            InitializeComponent();
        }

        private void BankDetailedTransactionFormStep1_Load(object sender, EventArgs e)
        {
            loadTable("");
        }

        private async void loadTable(string accName)
        {
            List<BankAccount> bankAccounts = new List<BankAccount>();
            await Task.Run(() =>
            {
                bankAccounts = bankManagementController.getBankAccounts(accName);

            });
            dgvBankAccounts.Rows.Clear();
            foreach (BankAccount bankAccount in bankAccounts)
            {
                double currentBalance = Math.Round(issueBankStatementController.getAccountBalance(bankAccount.Id, bankAccount.OpenBalanceAmount), 2);
                dgvBankAccounts.Rows.Add("ACC" + bankAccount.Id.ToString().PadLeft(4, '0'), bankAccount.AccountName, bankAccount.BankName, bankAccount.AccountCurrency, bankAccount.OpenBalanceAmount, bankAccount.OpenBalanceDate.ToString("dd/MM/yyyy"), currentBalance, bankAccount.Id);
            }

        }

        private void txtAccName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadTable(txtAccName.Text);
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (dgvBankAccounts.SelectedRows.Count > 0)
            {
                int accId = CommonTools.ConvertToInt(dgvBankAccounts.SelectedRows[0].Cells[7].Value);
                detailedTransactionController.bankAccount = tableContext.BankAccounts.Single(x => x.Id == accId);
                BankDetailedTransactionFromStep2 tempForm = new BankDetailedTransactionFromStep2(formController, detailedTransactionController);
                formController.AddFormToConentPanel(tempForm);
            }
            else
            {
                MessageBox.Show("Please Select atleast one Account");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel the process?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formController.mainTabControll(TAB_ACTION.REMOVE);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
