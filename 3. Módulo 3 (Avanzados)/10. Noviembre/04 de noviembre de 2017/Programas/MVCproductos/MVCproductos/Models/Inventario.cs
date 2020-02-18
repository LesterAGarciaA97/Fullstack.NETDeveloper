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
    [Bind(Exclude = "Correlativo")]
    public class Inventario
    {
        [Key]
        public int Correlativo { get; set; }
        [DisplayName("Código tipo registro")]
        [Required(ErrorMessage = "Debe ingresar un tipo de código del registro")]
        public string CodigoTipoRegistro { get; set; }
        [DisplayName("Salidas")]
        [Required(ErrorMessage = "Debe ingresar las salidas")]
        public int Salida { get; set; }
        [DisplayName("Entradas")]
        [Required(ErrorMessage = "Debe ingresar las entradas")]
        public int Entrada { get; set; }
        [DisplayName("Código de Producto")]
        [Required(ErrorMessage = "Debe ingresar el código del producto")]
        public int CodigoProducto { get; set; }
        [DisplayName("Precio")]
        [Required(ErrorMessage = "Debe ingresar el precio")]
        public decimal Precio { get; set; }
        [DisplayName("Fecha")]
        [Required(ErrorMessage = "Debe ingresar una fecha")]
        public DateTime Fecha { get; set; }
        public virtual TipoRegistro TipoRegistro { get; set; }
        public virtual Producto Producto { get; set; }
    }
}