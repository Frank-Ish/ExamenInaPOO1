﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbExamen1POOEntities : DbContext
    {
        public dbExamen1POOEntities()
            : base("name=dbExamen1POOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbAutomovil> tbAutomovil { get; set; }
        public virtual DbSet<tbColor> tbColor { get; set; }
        public virtual DbSet<tbMarca> tbMarca { get; set; }
        public virtual DbSet<tbTipoVehiculo> tbTipoVehiculo { get; set; }
    }
}
