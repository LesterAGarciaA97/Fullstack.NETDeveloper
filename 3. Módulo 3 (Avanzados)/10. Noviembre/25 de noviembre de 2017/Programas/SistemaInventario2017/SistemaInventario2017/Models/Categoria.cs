using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Web;
namespace SistemaInventario2017.Models
{
    [Bind(Exclude = "CodigoCategoria")]
    public class Categoria
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CodigoCategoria { get; set; }
        [Required(ErrorMessage = "Debe ingrear una descripción")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public virtual List<Productos> Productos { get; set; }
    }
}