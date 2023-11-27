using PLApp.Constants;
using PLApp.Controller;
using PLApp.Controller.BankDetailsTransaction;
using PLApp.Entity;
using PLApp.Entity.TableEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLApp.Forms.UpdateDetailsTransactions
{
    public partial class BankDetailedTransactionFromStep3 : Form
    {
        private FormController formController;
        private BankDetailedTransactionController detailedTransactionController;
        private TableContext tableContext;

        private double sumOfDetailedTransactions = 0;
        internal BankDetailedTransactionFromStep3(FormController formController, BankDetailedTransactionController detailedTransactionController)
        {
            this.formController = formController;
            this.detailedTransactionController = detailedTransactionController;
            this.tableContext = new TableContext();
            InitializeComponent();
        }


        private void BankDetailedTransactionFromStep3_Load(object sender, EventArgs e)
        {
            lblTranactionId.Text = detailedTransactionController.bankTransaction.Id.ToString();
            if (detailedTransactionController.bankTransaction.isInOut().ToLower() == "in")
            {
                lblTransactionType.Text = "Incomming";
                lblTransactionAmount.Text =Math.Round( detailedTransactionController.bankTransaction.inwardAmount,2).ToString();
            }
            else
            {
                lblTransactionType.Text = "Outgoing";
                lblTransactionAmount.Text = Math.Round(detailedTransactionController.bankTransaction.outwardAmount,2).ToString();
            }

            loadTable(detailedTransactionController.bankTransaction.Id);


        }

        public async void loadTable(int transactionId)
        {
            List<BankDetailedTransaction> bankDetailedTransactions = new List<BankDetailedTransaction>(); ;
            await Task.Run(() =>
            {
                bankDetailedTransactions = detailedTransactionController.GetBankDetailedTransaction(transactionId);
            });
            dgvBankDetailedTransactions.Rows.Clear();
            foreach (var bankDetailedTransaction in bankDetailedTransactions)
            {
                dgvBankDetailedTransactions.Rows.Add(bankDetailedTransaction.category, bankDetailedTransaction.amount, bankDetailedTransaction.accountYear, bankDetailedTransaction.accountMonth, bankDetailedTransaction.customer, bankDetailedTransaction.projectNum, bankDetailedTransaction.invoiceNum, bankDetailedTransaction.purchaseOrderNum, bankDetailedTransaction.details, bankDetailedTransaction.Id);
            }

            sumOfDetailedTransactions = bankDetailedTransactions.Select(i => i.amount).Sum();
            lblSumDetailedTransaction.Text =Math.Round(sumOfDetailedTransactions,2).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailedTransactionInfoForm transactionForm = new DetailedTransactionInfoForm(detailedTransactionController);
            transactionForm.ShowDialog();
            loadTable(detailedTransactionController.bankTransaction.Id);

        }

        private void dgvBankDetailedTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                //Update Detailed Transaction
                DetailedTransactionInfoForm transactionForm = new DetailedTransactionInfoForm(detailedTransactionController, dgvBankDetailedTransactions.Rows[e.RowIndex]);
                transactionForm.ShowDialog();
                loadTable(detailedTransactionController.bankTransaction.Id);

            }
            else if (e.ColumnIndex == 11)
            {
                //Delete Detailed transaction
                if (MessageBox.Show("Are you sure you want to delete this line?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int detailedTransactionId = CommonTools.ConvertToInt(dgvBankDetailedTransactions.Rows[e.RowIndex].Cells[9].Value);
                    detailedTransactionController.deleteDetailedTransaction(detailedTransactionId);
                    loadTable(detailedTransactionController.bankTransaction.Id);
                }
                    
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (CommonTools.ConvertToDouble(lblTransactionAmount.Text) != CommonTools.ConvertToDouble(lblSumDetailedTransaction.Text))
            {
                MessageBox.Show("Please make sure that the sum of the detailed transaction is equal to the transaction amount");
            }
            else
            {
                formController.mainTabControll(TAB_ACTION.REMOVE);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("All the detailed will be lost when you close this page","Warning",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                detailedTransactionController.deleteDetailedTransactionByTransactionId(detailedTransactionController.bankTransaction.Id);
                formController.mainTabControll(TAB_ACTION.REMOVE);
            }
            
        }
    }
}
