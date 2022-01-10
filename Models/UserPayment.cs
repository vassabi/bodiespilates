using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class UserPayment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal PaymentAmount { get; set; }

        [Required]
        public string TransactionId { get; set; }

        [Required]
        public DateTimeOffset PaymentDate { get; set; }
    }
}
