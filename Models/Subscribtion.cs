using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Subscribtion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTimeOffset SubscribtionDate { get; set; }
        [Required]
        public DateTimeOffset SubscribtionExpirationDate { get; set; }
    }
}
