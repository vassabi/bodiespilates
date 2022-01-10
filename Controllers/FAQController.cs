using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class FAQController : Controller
    {
        private AppDataContext _dataContext;

        public FAQController(AppDataContext context)
        {
            _dataContext = context;
        }

        public IActionResult Index()
        {
            var model = GetModel();
            return View(model);
        }

        public FAQViewModel GetModel()
        {
            var model = new FAQViewModel();
            model.Questions = _dataContext.Questions.ToList();
            return model;
        }
    }
}
