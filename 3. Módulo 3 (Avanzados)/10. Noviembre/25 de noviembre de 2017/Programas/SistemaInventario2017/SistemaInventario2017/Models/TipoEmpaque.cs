using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace SistemaInventario2017.Models
{
    [Bind(Exclude = "CodigoTipoEmpaque")]
    public class TipoEmpaque
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CodigoTipoEmpaque { get; set; }
        [Required(ErrorMessage = "Debe ingresar una descripción")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public virtual List<Productos> Productos { get; set; }
    }
}