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
using Microsoft.Owin.Security.OAuth;
using WebApiDemo;


[assembly: OwinStartup(typeof(Startup))]

/*namespace WebApiDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            ConfigureOAuth(app);

        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            //app.CreatePerOwinContext(() => new (ApplicationDBContext));
            app.CreatePerOwinContext<UserManager<IdentityUser>>(CreateManager);
            app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/oauth/token"),
                Provider = new AuthorizationServerProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
                AllowInsecureHttp = true,

            });
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }

        /*private static UserManager<IdentityUser> CreateManager(IdentityFactoryOptions<UserManager<IdentityUser>> options, IOwinContext context)
        {
           // var userStore = new UserStore<IdentityUser>(context.Get<DBContext>());
           // var owinManager = new UserManager<IdentityUser>(userStore);
           // return owinManager;
        }
        
    }
}*/