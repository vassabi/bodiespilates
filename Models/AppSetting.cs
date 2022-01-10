using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class AppSetting
    {
        [Key]
        public int Id { get; set; }
        public string AdminEmail { get; set; }
        public string AdminName { get; set; }
        public string EmailPassword { get; set; }
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
        public bool SmtpEnableSsl { get; set; }
    }
}
