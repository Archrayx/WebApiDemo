using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiDemo.Models;
namespace WebApiDemo
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            //app.CreatePerOwinContext();
        }
    }
}