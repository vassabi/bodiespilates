using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Web.Utilities
{
    public class Helpers
    {
        public static bool IsValidEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
