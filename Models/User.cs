using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] 
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(250)]
        public string Email { get; set; }

        [Required]
        [MaxLength(250)]
        public string PasswordHash { get; set; }

        [NotMapped]
        public string Password { get; set; }

        [NotMapped]
        public string RepeatPassword { get; set; }

        [Required]
        [MaxLength(50)]
        public string Salt { get; set; }

        [DefaultValue("getdate()")] 
        public DateTimeOffset DateRegistered { get; set; }

        [DefaultValue(false)]
        public bool Suspended { get; set; }

        public DateTimeOffset DateLastLogin { get; set; }

        public int RoleId { get; set; }
        public bool AgreeReceiveMaterials { get; set; }

        public List<UserPayment> Payments { get; set; }
        public List<Subscribtion> Subscribtions { get; set; }
    }
}
