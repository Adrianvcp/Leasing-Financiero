﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanzasTrabajoFinal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bdFinanzasEntities8 : DbContext
    {
        public bdFinanzasEntities8()
            : base("name=bdFinanzasEntities8")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrador> Administradors { get; set; }
        public virtual DbSet<Banco> Bancoes { get; set; }
        public virtual DbSet<Banco_Promocion> Banco_Promocion { get; set; }
        public virtual DbSet<carro> carroes { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Frecuencia> Frecuencias { get; set; }
        public virtual DbSet<leasing> leasings { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<PlazoGracia> PlazoGracias { get; set; }
        public virtual DbSet<Promocion> Promocions { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<nameBanco> nameBancoes { get; set; }
        public virtual DbSet<vwCarro> vwCarroes { get; set; }
    }
}