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
    
    public class Compra
    {
        [Key]    
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//con esta instruccion se declara que no es autoincrementable
        public int NumeroDocumento { get; set; }
        [DisplayName("Proveedor")]
        [Required(ErrorMessage="Debe seleccionar un proveedor")]
        public int CodigoProveedor { get; set; }
        [DisplayName("Fecha de Emision")]
        public DateTime Fecha { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<Decimal> Total { get; set; }
        [ScaffoldColumn(false)]
        
        public string SessionUsuario { get; set; }
        public virtual Proveedores Proveedores { get; set; }
        public virtual List<DetalleCompra> Detalle { get; set; }

    }
}