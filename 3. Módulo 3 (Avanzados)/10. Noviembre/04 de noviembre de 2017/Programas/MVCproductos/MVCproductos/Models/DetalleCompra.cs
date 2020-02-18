using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCproductos.Models
{
    [Bind(Exclude = "CodigoDetalleCompra")]
    public class DetalleCompra
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CodigoDetalleCompra { get; set; }
        public int NumeroDocumento { get; set; }
        [DisplayName("Producto")]
        [Required(ErrorMessage="Debe Seleccionar un producto")]
        public int CodigoProducto { get; set; }
        [DisplayName("Numero de Unidades")]
        [Required(ErrorMessage="Debe ingresar una cantidad valida")]
        public int Cantidad { get; set; }
        [DisplayName("Precio Unitario")]
        [Required(ErrorMessage="Debe Ingresar un Precio")]
        public Nullable<Decimal> Precio { get; set; }
        public Nullable<Decimal> SubTotal { get; set; }
        
        public virtual Compra Compra { get; set; }
        public virtual Producto Producto { get; set; }

    }
}