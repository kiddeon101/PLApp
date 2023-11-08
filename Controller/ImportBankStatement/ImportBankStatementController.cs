using Microsoft.Office.Interop.Excel;
using PLApp.Constants;
using PLApp.Entity;
using PLApp.Entity.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelClass = Microsoft.Office.Interop.Excel;

namespace PLApp.Controller.ImportBankStatement
{
    internal class ImportBankStatementController
    {
        public ExcelManager excelManager = new ExcelManager();
        public BankAccount bankAccount = new BankAccount();

        public List<BankTransaction> getDataFromExcel(string path)
        {
            List<BankTransaction> bankTransactions = new List<BankTransaction>();


            excelManager.OpenExcel(path);      
            try
            {
                Worksheet worksheet = excelManager.GetSheet(1);
                ExcelClass.Range usedRange = worksheet.UsedRange;
                int rowCount = usedRange.Rows.Count;
                if (usedRange.Columns.Count >= 10)
                {
                    //List<BankTransaction> bankTransactions = new List<BankTransaction>();
                    for (int x = 6; x <= rowCount; x++)
                    {
                        BankTransaction transaction = new BankTransaction();
                        transaction.transactionDate = CommonTools.ConvertToDate((usedRange.Cells[x, "A"] as ExcelClass.Range).Value2);
                        transaction.transactionType = CommonTools.ConvertToString((usedRange.Cells[x, "B"] as ExcelClass.Range).Value2);
                        transaction.documentCategory = CommonTools.ConvertToInt((usedRange.Cells[x, "C"] as ExcelClass.Range).Value2);
                        transaction.voucherNumber = CommonTools.ConvertToInt((usedRange.Cells[x, "D"] as ExcelClass.Range).Value2);
                        transaction.recipientName = CommonTools.ConvertToString((usedRange.Cells[x, "E"] as ExcelClass.Range).Value2);
                        transaction.recipientAccountNum = CommonTools.ConvertToString((usedRange.Cells[x, "F"] as ExcelClass.Range).Value2);
                        transaction.details = CommonTools.ConvertToString((usedRange.Cells[x, "G"] as ExcelClass.Range).Value2);
                        transaction.outwardAmount = CommonTools.ConvertToDouble((usedRange.Cells[x, "H"] as ExcelClass.Range).Value2);
                        transaction.inwardAmount = CommonTools.ConvertToDouble((usedRange.Cells[x, "I"] as ExcelClass.Range).Value2);

                        //Check if Data is already in the transaction table
                        bool isAvail = false;
                        using (TableContext context = new TableContext())
                        {
                            isAvail = context.BankTransactions.Where(i => (
                            i.transactionDate.Date == transaction.transactionDate.Date &&
                            i.transactionType == transaction.transactionType &&
                            i.documentCategory == transaction.documentCategory &&
                            i.voucherNumber == transaction.voucherNumber &&
                            i.recipientName == transaction.recipientName &&
                            i.recipientAccountNum == transaction.recipientAccountNum &&
                            i.details == transaction.details &&
                            i.outwardAmount == transaction.outwardAmount &&
                            i.inwardAmount == transaction.inwardAmount)
                            ).Count() > 0;
                        }

                        if (isAvail)
                        {
                            transaction.hasConflict = true;
                            
                        }
                        else
                        {
                            transaction.hasConflict = false;
                        }
                        bankTransactions.Add(transaction);
                    }
                    
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excelManager.CloseSheet();
            }
            return bankTransactions;

        }

        public List<BankTransaction> getStatementFromExcel(string path,int statementType)
        {
            List<BankTransaction> bankTransactions = new List<BankTransaction>();
            excelManager.OpenExcel(path);
            try
            {
                //Worksheet worksheet = new Worksheet();
                Worksheet worksheet = excelManager.GetSheet(1);
                ExcelClass.Range usedRange = worksheet.UsedRange;
                if(usedRange.Columns.Count ==5) {
                    bool newTransactionFlag = false;
                    BankTransaction bankTransaction = new BankTransaction();
                    for (int i = 1; i <= usedRange.Rows.Count; i++)
                    {
                        DateTime transactionDate = CommonTools.ConvertToDate((usedRange.Cells[i, "A"] as ExcelClass.Range).Value2);
                        string details = "";
                        if(transactionDate.Date != DateTime.Parse("01/01/0001").Date)
                        {
                            //Starting point of new startment.
                            bankTransaction.transactionDate = transactionDate;
                            bankTransaction.details = CommonTools.ConvertToString((usedRange.Cells[i, "B"] as ExcelClass.Range).Value2);
                            bankTransaction.inwardAmount = CommonTools.ConvertToDouble((usedRange.Cells[i, "C"] as ExcelClass.Range).Value2);
                            bankTransaction.outwardAmount = CommonTools.ConvertToDouble((usedRange.Cells[i, "D"] as ExcelClass.Range).Value2);
                            bankTransaction.transactionType = "";
                            bankTransaction.documentCategory = 0;
                            bankTransaction.voucherNumber = 0;
                            bankTransaction.recipientName = "";
                            bankTransaction.recipientAccountNum = "";

                        }
                        else
                        {
                            //Get Additional Details
                            bankTransaction.details = bankTransaction.details + " " + CommonTools.ConvertToString((usedRange.Cells[i, "B"] as ExcelClass.Range).Value2);
                            newTransactionFlag = true;
                        }
                        if(newTransactionFlag == true)
                        {

                            //Check if Data is already in the transaction table
                            bool isAvail = false;
                            using (TableContext context = new TableContext())
                            {
                                isAvail = context.BankTransactions.Where(i => (
                                i.transactionDate.Date == bankTransaction.transactionDate.Date &&
                                i.transactionType == bankTransaction.transactionType &&
                                i.documentCategory == bankTransaction.documentCategory &&
                                i.voucherNumber == bankTransaction.voucherNumber &&
                                i.recipientName == bankTransaction.recipientName &&
                                i.recipientAccountNum == bankTransaction.recipientAccountNum &&
                                i.details == bankTransaction.details &&
                                i.outwardAmount == bankTransaction.outwardAmount &&
                                i.inwardAmount == bankTransaction.inwardAmount)
                                ).Count() > 0;
                            }

                            if (isAvail)
                            {
                                bankTransaction.hasConflict = true;

                            }
                            else
                            {
                                bankTransaction.hasConflict = false;
                            }


                            bankTransactions.Add(bankTransaction);
                            bankTransaction = new BankTransaction();
                            newTransactionFlag = false; 
                        }
                    }
                }
                else
                {
                    var x = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excelManager.CloseSheet();
            }
            return bankTransactions;
        }



        public async void saveStatement(List<BankTransaction> bankTransactions)
        {
            using (TableContext context = new TableContext())
            {
                if (bankTransactions.Count > 0)
                {
                    await context.BankTransactions.AddRangeAsync(bankTransactions);
                    await context.SaveChangesAsync();
                }               
            }
        }

        public List<BankTransaction> getBankTransactionByBankAcc(int bankAccId)
        {
            try
            {
                using (TableContext DBContext = new TableContext())
                {
                    List<BankTransaction> bankTransactions = new List<BankTransaction>();
                    bankTransactions = DBContext.BankTransactions.Where(i => i.bankAccountId == bankAccId).ToList();
                    return bankTransactions;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BankTransaction> getBankTransactionByBankAccAndTransactionMonth(int bankAccId, int monthIndex)
        {
            try
            {
                using (TableContext DBContext = new TableContext())
                {
                    List<BankTransaction> bankTransactions = new List<BankTransaction>();
                    bankTransactions = DBContext.BankTransactions.Where(i => i.bankAccountId == bankAccId && i.transactionDate.Month == monthIndex).ToList();
                    return bankTransactions;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
