using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace SistemaInventario2017.Models
{
    [Bind(Exclude = "CodigoDetalleCompra")]
    public class DetalleCompras
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CodigoDetalleCompra { get; set; }
        [ScaffoldColumn(false)]
        public int NumeroDocumento { get; set; }
        [Display(Name = "Producto")]
        [Required(ErrorMessage = "Debe seleccionar un producto")]
        public int CodigoProducto { get; set; }
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }
        [Display(Name = "Precio unitario")]
        [Required(ErrorMessage = "Debe ingresar el precio")]
        public Nullable<Decimal> Precio { get; set; }
        [ScaffoldColumn(false)]
        [Display(Name = "Sub Total")]
        public Nullable<Decimal> SubTotal { get; set; }
        public virtual Productos Producto { get; set; }
        public virtual Compras Compra { get; set; }
    }
}