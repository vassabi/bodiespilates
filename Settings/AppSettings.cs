using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Settings
{
    public class AppSettings
    {
        public int PasswordMinChar { get; set; }
        public string AdminEmail { get; set; }
        public string MailGunAPIKey { get; set; }
        public string PaypalBPOnlineMonthlyPlanLink { get; set; }
        public string PaypalBPOnlineYearyPlanLink { get; set; }
        public string PaypalIPNVerificationUrl { get; set; }
        public string PDTIdentityToken { get; set; }
    }
}
