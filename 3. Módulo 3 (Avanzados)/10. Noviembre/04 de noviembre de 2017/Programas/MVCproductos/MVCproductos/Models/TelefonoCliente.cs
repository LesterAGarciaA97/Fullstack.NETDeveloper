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
    [Bind(Exclude = "CodigoTelefono")]
    public class TelefonoCliente
    {
        [Key]
        public int CodigoTelefono { get; set; }
        [DisplayName("Número de teléfono")]
        [Required(ErrorMessage = "Debe ingresar un número de teléfono")]
        public string NumeroTelefono { get; set; }
        [DisplayName("Descripción")]
        [Required(ErrorMessage = "Debe ingresar una descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Código de cliente")]
        [Required(ErrorMessage = "Debe ingresar un código de cliente")]
        public int CodigoCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}