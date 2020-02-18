using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace MVCproductos.Models
{
    [Bind(Exclude = "CodigoProveedor")]
    public class Proveedores
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CodigoProveedor { get; set; }
        [DisplayName("Numero de Nit")]
        [Required(ErrorMessage="Debe registrar un numero de Nit valido")]
        public string Nit { get; set; }
        [DisplayName("Nombre de la Empresa")]
        [Required(ErrorMessage = "Debe registrar un nombre valido")]
        public string RazonSocial { get; set; }
        [DisplayName("Direccion de pagina Web")]
        public string PaginaWeb { get; set; }
        [DisplayName("Nombre del Contacto Principal")]
        [Required(ErrorMessage = "Debe registrar un nombre ")]
        public string ContactoPrincipal { get; set; }
        public virtual List<DireccionProveedor> Direcciones { get; set; }
        public virtual List<EmailProveedor> Emails { get; set; }
        public virtual List<TelefonoProveedor> Telefonos { get; set; }
        public virtual List<Compra> Compras { get; set; }

    }
}