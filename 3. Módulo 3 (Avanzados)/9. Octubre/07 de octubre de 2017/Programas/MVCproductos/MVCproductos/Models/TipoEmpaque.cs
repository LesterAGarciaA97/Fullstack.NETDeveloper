using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace MVCproductos.Models
{
    [Bind(Exclude = "CodigoTipoEmpaque")]
    public class TipoEmpaque
    {
        [Key]
        public int CodigoTipoEmpaque { get; set; }
        [DisplayName("Descripción del tipo de empaque")]
        [Required(ErrorMessage ="Debe ingresar un descripción")]
        public string Descripcion { get; set; }
    }
}