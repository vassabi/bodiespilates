using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using Web.Models;

namespace Web.Services
{
    public class EmailService : IEmailService
    {
        private AppDataContext _dataContext;

        public EmailService(AppDataContext context)
        {
            _dataContext = context;
        }

        public void Send(string subject, string body, string to, string fromName)
        {
            var settings = _dataContext.AppSettings.FirstOrDefault();
            if (settings == null)
                return;

            MailMessage message = new MailMessage();
            message.From = new MailAddress(settings.AdminEmail);
            message.To.Add(to);
            
            message.IsBodyHtml = true;
            message.Subject = subject;
            message.Body = body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = settings.SmtpHost;
            smtp.Port = settings.SmtpPort;
            smtp.EnableSsl = settings.SmtpEnableSsl;
            smtp.Credentials = new NetworkCredential(settings.AdminEmail, settings.EmailPassword);
            smtp.Send(message);
        }
    }
}
