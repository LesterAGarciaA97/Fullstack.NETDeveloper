using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;

namespace MVCproductos.Models
{
    public class ProductosEntity : DbContext
    {
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<TipoEmpaque> TipoDeEmpaques { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedores> Proveedor { get; set; }
        public virtual DbSet<DireccionProveedor> DireccionProveedor { get; set; }
        public virtual DbSet<EmailProveedor> EmailProveedor { get; set; }
        public virtual DbSet<TelefonoProveedor> TelefonoProveedor { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<DetalleCompra> DetalleCompra { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}