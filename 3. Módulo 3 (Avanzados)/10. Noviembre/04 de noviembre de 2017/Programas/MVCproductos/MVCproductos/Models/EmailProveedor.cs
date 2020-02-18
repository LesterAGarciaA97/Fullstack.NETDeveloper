using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCproductos.Models
{
    [Bind(Exclude = "CodigoEmail")]
    public class EmailProveedor
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CodigoEmail { get; set; }
        [DisplayName("Proveedor")]
        public int CodigoProveedor { get; set; }
        [EmailAddress]
        [DisplayName("Direccion de Correo Electronico")]
        [Required(ErrorMessage="Debe registrar una direccion")]
        public string Email { get; set; }
        [DisplayName("Descripcion del tipo de correo Electronico")]
        [Required(ErrorMessage="Debe ingresar una direccion de correo")]
        public string Descripcion { get; set; }
        public virtual Proveedores Proveedores { get; set; }

    }
}