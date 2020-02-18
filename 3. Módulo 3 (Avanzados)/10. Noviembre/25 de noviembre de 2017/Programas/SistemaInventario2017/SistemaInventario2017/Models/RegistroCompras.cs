using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SistemaInventario2017.Models
{
    [Bind(Exclude = "CodigoRegistro")]
    public class RegistroCompras
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CodigoRegistro { get; set;}
        public string NombreUsuario { get; set; }
        public int CodigoProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public virtual Productos Producto { get; set; }
    }
}