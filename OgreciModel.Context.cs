﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitySample
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbSinavOgrenciEntities : DbContext
    {
        public DbSinavOgrenciEntities()
            : base("name=DbSinavOgrenciEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLDERSLER> TBLDERSLER { get; set; }
        public virtual DbSet<TBLNOTLAR> TBLNOTLAR { get; set; }
        public virtual DbSet<TBLOGRENCI> TBLOGRENCI { get; set; }
        public virtual DbSet<TBLHOBBYCLUBS> TBLHOBBYCLUBS { get; set; }
    
        public virtual ObjectResult<NOTLIST_Result> NOTLIST()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NOTLIST_Result>("NOTLIST");
        }
    }
}
