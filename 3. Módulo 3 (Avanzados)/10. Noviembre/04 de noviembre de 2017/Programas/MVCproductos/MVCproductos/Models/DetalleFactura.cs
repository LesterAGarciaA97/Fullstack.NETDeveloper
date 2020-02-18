using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCproductos.Models
{
    [Bind(Exclude = "CodigoFacturaDetalle")]
    public class DetalleFactura
    {
        [Key]
        public int CodigoFacturaDetalle { get; set; }
        [DisplayName("Codigo de factura")]
        [Required(ErrorMessage = "Debe ingresar un código de factura")]
        public int CodigoFactura { get; set; }
        [DisplayName("Codigo de producto")]
        [Required(ErrorMessage = "Debe ingresar un código de producto")]
        public int CodigoProducto { get; set; }
        [DisplayName("Precio")]
        [Required(ErrorMessage = "Debe ingresar un precio")]
        public decimal Precio { get; set; }
        [DisplayName("Cantidad")]
        [Required(ErrorMessage = "Debe ingresar una cantidad")]
        public int Cantidad { get; set; }
        [DisplayName("Subtotal")]
        [Required(ErrorMessage = "Debe ingresar un subtotal")]
        public decimal SubTotal { get; set; }
        public virtual Factura Factura { get; set; }
        public virtual Producto Producto { get; set; }
    }
}