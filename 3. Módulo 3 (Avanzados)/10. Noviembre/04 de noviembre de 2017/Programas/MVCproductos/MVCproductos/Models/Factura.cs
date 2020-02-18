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
    [Bind(Exclude = "CodigoFactura")]
    public class Factura
    {
        [Key]
        public int CodigoFactura { get; set; }
        [DisplayName("Número de actura")]
        [Required(ErrorMessage = "Debe ingresar un número de factura")]
        public int NumeroFactura { get; set; }
        [DisplayName("Serie")]
        [Required(ErrorMessage = "Debe ingresar un número de serie")]
        public string Serie { get; set; }
        [DisplayName("Código de cliente")]
        [Required(ErrorMessage = "Debe ingresar un código de cliente")]
        public int CodigoCliente { get; set; }
        [DisplayName("Total")]
        [Required(ErrorMessage = "Debe ingresar un total")]
        public decimal Total { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual List<DetalleFactura> DetalleFactura { get; set; }
    }
}