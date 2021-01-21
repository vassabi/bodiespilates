using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private AppDataContext _dataContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDataContext context)
        {
            _dataContext = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = GetStoriesModel();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }

        public StoriesViewModel GetStoriesModel()
        {
            var model = new StoriesViewModel();
            model.MaxItemsToShow = 3;
            model.ShowFullStories = false;
            model.Stories = _dataContext.Stories.ToList();
            return model;
        }
    }
}
