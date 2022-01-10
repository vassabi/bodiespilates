using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Web.Models;

namespace Web.Controllers
{
    public class AdminAreaController : Controller
    {
        private readonly AppDataContext _dataContext;
        private AdminAreaViewModel aamv;
        public AdminAreaController(AppDataContext context)
        {
            _dataContext = context;
        }

        public IActionResult Index()
        {
            aamv = GetAdminAreaViewModel(0);
            return CheckAccess(0, aamv);
        }

        public IActionResult Dashboard()
        {
            aamv = GetAdminAreaViewModel(1);
            return CheckAccess(1, aamv);
        }

        public IActionResult Users()
        {
            aamv = GetAdminAreaViewModel(2);
            return CheckAccess(2, aamv);
        }

        public IActionResult Stories()
        {
            aamv = GetAdminAreaViewModel(3);
            return CheckAccess(3, aamv);
        }

        public IActionResult Payments()
        {
            aamv = GetAdminAreaViewModel(4);
            return CheckAccess(4, aamv);
        }

        public IActionResult FAQ()
        {
            aamv = GetAdminAreaViewModel(5);
            return CheckAccess(5, aamv);
        }

        public IActionResult EditUser(int Id)
        {
            var enumData = from Web.Utilities.Constants.Roles e in Enum.GetValues(typeof(Web.Utilities.Constants.Roles))
                           select new
                           {
                               ID = (int)e,
                               Name = e.ToString()
                           };
            ViewBag.RolesList = new SelectList(enumData, "ID", "Name");
            aamv = GetAdminAreaViewModel(0);
            aamv.UserModel.User = _dataContext.Users.FirstOrDefault(u => u.Id == Id);
            return CheckAccess(0, aamv);
        }

        [HttpPost]
        public IActionResult SaveUser(AdminAreaViewModel model)
        {
            var user = _dataContext.Users.Where(u => u.Id == model.UserModel.User.Id).FirstOrDefault();
            user.LastName = model.UserModel.User.LastName;
            user.FirstName = model.UserModel.User.FirstName;
            user.Email = model.UserModel.User.Email;
            user.RoleId = model.UserModel.User.RoleId;
            if(!string.IsNullOrEmpty(model.UserModel.User.Password))
            {
                string password_hash = "";
                using (MD5 md5Hash = MD5.Create())
                {
                    byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(model.UserModel.User.Password + user.Salt));
                    StringBuilder sBuilder = new StringBuilder();
                    for (int i = 0; i < data.Length; i++)
                    {
                        sBuilder.Append(data[i].ToString("x2"));
                    }
                    password_hash = sBuilder.ToString();
                }
                user.PasswordHash = password_hash;
            }
            _dataContext.SaveChanges();
            return Redirect("/AdminArea/Users");
        }

        private AdminAreaViewModel GetAdminAreaViewModel(int ActiveLinkIndex)
        {
            var model = new AdminAreaViewModel();
            model.Links = new System.Collections.Generic.List<AdminAreaViewModelLink>();
            model.Links.Add(new AdminAreaViewModelLink() { Text = "Dashboard", Controller = "AdminArea", Action = "Dashboard", IsActive = ActiveLinkIndex == 1});
            model.Links.Add(new AdminAreaViewModelLink() { Text = "Users", Controller = "AdminArea", Action = "Users", IsActive = ActiveLinkIndex == 2 });
            model.Links.Add(new AdminAreaViewModelLink() { Text = "Stories", Controller = "AdminArea", Action = "Stories", IsActive = ActiveLinkIndex == 3 });
            model.Links.Add(new AdminAreaViewModelLink() { Text = "Payments", Controller = "AdminArea", Action = "Payments", IsActive = ActiveLinkIndex == 4 });
            model.Links.Add(new AdminAreaViewModelLink() { Text = "FAQ", Controller = "AdminArea", Action = "FAQ", IsActive = ActiveLinkIndex == 5 });
            model.Questions = _dataContext.Questions.ToList();
            model.Stories = _dataContext.Stories.ToList();
            model.Users = _dataContext.Users.ToList();
            model.Payments = _dataContext.UserPayments.ToList();
            return model;
        }

        private IActionResult CheckAccess(int ActiveLinkIndex, object SuccessModel)
        {
            var model = new AccessDeniedViewModel();
            ClaimsIdentity user = (ClaimsIdentity)HttpContext.User.Identity;
            if (user.IsAuthenticated)
            {
                var claims = user.Claims.ToList();
                var roleClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role);
                if (roleClaim != null && roleClaim.Value == "1")
                {
                    return View(SuccessModel);
                }
                else
                {
                    model.AccessDeniedReason = "You have no sufficient priveleges to access this page.";
                    return View("AccessDenied", model);
                }
            }
            else
            {
                model.AccessDeniedReason = "You are not authenticated, please login first.";
                return View("AccessDenied", model);
            }
        }
    }
}
