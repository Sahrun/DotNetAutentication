﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetAutentication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutenticationEntities : DbContext
    {
        public AutenticationEntities()
            : base("name=AutenticationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<MappingRoleUser> MappingRoleUser { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
    }
}
