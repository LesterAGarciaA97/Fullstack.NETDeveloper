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
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public virtual DbSet<DireccionCliente> DireccionCliente { get; set; }
        public virtual DbSet<EmailCliente> EmailCliente { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<TelefonoCliente> TelefonoCliente { get; set; }
        public virtual DbSet<TipoRegistro> TipoRegistro { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}