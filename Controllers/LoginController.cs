using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Web.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        private AppDataContext _dataContext;
        public LoginController(AppDataContext context)
        {
            _dataContext = context;
        }

        public IActionResult Index()
        {
            bool isAuthenticated = HttpContext.User.Identity.IsAuthenticated;
            if (isAuthenticated)
                return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var user = _dataContext.Users.Where(u => u.Email == model.Email).FirstOrDefault();
            if(user == null)
            {
                model.IsLoggedIn = false;
                model.ErrorMessage = "Login failed, user not found";
                return View(model);
            }

            string salt = user.Salt;
            string password_hash = string.Empty;
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(model.Password + salt));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                password_hash = sBuilder.ToString();
            }

            if(password_hash != user.PasswordHash)
            {
                model.IsLoggedIn = false;
                model.ErrorMessage = "Login failed, password is not correct";
                return View(model);
            }

            //Login was successful, update last login date and return view
            user.DateLastLogin = DateTimeOffset.Now;
            _dataContext.SaveChanges();
            model.IsLoggedIn = true;
            model.ErrorMessage = string.Empty;

            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.FirstName + " " + user.LastName),
                new Claim(ClaimTypes.Role, user.RoleId.ToString()),
            };

            //If remember me checked, save cookies for 1 week, otherwise 1 hour
            int minutes = model.RememberMe ? 10000 : 60;

            var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var userPrincipal = new ClaimsPrincipal(userIdentity);
            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = true,
                // Refreshing the authentication session should be allowed.

                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(minutes),
                // The time at which the authentication ticket expires. A 
                // value set here overrides the ExpireTimeSpan option of 
                // CookieAuthenticationOptions set with AddCookie.

                IsPersistent = true,
                // Whether the authentication session is persisted across 
                // multiple requests. When used with cookies, controls
                // whether the cookie's lifetime is absolute (matching the
                // lifetime of the authentication ticket) or session-based.

                IssuedUtc = DateTimeOffset.Now,
                // The time at which the authentication ticket was issued.

                RedirectUri = "/Home"
                // The full path or absolute URI to be used as an http 
                // redirect response value.
            };

            await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(userIdentity),
            authProperties);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
