using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPayment> UserPayments { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoCategory> VideoCategories { get; set; }
        public DbSet<AppSetting> AppSettings { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Subscribtion> Subscribtions { get; set; }
    }
}
