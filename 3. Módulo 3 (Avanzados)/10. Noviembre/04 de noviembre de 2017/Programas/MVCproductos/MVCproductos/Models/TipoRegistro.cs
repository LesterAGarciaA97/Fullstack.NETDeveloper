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
    [Bind(Exclude = "CodigoTipoRegistro")]
    public class TipoRegistro
    {
        [Key]
        public int CodigoTipoRegistro { get; set; }
        [DisplayName("Descripción")]
        [Required(ErrorMessage = "Debe ingresar una descripción")]
        public decimal Descripcion { get; set; }
        public virtual Inventario Inventario { get; set; }
    }
}