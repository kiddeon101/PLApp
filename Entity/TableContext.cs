using Microsoft.EntityFrameworkCore;
using PLApp.Entity.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PLApp.Entity
{
    internal class TableContext:DbContext
    {

        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<BankTransaction> BankTransactions { get; set; }
        public DbSet<BankDetailedTransaction> BankDetailedTransactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //loadXML();
            //string sqlConnString = string.Format("Server={0};Database=InvoiceAppDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;User Id={1}; Password={2};MultipleActiveResultSets=true", servenName, username, password);

            //optionsBuilder.UseSqlServer(sqlConnString);
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=PLAppDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;User Id=admin; Password=admin;MultipleActiveResultSets=true");

        }
    }
}
