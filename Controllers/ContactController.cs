using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using Web.Models;
using Web.Services;
using Web.Settings;

namespace Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDataContext _dataContext;
        private readonly IEmailService _emailService;
        private readonly IOptions<AppSettings> _appSettings;

        public ContactController(AppDataContext context, IEmailService emailService, IOptions<AppSettings> app)
        {
            _dataContext = context;
            _emailService = emailService;
            _appSettings = app;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(ContactFormViewModel model)
        {
            if (string.IsNullOrEmpty(model.FirstName))
            {
                model.ErrorMessage = "First name field is empty";
                return View("Index", model);
            }
            if (string.IsNullOrEmpty(model.LastName))
            {
                model.ErrorMessage = "Last name field is empty";
                return View("Index", model);
            }
            if (string.IsNullOrEmpty(model.Email))
            {
                model.ErrorMessage = "Email field is empty";
                return View("Index", model);
            }
            if (!Utilities.Helpers.IsValidEmail(model.Email))
            {
                model.ErrorMessage = "Email address format is not correct";
                return View("Index", model);
            }

            var settings = _dataContext.AppSettings.FirstOrDefault();

            //RestClient client = new RestClient();
            //client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            //client.Authenticator =
            //    new HttpBasicAuthenticator("api",
            //                                _appSettings.Value.MailGunAPIKey);
            //RestRequest request = new RestRequest();
            //request.AddParameter("domain", "sharklist.net", ParameterType.UrlSegment);
            //request.Resource = "{domain}/messages";
            //request.AddParameter("from", "Excited User <hello@sharklist.net>");
            //request.AddParameter("to", "karen.aghajanyan@gmail.com");
            //request.AddParameter("subject", "Hello");
            //request.AddParameter("template", "bpcontactform");
            //request.AddParameter("h:X-Mailgun-Variables", "{\"sender\": \"" + model.FirstName + " " + model.LastName + "\", \"message\": "+ model.Comment + ", \"email\": " + model.Email + "}");
            //request.Method = Method.POST;
            //client.Execute(request);
            var message = new Message();
            message.FirstName = model.FirstName;
            message.LastName = model.LastName;
            message.Email = model.Email;
            message.AgreeReceivingMaterials = model.AgreeReceivingMaterials;
            message.Comment = model.Comment;
            message.MessageDate = DateTimeOffset.Now;
            _dataContext.Messages.Add(message);
            _dataContext.SaveChanges();
            try
            {
                _emailService.Send("Message from Bodies Pilates website", message.Comment, settings.AdminEmail, settings.AdminName);
            }
            catch (Exception ex)
            {
                model.ErrorMessage = "Email was not sent, unexpected error occured, try again later.";
                return View("Index", model);
            }
            return View("SubmitResult");
        }
    }
}
