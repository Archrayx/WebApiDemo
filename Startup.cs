using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;
using WebApiDemo.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

[assembly: OwinStartup(typeof(WebApiDemo.Startup))]

namespace WebApiDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext<DBContext>(() => new DBContext());
            app.CreatePerOwinContext<UserManager<IdentityUser>>(CreateManager);
        }

        private static UserManager<IdentityUser> CreateManager(IdentityFactoryOptions<UserManager<IdentityUser>> options, IOwinContext context)
        {
            var userStore = new UserStore<IdentityUser>(context.Get<DBContext>());
            var owinManager = new UserManager<IdentityUser>(userStore);
            return owinManager;
        }
    }
}