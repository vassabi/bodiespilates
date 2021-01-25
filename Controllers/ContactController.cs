using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class ContactController : Controller
    {
        private AppDataContext _dataContext;

        public ContactController(AppDataContext context)
        {
            _dataContext = context;
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

            var message = new Message();
            message.FirstName = model.FirstName;
            message.LastName = model.LastName;
            message.Email = model.Email;
            message.AgreeReceivingMaterials = model.AgreeReceivingMaterials;
            message.Comment = model.Comment;
            message.MessageDate = DateTimeOffset.Now;
            _dataContext.Messages.Add(message);
            _dataContext.SaveChanges();

            return View("SubmitResult");
        }
    }
}
