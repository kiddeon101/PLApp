using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLApp.Views
{
    internal class BankStatementView
    {
        public string id { get; set; }
        public DateTime transactionDate { get; set; }
        public string inOut { get; set; }
        public double amount { get; set; }
        public string details { get; set; }
        public double balace { get; set; }

    }
}
