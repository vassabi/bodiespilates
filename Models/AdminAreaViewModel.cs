using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class AdminAreaViewModel
    {
        public AdminAreaViewModel()
        {
            UserModel = new EditUserViewModel();
        }

        public List<AdminAreaViewModelLink> Links { get; set; }
        public List<Question> Questions { get; set; }
        public List<Story> Stories { get; set; }
        public List<User> Users { get; set; }
        public List<UserPayment> Payments { get; set; }
        public EditUserViewModel UserModel { get; set; }
    }

    public class EditUserViewModel
    {
        public User User { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AdminAreaViewModelLink
    {
        public string Text { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public bool IsActive { get; set; }
    }
}
