using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCproductos.Models
{
    public class ProductosEntity : DbContext
    {
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<TipoEmpaque> TipoDeEmpaques { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}