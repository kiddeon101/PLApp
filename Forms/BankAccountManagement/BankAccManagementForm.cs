using Microsoft.EntityFrameworkCore;
using PLApp.Constants;
using PLApp.Controller;
using PLApp.Controller.BankAccountManagement;
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

namespace PLApp.Forms.BankAccountManagement
{
    public partial class BankAccManagementForm : Form
    {
        private TableContext tableContext = new TableContext();
        private FormController formController;
        private BankManagementController bankManagementController;

        internal BankAccManagementForm(FormController formController)
        {
            bankManagementController = new BankManagementController(tableContext);
            this.formController = formController;
            InitializeComponent();
        }

        private void BankAccManagementForm_Load(object sender, EventArgs e)
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
                dgvBankAccounts.Rows.Add("ACC" + bankAccount.Id.ToString().PadLeft(4, '0'), bankAccount.AccountName, bankAccount.BankName, bankAccount.AccountCurrency, bankAccount.OpenBalanceAmount, bankAccount.OpenBalanceDate.ToString("MM/dd/yyyy"), bankAccount.Id);
            }


        }


        private void btnAction_Click(object sender, EventArgs e)
        {
            AddUpdateBankAccount addUpdateBankAccount = new AddUpdateBankAccount(bankManagementController);
            addUpdateBankAccount.ShowDialog();
            txtAccName.Text = "";

            loadTable("");
        }

        private void txtAccName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadTable(txtAccName.Text);
            }
        }

        private void dgvBankAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 8)
            {
                //Execute Delete
                DialogResult res = MessageBox.Show("Are you sure to delete the record?", "Warning", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    int accId = int.Parse(dgvBankAccounts.Rows[e.RowIndex].Cells[6].Value.ToString());
                    bankManagementController.deleteBankAccInfo(accId);
                    loadTable("");
                }
            }
            else if (e.ColumnIndex == 7)
            {
                //Execute Update
                int accId = int.Parse(dgvBankAccounts.Rows[e.RowIndex].Cells[6].Value.ToString());
                BankAccount bankAccount = tableContext.BankAccounts.Single(s => s.Id == accId);
                AddUpdateBankAccount addUpdateBankAccount = new AddUpdateBankAccount(bankManagementController, bankAccount);
                addUpdateBankAccount.ShowDialog();
                loadTable("");
            }
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
