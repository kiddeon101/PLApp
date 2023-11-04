using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PLApp.Entity;
using PLApp.Entity.TableEntity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace PLApp.Controller.BankAccountManagement
{
    internal class BankManagementController
    {
        private TableContext tableContext = new TableContext();
        public BankManagementController()
        {
           
        }
        public async void saveBankAccInfo(BankAccount bankAccount)
        {
            tableContext.BankAccounts.Add(bankAccount);
            await tableContext.SaveChangesAsync();
        }

        public async void updateBankAccInfo(BankAccount bankAccount)
        {
            tableContext.Update(bankAccount);
            await tableContext.SaveChangesAsync();
        }
        public async void deleteBankAccInfo(int accId)
        {
            try
            {
                using (TableContext DBContext = new TableContext())
                {
                    DBContext.BankAccounts.Where(s=>s.Id== accId).ExecuteDelete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BankAccount> getBankAccounts(string accName)
        {
            try
            {
                using (TableContext DBContext = new TableContext())
                {
                    List<BankAccount> bankAccounts = new List<BankAccount>();
                    bankAccounts = DBContext.BankAccounts.Where(i => i.AccountName.Contains(accName)).ToList();
                    return bankAccounts;
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
                
        }
    }
}
