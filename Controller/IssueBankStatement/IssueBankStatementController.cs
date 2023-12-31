﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
using PLApp.Constants;
using PLApp.Entity;
using PLApp.Entity.TableEntity;
using PLApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PLApp.Controller.IssueBankStatement
{
    internal class IssueBankStatementController
    {

        public BankAccount bankAccount = new BankAccount();


        private ExcelManager excelService = new ExcelManager();
        Excel.Worksheet worksheet;
        Excel.Worksheet worksheet_template;

        private string RPT_TEMPLATE_DIR = Environment.CurrentDirectory.ToString() + @"/Report_Templates/bank_statement_template.xlsx";
        private string RPT_OUTPUT_DIR = Environment.CurrentDirectory.ToString() + @"/Reports/";

        private string COMM_STATEMENT_SHEET = "Sheet1";
        private string COMM_STATEMENT_SHEET_TEMPLATE = "template";

        public List<BankTransaction> getBankStatementBaseFromDate(DateTime dateFrom, DateTime DateTo)
        {
            using(TableContext context = new TableContext())
            {
                DateTime dateBegin = CommonTools.dateParseBeginning(dateFrom);
                DateTime dateEnd = CommonTools.dateParseEnding(DateTo);
                return context.BankTransactions.Where(i => i.bankAccountId == bankAccount.Id &&
                                               i.transactionDate.Date >= dateBegin.Date &&
                                               i.transactionDate.Date <= dateEnd.Date).OrderBy(i=>i.transactionDate).ToList();
            }
        }

        public double getOpenAmount(DateTime dateFrom)
        {
            using (TableContext context = new TableContext())
            {
                DateTime dateBegin = CommonTools.dateParseBeginning(dateFrom);
                double pastTransactionAmount = context.BankTransactions.Where(i => i.bankAccountId == bankAccount.Id &&
                                                        i.transactionDate.Date < dateBegin.Date).Select(i =>i.getAddedValue()
                                                        ).ToList().Sum();
                return Math.Round(bankAccount.OpenBalanceAmount + pastTransactionAmount,2);
            }
        }
        public double getAccountBalance(int bankId, double openBalance)
        {
            using (TableContext context = new TableContext())
            {
                DateTime dateBegin = CommonTools.dateParseEnding(DateTime.Now);
                double pastTransactionAmount = context.BankTransactions.Where(i => i.bankAccountId == bankId).Select(i => i.getAddedValue()
                                                        ).ToList().Sum();
                return openBalance + pastTransactionAmount;
            }
        }


        public double getClosingBalance(DateTime dateFrom, DateTime DateTo)
        {
            using (TableContext context = new TableContext())
            {
                DateTime dateBegin = CommonTools.dateParseBeginning(dateFrom);
                DateTime dateEnd = CommonTools.dateParseEnding(DateTo);

                double TransactionAmount = context.BankTransactions.Where(i => i.bankAccountId == bankAccount.Id &&
                                               i.transactionDate.Date >= dateBegin.Date &&
                                               i.transactionDate.Date <= dateEnd.Date).Select(i=>i.getAddedValue()).ToList().Sum();
                return Math.Round( getOpenAmount(dateFrom) + TransactionAmount,2);
            }         
        }

        public void CreateBankStatement(List<BankStatementView> bankStatements, double openBalance, double closingBalance,DateTime dateFrom, DateTime dateTo)
        {
            excelService.OpenExcel(RPT_TEMPLATE_DIR);
            worksheet = excelService.GetSheet(COMM_STATEMENT_SHEET);
            worksheet_template = excelService.GetSheet(COMM_STATEMENT_SHEET_TEMPLATE);

            

            worksheet.Cells[3, "C"] = "'" + DateTime.Today.ToString("MMM, dd, yyyy");
            worksheet.Cells[3, "E"] = bankAccount.BankName;
            worksheet.Cells[4, "E"] = bankAccount.AccountCurrency;
            worksheet.Cells[6, "D"] = String.Format("{0:0.00}", openBalance); 
            worksheet.Cells[11, "D"] = String.Format("{0:0.00}", closingBalance);

            worksheet.Cells[6, "A"] =String.Format("Statement Open Balance({0}):", dateFrom.ToString("MMMM yyyy"));
            worksheet.Cells[11, "A"] = String.Format("Statement Closing Balance ({0}):",dateTo.ToString("MMMM yyyy"));

            int startRow = 9;
            foreach (var bankStatement in bankStatements)
            {
                InsertNormalRow(startRow);
                worksheet.Cells[startRow, "A"] = bankStatement.id;
                worksheet.Cells[startRow, "B"] = bankStatement.transactionDate;
                worksheet.Cells[startRow, "C"] = bankStatement.inOut;
                worksheet.Cells[startRow, "D"] = bankStatement.amount;
                worksheet.Cells[startRow, "E"] = bankStatement.recipientName;
                worksheet.Cells[startRow, "F"] = bankStatement.recipientAccount;
                worksheet.Cells[startRow, "G"] = bankStatement.details;
                worksheet.Cells[startRow, "H"] = bankStatement.balace;              
                startRow++;
            }

            string fileName = bankAccount.AccountName + "_Statement_" + DateTime.Now.ToString("MMddyyyyhhmmss") + ".xlsx";
            saveSheet(fileName);
            excelService.CloseSheet();
        }

        private void InsertNormalRow(int rowNum)
        {
            worksheet.Range["A" + rowNum.ToString(), "H" + rowNum.ToString()].Insert(XlInsertShiftDirection.xlShiftDown);
            worksheet_template.Range["A1", "H1"].Copy(worksheet.Range["A" + rowNum.ToString()]);
            ExcelTools.AdjustRowHeight(worksheet, rowNum, 15.75);
        }

        public void saveSheet(string fileName)
        {
            excelService.saveExcel(RPT_OUTPUT_DIR + fileName);
        }
    }
}
