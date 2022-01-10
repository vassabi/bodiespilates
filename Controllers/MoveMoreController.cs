using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using Web.Models;

namespace Web.Controllers
{
    public class MoveMoreController : Controller
    {
        private readonly AppDataContext _dataContext;
        public MoveMoreViewModel mmViewModel;
        public MoveMoreController(AppDataContext context)
        {
            _dataContext = context;
        }
        public IActionResult Index()
        {
            var model = new AccessDeniedViewModel();
            ClaimsIdentity user = (ClaimsIdentity)HttpContext.User.Identity;
            if (user.IsAuthenticated)
            {
                var claims = user.Claims.ToList();
                var roleClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role);
                //if this is admin just return view
                if (roleClaim != null && roleClaim.Value == "1")
                {
                    mmViewModel = new MoveMoreViewModel();
                    mmViewModel.Categories = _dataContext.VideoCategories.ToList();
                    mmViewModel.CategoriesWithVideos = _dataContext.VideoCategories.Include(c => c.Videos).ToList();
                    mmViewModel.CurrentCategoryId = null;
                    mmViewModel.GroupedCategories = mmViewModel.Categories.GroupBy(c => c.GroupName);
                    return View(mmViewModel);
                }
                //if this is customer, check the subscribtion
                ///TODO
                else
                {
                    model.AccessDeniedReason = "You did not purchased subscribtion yet.";
                    return View("AccessDenied", model);
                }
            }
            else
            {
                model.AccessDeniedReason = "You are not authenticated, please login first.";
                return View("AccessDenied", model);
            }
        }

        public IActionResult Videos(int Id)
        {
            mmViewModel = new MoveMoreViewModel();
            mmViewModel.Categories = _dataContext.VideoCategories.ToList();
            mmViewModel.CategoriesWithVideos = _dataContext.VideoCategories.Include(c => c.Videos).ToList();
            mmViewModel.CurrentCategoryId = Id;
            mmViewModel.GroupedCategories = mmViewModel.Categories.GroupBy(c => c.GroupName);
            mmViewModel.Videos = _dataContext.Videos.Where(v => v.VideoCategoryId == Id).ToList();
            return View(mmViewModel);
        }
    }
}
