using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace PLApp.Entity.TableEntity
{
    internal class BankTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime transactionDate { get; set; }
        public string? transactionType { get; set; }

        public int documentCategory { get; set; }
        public int voucherNumber { get; set; }
        public string? recipientName { get; set; }
        public string? recipientAccountNum { get; set; }

        public string? details { get; set; }

        public double outwardAmount { get; set; }
        public double inwardAmount { get; set; }

        public int bankAccountId { get; set; }
        public BankAccount bankAccount { get; set; }

        [NotMapped]
        public Boolean hasConflict { get; set; }


    }
}
