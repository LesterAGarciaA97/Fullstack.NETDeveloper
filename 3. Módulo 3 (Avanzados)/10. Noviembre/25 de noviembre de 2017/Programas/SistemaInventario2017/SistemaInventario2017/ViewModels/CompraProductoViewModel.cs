using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaInventario2017.ViewModels
{
    public class CompraProductoViewModel
    {
        public int CodigoProducto { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Precio de compra")]
        [Required(ErrorMessage = "Debe ingresar un valor")]
        public decimal PrecioCompra { get; set; }
        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "Debe ingresar una cantidad")]
        public int Cantidad { get; set; }
    }
}