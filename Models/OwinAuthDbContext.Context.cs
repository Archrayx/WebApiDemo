﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiDemo.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public class TokenTestEntities : IdentityDbContext
    {
        public TokenTestEntities()
            : base("OwinAuthDbContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    }
}