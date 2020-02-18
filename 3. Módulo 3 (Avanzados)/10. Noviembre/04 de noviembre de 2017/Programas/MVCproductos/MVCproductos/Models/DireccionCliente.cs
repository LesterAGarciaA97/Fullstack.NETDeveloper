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
    [Bind(Exclude = "CodigoDireccion")]
    public class DireccionCliente
    {
        [Key]
        public int CodigoDireccion { get; set; }
        [DisplayName("Dirección")]
        [Required(ErrorMessage = "Debe ingresar una dirección")]
        public string Direccion { get; set; }
        [DisplayName("Descripción")]
        [Required(ErrorMessage = "Debe ingresar una descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Codigo del Cliente")]
        [Required(ErrorMessage = "Debe tener un código de cliente")]
        public int CodigoCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}