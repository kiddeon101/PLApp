using PLApp.Constants;
using PLApp.Controller;
using PLApp.Controller.BankAccountManagement;
using PLApp.Controller.ImportBankStatement;
using PLApp.Controller.IssueBankStatement;
using PLApp.Entity;
using PLApp.Entity.TableEntity;
using PLApp.Forms.ImportBankStatement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLApp.Forms.IssueBankStatement
{
    public partial class IssueBankStatementFormStep1 : Form
    {
        private FormController formController;
        private BankManagementController bankManagementController;
        private IssueBankStatementController issueBankStatementController;
        private TableContext tableContext;
        internal IssueBankStatementFormStep1(FormController formController)
        {
            bankManagementController = new BankManagementController();
            issueBankStatementController = new IssueBankStatementController();
            tableContext = new TableContext();
            this.formController = formController;
            InitializeComponent();
        }

        private void txtAccName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadTable(txtAccName.Text);
            }
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
                dgvBankAccounts.Rows.Add("ACC" + bankAccount.Id.ToString().PadLeft(4, '0'), bankAccount.AccountName, bankAccount.BankName, bankAccount.AccountCurrency, bankAccount.OpenBalanceAmount, bankAccount.OpenBalanceDate.ToString("dd/MM/yyyy"), 0, bankAccount.Id);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IssueBankStatementFormStep1_Load(object sender, EventArgs e)
        {
            loadTable("");
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (dgvBankAccounts.SelectedRows.Count > 0)
            {
                int accId = CommonTools.ConvertToInt(dgvBankAccounts.SelectedRows[0].Cells[7].Value);
                issueBankStatementController.bankAccount = tableContext.BankAccounts.Single(x => x.Id == accId);
                IssueBankStatementFromStep2 tempForm = new IssueBankStatementFromStep2(formController, issueBankStatementController);
                formController.AddFormToConentPanel(tempForm);
            }
            else
            {
                MessageBox.Show("Please Select atleast one Account");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel the process?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formController.mainTabControll(TAB_ACTION.REMOVE);
            }
        }
    }
}
