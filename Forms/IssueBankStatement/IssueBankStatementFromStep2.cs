using PLApp.Constants;
using PLApp.Controller;
using PLApp.Controller.IssueBankStatement;
using PLApp.Entity.TableEntity;
using PLApp.Views;
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
    public partial class IssueBankStatementFromStep2 : Form
    {
        private FormController formController;
        private IssueBankStatementController issueBankStatementController;

        internal IssueBankStatementFromStep2(FormController formController, IssueBankStatementController issueBankStatementController)
        {
            this.formController = formController;
            this.issueBankStatementController = issueBankStatementController;
            InitializeComponent();
        }

        private void IssueBankStatementFromStep2_Load(object sender, EventArgs e)
        {
            lblAccCurrency.Text = issueBankStatementController.bankAccount.AccountCurrency;
            lblAccName.Text = issueBankStatementController.bankAccount.AccountName;
            lblBankName.Text = issueBankStatementController.bankAccount.BankName;

            dtpDateFrom.Value = DateTime.Now.AddMonths(-6);
            dtpDateTo.Value = DateTime.Now;
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<BankTransaction> bankTransactions = new List<BankTransaction>();
            bankTransactions = issueBankStatementController.getBankStatementBaseFromDate(dtpDateFrom.Value, dtpDateTo.Value);

            double currentBalance = issueBankStatementController.getOpenAmount(dtpDateFrom.Value);
            lblOpenBalance.Text = currentBalance.ToString();
            lblCloseBalance.Text = issueBankStatementController.getClosingBalance(dtpDateFrom.Value, dtpDateTo.Value).ToString();


            foreach (BankTransaction bankTransaction in bankTransactions)
            {
                if (bankTransaction.isInOut() == "In")
                {
                    currentBalance = currentBalance + bankTransaction.getAmountInOut();
                }
                else if (bankTransaction.isInOut() == "Out")
                {
                    currentBalance = currentBalance - bankTransaction.getAmountInOut();
                }

                dgvBankTransactions.Rows.Add(bankTransaction.Id, bankTransaction.transactionDate.ToString("dd/MM/yyyy"), bankTransaction.isInOut(), bankTransaction.getAmountInOut(), bankTransaction.details, String.Format("{0:0.00}", currentBalance), bankTransaction.Id);
            }
        }



        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBankTransactions.Rows.Count != 0)
                {
                    List<BankStatementView> bankStatements = new List<BankStatementView>();
                    foreach (DataGridViewRow row in dgvBankTransactions.Rows)
                    {
                        BankStatementView bankStatement = new BankStatementView();
                        bankStatement.id = row.Cells[0].Value.ToString();
                        bankStatement.transactionDate = CommonTools.ConvertToDate(row.Cells[1].Value);
                        bankStatement.inOut = row.Cells[2].Value.ToString();
                        bankStatement.amount = CommonTools.ConvertToDouble(row.Cells[3].Value);
                        bankStatement.details = row.Cells[4].Value.ToString();
                        bankStatement.balace = CommonTools.ConvertToDouble(row.Cells[5].Value);

                        bankStatements.Add(bankStatement);
                    }
                    issueBankStatementController.CreateBankStatement(bankStatements, issueBankStatementController.getOpenAmount(dtpDateFrom.Value), issueBankStatementController.getClosingBalance(dtpDateFrom.Value, dtpDateTo.Value), dtpDateFrom.Value, dtpDateTo.Value);
                }
                MessageBox.Show("Successfully generated Statement for " + issueBankStatementController.bankAccount.AccountName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
