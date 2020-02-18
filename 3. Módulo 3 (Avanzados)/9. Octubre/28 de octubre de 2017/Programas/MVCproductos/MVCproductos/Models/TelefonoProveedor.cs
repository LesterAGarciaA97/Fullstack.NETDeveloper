using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace MVCproductos.Models
{
    [Bind(Exclude = "CodigoTelefono")]
    public class TelefonoProveedor
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CodigoTelefono { get; set; }
        [DisplayName("Proveedor")]
        public int CodigoProveedor { get; set; }
        [DisplayName("Numero de Telefono")]
        [Required(ErrorMessage="Debe ingresar un numero de telefono valido")]
        public string Telefono { get; set; }
        [DisplayName("Descripcion del Numero de Telefono")]
        [Required(ErrorMessage="Debe ingresar una descripcion del numero de telefono")]
        
        public string Descripcion { get; set; }
        public virtual Proveedores Proveedores { get; set; }
    }
}