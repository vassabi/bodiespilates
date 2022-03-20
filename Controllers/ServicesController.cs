using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class ServicesController : Controller
    {
        private AppDataContext _dataContext;

        public ServicesController(AppDataContext context)
        {
            _dataContext = context;
        }

        public IActionResult Index()
        {
            var model = GetModel();
            return View(model);
        }

        public ServicesViewModel GetModel()
        {
            var model = new ServicesViewModel();
            model.FaqModel = new FAQViewModel();
            model.FaqModel.Questions = _dataContext.Questions.ToList();
            model.SubscribeModel = new SubscribeFormViewModel();
            if(User.Identity.IsAuthenticated)
            {
                model.SubscribeModel.FirstName = User.Identity.Name;
                model.SubscribeModel.LastName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Surname).Value;
                model.SubscribeModel.Email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value;
            }
            return model;
        }

        public IActionResult Subscribe(ServicesViewModel model)
        {
            return View("Checkout", model.SubscribeModel);
        }

        public IActionResult Checkout()
        {
            return View("Checkout");
        }
        public IActionResult PaymentSuccess()
        {
            return View("PaymentSuccess");
        }
    }
}
