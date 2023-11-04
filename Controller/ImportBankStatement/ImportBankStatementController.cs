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
        ExcelManager excelManager = new ExcelManager();
        public BankAccount bankAccount = new BankAccount();

        Worksheet worksheet = new Worksheet();

        public ExcelManager GetExcelManager()
        {
            return excelManager;
        }

        public List<BankTransaction> getDataFromExcel(string path, ExcelManager excelManager)
        {
            List<BankTransaction> bankTransactions = new List<BankTransaction>();
            try
            {
                excelManager.OpenExcel(path);
                worksheet = excelManager.GetSheet(1);
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
    }
}
