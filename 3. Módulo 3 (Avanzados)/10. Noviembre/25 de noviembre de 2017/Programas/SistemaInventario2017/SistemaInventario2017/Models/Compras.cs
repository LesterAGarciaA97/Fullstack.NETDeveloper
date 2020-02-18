using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SistemaInventario2017.Models
{
    
    public class Compras
    {
        [Key]
        [Display(Name = "Número de documento")]
        [Required(ErrorMessage = "Debe ingresar un número de documento")]        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroDocumento { get; set; }
        [Display(Name = "Proveedor")]
        [Required(ErrorMessage = "Debe selecionar un proveedor")]
        public int CodigoProveedor { get; set; }
        [ScaffoldColumn(false)]
        public string NombreUsuario { get; set; }
        public System.DateTime Fecha { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<Decimal> TotalCompra { get; set; }
        public virtual Proveedores Proveedor { get; set; }
        public virtual List<DetalleCompras> DetalleCompras { get; set;}
    }
}