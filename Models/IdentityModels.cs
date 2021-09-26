﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class ApplicationUser : IdentityUser
    {
        //You can extend this class by adding additional fields like Birthday
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public System.Data.Entity.DbSet<WebApiDemo.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}