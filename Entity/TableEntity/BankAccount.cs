using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLApp.Entity.TableEntity
{
    internal class BankAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? AccountName { get; set; }

        [Required]
        public string? BankName { get; set; }

        [Required]
        public string? AccountCurrency { get; set; }

        [Required]
        public double OpenBalanceAmount { get; set; }

        [Required]
        public DateTime OpenBalanceDate { get; set; }

        public ICollection<BankTransaction> BankTransactions { get; set; }
    }
}
