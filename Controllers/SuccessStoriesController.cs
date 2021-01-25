using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class SuccessStoriesController : Controller
    {
        private AppDataContext _dataContext;

        public SuccessStoriesController(AppDataContext context)
        {
            _dataContext = context;
        }

        public IActionResult Index()
        {
            var model = GetStoriesModel();
            return View(model);
        }

        public StoriesViewModel GetStoriesModel()
        {
            var model = new StoriesViewModel();
            model.ShowFullStories = true;
            model.Stories = _dataContext.Stories.ToList();
            return model;
        }
    }
}
