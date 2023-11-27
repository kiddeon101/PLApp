using PLApp.Controller.BankAccountManagement;
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
    public partial class AddUpdateBankAccount : Form
    {

        private BankAccount bankAccount;
        private BankManagementController bankManagementController;
        private string action;
        internal AddUpdateBankAccount(BankManagementController bankManagementController)
        {
            InitializeComponent();
            this.bankManagementController = bankManagementController;
            this.bankAccount = new BankAccount();
            this.action = "add";
        }

        internal AddUpdateBankAccount(BankManagementController bankManagementController, BankAccount bankAccount)
        {
            InitializeComponent();
            this.bankManagementController = bankManagementController;
            this.bankAccount = bankAccount;
            this.action = "update";
        }

        private void AddUpdateBankAccount_Load(object sender, EventArgs e)
        {
            if (this.action == "update")
            {
                txtAccName.Text = bankAccount.AccountName;
                txtBankName.Text = bankAccount.BankName;
                //txtAccCurrency.Text = bankAccount.AccountCurrency;
                txtOpenBalanceAmount.Text = bankAccount.OpenBalanceAmount.ToString();
                dtpOpenAccDate.Value = bankAccount.OpenBalanceDate;


                if (bankAccount.AccountCurrency.ToLower() == "usd")
                {
                    cmbCurrency.SelectedIndex = 0;
                }
                else
                {
                    cmbCurrency.SelectedIndex = 1;
                }
                btnAction.Text = "Update";
                lblTitle.Text = "Update Account Data";
            }
            else
            {
                cmbCurrency.SelectedIndex = 0;
                btnAction.Text = "Add";
                lblTitle.Text = "Add Account Data";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel the process", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void btnAction_Click(object sender, EventArgs e)
        {
            bankAccount.AccountName = txtAccName.Text;
            bankAccount.BankName = txtBankName.Text;
            bankAccount.AccountCurrency = cmbCurrency.SelectedItem.ToString();
            bankAccount.OpenBalanceAmount = double.Parse(txtOpenBalanceAmount.Text);
            bankAccount.OpenBalanceDate = dtpOpenAccDate.Value;

            await Task.Run(() =>
            {
                if (this.action == "update")
                {
                    bankManagementController.updateBankAccInfo(bankAccount);
                }
                else
                {
                    bankManagementController.saveBankAccInfo(bankAccount);
                }

            });


            this.Close();
        }
    }
}
