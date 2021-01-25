using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Web.Models;
using Web.Settings;

namespace Web.Controllers
{
    public class RegisterController : Controller
    {
        private AppDataContext _dataContext;
        private readonly IOptions<AppSettings> appSettings;
        public RegisterController(AppDataContext context, IOptions<AppSettings> app)
        {
            _dataContext = context;
            appSettings = app;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisterViewModel model)
        {
            if (string.IsNullOrEmpty(model.FirstName))
            {
                model.RegistrationErrorMessage = "First name field is empty";
                return View(model);
            }
            if (string.IsNullOrEmpty(model.LastName))
            {
                model.RegistrationErrorMessage = "Last name field is empty";
                return View(model);
            }
            if (string.IsNullOrEmpty(model.Email))
            {
                model.RegistrationErrorMessage = "Email field is empty";
                return View(model);
            }
            if (string.IsNullOrEmpty(model.Password))
            {
                model.RegistrationErrorMessage = "Password field is empty";
                return View(model);
            }
            if (model.Password != model.RePassword)
            {
                model.RegistrationErrorMessage = "Passwords do not match";
                return View(model);
            }

            int passMinLenght = appSettings.Value.PasswordMinChar;
            if (model.Password.Length < passMinLenght)
            {
                model.RegistrationErrorMessage = "Password must be at least " + passMinLenght + " characters";
                return View(model);
            }

            if(!Utilities.Helpers.IsValidEmail(model.Email))
            {
                model.RegistrationErrorMessage = "Email address format is not correct";
                return View(model);
            }

            var userExists = _dataContext.Users.Where(u => u.Email == model.Email).FirstOrDefault();
            if(userExists != null)
            {
                model.RegistrationErrorMessage = "Email address " + model.Email + " is already in use";
                return View(model);
            }

            var user = new User();
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.AgreeReceiveMaterials = model.AgreeReceiveMaterials;
            user.DateRegistered = DateTimeOffset.Now;
            user.RoleId = (int)Utilities.Constants.Roles.User;
            user.Salt = Guid.NewGuid().ToString().Replace("-", String.Empty);
            string password_hash = "";
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(model.Password + user.Salt));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                password_hash = sBuilder.ToString();
            }
            user.PasswordHash = password_hash;
            _dataContext.Users.Add(user);
            _dataContext.SaveChanges();
            return View("Success");
        }
    }
}
