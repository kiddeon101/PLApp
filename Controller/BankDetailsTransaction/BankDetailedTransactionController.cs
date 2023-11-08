using Microsoft.EntityFrameworkCore;
using PLApp.Entity;
using PLApp.Entity.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }



}
