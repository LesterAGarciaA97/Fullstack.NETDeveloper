using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCproductos.Models
{
    [Bind(Exclude = "CodigoDireccion")]
    public class DireccionProveedor
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CodigoDireccion { get; set; }
        [DisplayName("Proveedor")]
        public int CodigoProveedor { get; set; }
        [DisplayName("Direccion")]
        public string Direccion { get; set; }
        [DisplayName("Descripcion del tipo de direccion")]
        public string Descripcion { get; set; }
        public virtual Proveedores Proveedores { get; set; }


    }
}