﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SelfGym_Servidor
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class selfgymdbEntities : DbContext
    {
        public selfgymdbEntities()
            : base("name=selfgymdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EJERCICIO> EJERCICIO { get; set; }
        public virtual DbSet<LUGARES_RECREATIVOS> LUGARES_RECREATIVOS { get; set; }
        public virtual DbSet<RUTINA> RUTINA { get; set; }
        public virtual DbSet<RUTINA_EJERCICIO> RUTINA_EJERCICIO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<USUARIO_RUTINA> USUARIO_RUTINA { get; set; }
    }
}