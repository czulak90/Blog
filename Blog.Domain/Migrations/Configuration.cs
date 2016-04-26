using Blog.Domain.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Blog.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Blog.Domain.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Blog.Domain.BlogDbContext context)
        { 
            var roleStore = new RoleStore<IdentityRole>(context);
            var rolemanager = new RoleManager<IdentityRole>(roleStore);
            var role = rolemanager.FindByName("Admin");
            if (role == null)
            {
                role = new IdentityRole("Admin");
                rolemanager.Create(role);
            }
            role = rolemanager.FindByName("User");
            if (role == null)
            {
                role = new IdentityRole("User");
                rolemanager.Create(role);
            }
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var user = userManager.FindByName("Administrator");
            if (user == null)
            {
                var newUser = new ApplicationUser()
                {
                    UserName = "Administrator",
                    Email = "admin@admin.com",
                    EmailConfirmed = true,
                    LockoutEnabled = false
                };
                userManager.Create(newUser, "123456");
                userManager.AddToRole(newUser.Id, "Admin");
            }
        }
    }
}
