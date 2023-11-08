using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLApp.Entity.TableEntity
{
    internal class BankDetailedTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public bool isIncomming { get; set; }

        [Required]
        public string category { get; set; }
        [Required]
        public double amount { get; set; }

        public int accountYear { get; set; }
        public int accountMonth { get; set;}
        public string customer { get; set; }
        public string projectNum { get; set; }
        public string invoiceNum { get; set; }
        public string purchaseOrderNum { get; set; }
        [Required]
        public string details { get; set; }

        public int BankTransactionId { get; set; }
        public BankTransaction BankTransaction { get; set; }
    }
}
