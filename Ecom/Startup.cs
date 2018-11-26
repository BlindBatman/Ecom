using Ecom.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ecom.Startup))]
namespace Ecom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //ApplicationDbContext context = new ApplicationDbContext();
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            //var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //if (!roleManager.RoleExists("Admin"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Admin";
            //    roleManager.Create(role);
            //    var user = new ApplicationUser();
            //    user.UserName = "admin@test.com";
            //    user.Email = "admin@test.com";
            //    string userPWD = "P@ssw0rd";
            //    var chkUser = UserManager.Create(user, userPWD);
            //    //Add default User to Role Adminif (chkUser.Succeeded){var result1 = UserManager.AddToRole(user.Id, "Admin");}}
            //}
        }
    }
}
