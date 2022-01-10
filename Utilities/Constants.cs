using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Utilities
{
    public class Constants
    {
        public enum Roles
        {
            [field:DefaultValue(1)]
            [field:Description("Admin")]
            Admin = 1,
            [field: DefaultValue(2)]
            [field: Description("Customer")]
            Customer = 2,
            [field: DefaultValue(3)]
            [field: Description("User")]
            User = 3
        }
    }
}
