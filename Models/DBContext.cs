using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class DBContext:IdentityDbContext
    {
        public DBContext()
            :base("DBContext")
        {

        }
    }
}