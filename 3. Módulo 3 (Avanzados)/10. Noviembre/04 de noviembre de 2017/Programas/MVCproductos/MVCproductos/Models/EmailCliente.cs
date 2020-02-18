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
    [Bind(Exclude = "CodigoEmail")]
    public class EmailCliente
    {
        [Key]
        public int CodigoEmail { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Debe ingresar un email válido")]
        public string Email { get; set; }
        [DisplayName("Descripción")]
        [Required(ErrorMessage = "Debe ingresar una descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Código de Cliente")]
        [Required(ErrorMessage = "Debe ingresar un código de cliente")]
        public int CodigoCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}