using PLApp.Constants;
using PLApp.Controller.BankDetailsTransaction;
using PLApp.Entity;
using PLApp.Entity.TableEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLApp.Forms.UpdateDetailsTransactions
{
    public partial class DetailedTransactionInfoForm : Form
    {

        private Boolean isAdd = true;
        private BankDetailedTransactionController detailedTransactionController;
        private BankDetailedTransaction detailedTransaction;
        private DataGridViewRow dataRow;
        private TableContext tableContext;
        internal DetailedTransactionInfoForm(BankDetailedTransactionController detailedTransactionController)
        {
            this.detailedTransactionController = detailedTransactionController;
            this.dataRow = new DataGridViewRow();
            this.detailedTransaction = new BankDetailedTransaction();
            this.tableContext = new TableContext();
            isAdd = true;
            InitializeComponent();
        }
        internal DetailedTransactionInfoForm(BankDetailedTransactionController detailedTransactionController, DataGridViewRow dataRow)
        {
            this.detailedTransactionController = detailedTransactionController;
            this.dataRow = dataRow;
            this.detailedTransaction = new BankDetailedTransaction();
            this.tableContext = new TableContext();
            isAdd = false;
            InitializeComponent();
        }

        private void DetailedTransactionInfoForm_Load(object sender, EventArgs e)
        {

            if (isAdd)
            {
                //Transaction is add
                lblTitle.Text = "Add Detailed Transaction Info";
                btnAction.Text = "Add";
                lblTransactionType.Text = detailedTransactionController.bankTransaction.isInOut() == "In" ? "Incomming" : "Outgoing";
                cmbTransactionType.SelectedIndex = 0;
            }
            else
            {
                //Transaction is Update
                if (detailedTransaction.isIncomming)
                {
                    cmbTransactionType.SelectedIndex = 0;
                }
                else
                {
                    cmbTransactionType.SelectedIndex = 1;
                }

                int detailedTransactionId = CommonTools.ConvertToInt(dataRow.Cells[9].Value);
                this.detailedTransaction = tableContext.BankDetailedTransactions.Single(i => i.Id == detailedTransactionId);
                lblTitle.Text = "Update Detailed Transaction Info";
                btnAction.Text = "Update";
                lblTransactionType.Text = detailedTransaction.isIncomming ? "Incomming" : "Outgoing";
                txtCategory.Text = detailedTransaction.category;
                txtAmount.Text = detailedTransaction.amount.ToString();
                dtpYear.Value = DateTime.Parse("01/01/" + detailedTransaction.accountYear);
                string format = "d/M/yyyy";
                DateTime dtTemp = DateTime.ParseExact("01/" + detailedTransaction.accountMonth + "/" + DateTime.Now.Year, format, CultureInfo.InvariantCulture);
                dtpMonth.Value = dtTemp;
                txtCustomer.Text = detailedTransaction.customer;
                txtProjectNum.Text = detailedTransaction.projectNum;
                txtInvoiceNum.Text = detailedTransaction.invoiceNum;
                txtPurchaseOrder.Text = detailedTransaction.purchaseOrderNum;
                txtDetails.Text = detailedTransaction.details;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                //Add the data
                BankDetailedTransaction bankDetailedTransaction = new BankDetailedTransaction();
                if (cmbTransactionType.SelectedIndex == 0)
                {
                    bankDetailedTransaction.isIncomming = true;
                    bankDetailedTransaction.amount = CommonTools.ConvertToDouble(txtAmount.Text);
                }
                else
                {
                    bankDetailedTransaction.isIncomming = false;
                    bankDetailedTransaction.amount = CommonTools.ConvertToDouble(txtAmount.Text) * -1;
                }
                bankDetailedTransaction.category = txtCategory.Text;

                bankDetailedTransaction.accountYear = dtpYear.Value.Year;
                bankDetailedTransaction.accountMonth = dtpMonth.Value.Month;
                bankDetailedTransaction.customer = CommonTools.ConvertToString(txtCustomer.Text);
                bankDetailedTransaction.projectNum = CommonTools.ConvertToString(txtProjectNum.Text);
                bankDetailedTransaction.invoiceNum = CommonTools.ConvertToString(txtInvoiceNum.Text);
                bankDetailedTransaction.purchaseOrderNum = CommonTools.ConvertToString(txtPurchaseOrder.Text);
                bankDetailedTransaction.details = CommonTools.ConvertToString(txtDetails.Text);
                bankDetailedTransaction.BankTransactionId = detailedTransactionController.bankTransaction.Id;
                detailedTransactionController.saveDetailedTransaction(bankDetailedTransaction);
                MessageBox.Show("Successfully Added data to Detailed Transaction");
                this.Close();
            }
            else
            {
                //Update the data
                detailedTransaction.category = txtCategory.Text;
                detailedTransaction.amount = CommonTools.ConvertToDouble(txtAmount.Text);
                detailedTransaction.accountYear = dtpYear.Value.Year;
                detailedTransaction.accountMonth = dtpMonth.Value.Month;
                detailedTransaction.customer = CommonTools.ConvertToString(txtCustomer.Text);
                detailedTransaction.projectNum = CommonTools.ConvertToString(txtProjectNum.Text);
                detailedTransaction.invoiceNum = CommonTools.ConvertToString(txtInvoiceNum.Text);
                detailedTransaction.purchaseOrderNum = CommonTools.ConvertToString(txtPurchaseOrder.Text);
                detailedTransaction.details = CommonTools.ConvertToString(txtDetails.Text);
                detailedTransactionController.updateDetailedTransaction(detailedTransaction);
                MessageBox.Show("Successfully Updated data to Detailed Transaction");
                this.Close();
            }

        }
    }
}
