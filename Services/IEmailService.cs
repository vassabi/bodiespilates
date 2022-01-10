using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services
{
    public interface IEmailService
    {
        public void Send(string subject, string body, string to, string fromName);
    }
}
