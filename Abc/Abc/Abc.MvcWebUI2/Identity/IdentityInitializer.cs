using Abc.MvcWebUI2.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI2.Identity
{
    public class IdentityInitializer: CreateDatabaseIfNotExists<IdentityDataContext>
        //modelde bir değişiklik olursa kapatıp açmak için
    {
        protected override void Seed(IdentityDataContext context)
        {
            //Rolleri oluştur
            if(!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store=new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() {Name="admin", Description="yönetici rolü" };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole(){ Name = "user", Description = "user rolü" }; ;
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "selvitopcu"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() {Name= "Selvi", Surname= "Topçu", UserName="selvitopcu", Email="selvitopcu@gmail.com" };
                manager.Create(user,"1234567");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user"); ;
            }

            if (!context.Users.Any(i => i.Name == "mervetopcu"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "merve", Surname = "Topçu", UserName = "mervetopcu", Email = "mervetopcu@gmail.com" };
                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            //Userları rollere ata
            base.Seed(context);


        }
    }
}