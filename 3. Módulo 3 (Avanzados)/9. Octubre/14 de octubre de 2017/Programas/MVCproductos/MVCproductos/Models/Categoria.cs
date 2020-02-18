using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace MVCproductos.Models
{
    [Bind(Exclude ="CodigoCategoria")]
    public class Categoria
    {
        [Key]
        public int CodigoCategoria{get; set;}
        [DisplayName("Categoría")]
        [Required(ErrorMessage ="Debe ingresar una descripción")]
        public string Descripcion{get; set;}
    }
}