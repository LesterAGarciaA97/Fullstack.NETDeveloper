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
    [Bind(Exclude = "CodigoCliente")]
    public class Cliente
    {
        [Key]
        public int CodigoCliente { get; set; }
        [DisplayName("NIT")]
        [Required(ErrorMessage = "Debe ingresar un número de NIT")]
        public string Nit { get; set; }
        [DisplayName("DPI")]
        [Required(ErrorMessage = "Debe ingresar un número de DPI")]
        public string Dpi { get; set; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }
        public virtual EmailCliente EmailCliente { get; set; }
        public virtual DireccionCliente DireccionCliente { get; set; }
        public virtual TelefonoCliente TelefonoCliente { get; set; }
        public virtual Factura Factura { get; set; }
    }
}