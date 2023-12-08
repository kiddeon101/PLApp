using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
using PLApp.Constants;
using PLApp.Entity;
using PLApp.Entity.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PLApp.Controller.BankDetailsTransaction
{
    internal class BankDetailedTransactionController
    {
        public BankAccount bankAccount = new BankAccount();
        public BankTransaction bankTransaction = new BankTransaction();

        public List<BankDetailedTransaction> GetBankDetailedTransaction(int transactionID) {
            try
            {
                using (TableContext context = new TableContext())
                {
                    List<BankDetailedTransaction> bankDetailedTransactions = new List<BankDetailedTransaction>();
                    bankDetailedTransactions = context.BankDetailedTransactions.Where(i => i.BankTransactionId == transactionID).ToList();
                    return bankDetailedTransactions;
                }
            }catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async void saveDetailedTransaction(BankDetailedTransaction bankDetailedTransaction)
        {
            using(TableContext context = new TableContext())
            {
                context.BankDetailedTransactions.Add(bankDetailedTransaction);
                await context.SaveChangesAsync();
            }
        }


        public async void updateDetailedTransaction(BankDetailedTransaction bankDetailedTransaction)
        {
            using (TableContext context = new TableContext())
            {
                context.BankDetailedTransactions.Update(bankDetailedTransaction);
                await context.SaveChangesAsync();
            }
        }


        public async void deleteDetailedTransaction(int detailedTransactionId)
        {
            try
            {
                using (TableContext DBContext = new TableContext())
                {
                    DBContext.BankDetailedTransactions.Where(s => s.Id == detailedTransactionId).ExecuteDelete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async void deleteDetailedTransactionByTransactionId(int bankTransactionId)
        {
            try
            {
                using (TableContext DBContext = new TableContext())
                {
                    DBContext.BankDetailedTransactions.Where(s => s.BankTransactionId == bankTransactionId).ExecuteDelete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private ExcelManager excelService = new ExcelManager();
        Excel.Worksheet worksheet;
        Excel.Worksheet worksheet_template;

        private string RPT_TEMPLATE_DIR = Environment.CurrentDirectory.ToString() + @"/Report_Templates/bank_detailed_transaction_template.xlsx";
        private string RPT_OUTPUT_DIR = Environment.CurrentDirectory.ToString() + @"/Reports/";

        private string COMM_STATEMENT_SHEET = "Sheet1";
        private string COMM_STATEMENT_SHEET_TEMPLATE = "template";

        public void createDetailedBankTransaction(DateTime dateFrom, DateTime dateTo)
        {
            excelService.OpenExcel(RPT_TEMPLATE_DIR);
            worksheet = excelService.GetSheet(COMM_STATEMENT_SHEET);
            worksheet_template = excelService.GetSheet(COMM_STATEMENT_SHEET_TEMPLATE);

            List<BankAccount> bankAccounts = new List<BankAccount>();
            List<BankTransaction> bankTransactions = new List<BankTransaction>();
            using (TableContext context = new TableContext())
            {
                bankAccounts = context.BankAccounts.ToList();
                bankTransactions = context.BankTransactions.Include(i => i.BankDetailedTransactions).ToList();
            }

            int startRow = 8;
            foreach (BankAccount bankAccount in bankAccounts)
            {
                List<BankTransaction> tempBankTransactions = bankTransactions.Where(i => i.bankAccountId == bankAccount.Id).ToList();
                foreach (BankTransaction tempBankTransaction in tempBankTransactions)
                {
                    foreach(BankDetailedTransaction tempBankDetailedTransaction in tempBankTransaction.BankDetailedTransactions)
                    {
                        InsertNormalRow(startRow);
                        worksheet.Cells[startRow, "A"] = tempBankDetailedTransaction.Id;
                        worksheet.Cells[startRow, "B"] = bankAccount.BankName;
                        worksheet.Cells[startRow, "C"] = tempBankTransaction.Id;
                        worksheet.Cells[startRow, "D"] = bankAccount.AccountCurrency;
                        worksheet.Cells[startRow, "E"] = tempBankTransaction.transactionDate;
                        //worksheet.Cells[startRow, "F"] = tempBankTransaction.isInOut() == "In" ? "Incomming" : "Outgoing";
                        worksheet.Cells[startRow, "F"] = tempBankDetailedTransaction.isIncomming ? "Incomming" : "Outgoing";
                        worksheet.Cells[startRow, "G"] = tempBankDetailedTransaction.category;
                        worksheet.Cells[startRow, "H"] = tempBankDetailedTransaction.isIncomming ? Math.Abs(tempBankDetailedTransaction.amount) : 0;
                        worksheet.Cells[startRow, "I"] = tempBankDetailedTransaction.isIncomming ? 0 : Math.Abs(tempBankDetailedTransaction.amount);
                        worksheet.Cells[startRow, "J"] = tempBankDetailedTransaction.accountYear;
                        worksheet.Cells[startRow, "K"] = tempBankDetailedTransaction.accountMonth;
                        worksheet.Cells[startRow, "L"] = tempBankDetailedTransaction.customer;
                        worksheet.Cells[startRow, "M"] = tempBankDetailedTransaction.projectNum;
                        worksheet.Cells[startRow, "N"] = tempBankDetailedTransaction.invoiceNum;
                        worksheet.Cells[startRow, "O"] = tempBankDetailedTransaction.purchaseOrderNum;
                        worksheet.Cells[startRow, "P"] = tempBankDetailedTransaction.details;
                        startRow++;
                    }                  
                }
            }


            //int startRow = 8;
            //foreach(BankDetailedTransaction bankDetailedTransaction in bankDetailedTransactions)
            //{
            //    InsertNormalRow(startRow);
            //    worksheet.Cells[startRow, "A"] = bankDetailedTransaction.Id;
            //    worksheet.Cells[startRow, "B"] = bankAccount.BankName;
            //    worksheet.Cells[startRow, "C"] = bankTransaction.Id;
            //    worksheet.Cells[startRow, "D"] = bankAccount.AccountCurrency;
            //    worksheet.Cells[startRow, "E"] = bankTransaction.transactionDate;
            //    worksheet.Cells[startRow, "F"] = bankTransaction.isInOut() == "In"?"Incomming":"Outgoing";
            //    worksheet.Cells[startRow, "G"] = bankDetailedTransaction.category;
            //    worksheet.Cells[startRow, "H"] = bankDetailedTransaction.isIncomming ? bankDetailedTransaction.amount : 0;
            //    worksheet.Cells[startRow, "I"] = bankDetailedTransaction.isIncomming ? 0 : bankDetailedTransaction.amount;
            //    worksheet.Cells[startRow, "J"] = bankDetailedTransaction.accountYear;
            //    worksheet.Cells[startRow, "K"] = bankDetailedTransaction.accountMonth;
            //    worksheet.Cells[startRow, "L"] = bankDetailedTransaction.customer;
            //    worksheet.Cells[startRow, "M"] = bankDetailedTransaction.projectNum;
            //    worksheet.Cells[startRow, "N"] = bankDetailedTransaction.invoiceNum;
            //    worksheet.Cells[startRow, "O"] = bankDetailedTransaction.purchaseOrderNum;
            //    worksheet.Cells[startRow, "P"] = bankDetailedTransaction.details;
            //    startRow++;
            //}

            string fileName = bankAccount.AccountName + "DetailedTransactions_" + DateTime.Now.ToString("MMddyyyyhhmmss") + ".xlsx";
            saveSheet(fileName);
            excelService.CloseSheet();
        }

        private void InsertNormalRow(int rowNum)
        {
            worksheet.Range["A" + rowNum.ToString(), "P" + rowNum.ToString()].Insert(XlInsertShiftDirection.xlShiftDown);
            worksheet_template.Range["A1", "P1"].Copy(worksheet.Range["A" + rowNum.ToString()]);
            ExcelTools.AdjustRowHeight(worksheet, rowNum, 15.75);
        
        
        }

        public void saveSheet(string fileName)
        {
            excelService.saveExcel(RPT_OUTPUT_DIR + fileName);
        }
    }
}
