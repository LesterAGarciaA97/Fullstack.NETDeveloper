using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace SistemaInventario2017.Models
{
    [Bind(Exclude = "CodigoProveedor")]
    public class Proveedores
    {

        [Key]
        public int CodigoProveedor { get; set; }
        [Display(Name = "Número de nit")]
        [Required(ErrorMessage = "Debe ingresar un número de nit")]
        public string Nit { get; set; }
        [Display(Name = "Razon Social")]
        [Required(ErrorMessage = "Debe escribir una razon social")]
        public string RazonSocial { get; set; }
        [Display(Name = "Pagina Web")]
        public string PaginaWeb { get; set; }
        [Display(Name = "Contacto")]
        [Required(ErrorMessage = "Debe ingresar un contacto principal")]
        public string ContactoPrincipal { get; set; }
        public virtual List<Compras> Compras { get; set; }

    }
}