using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SistemaInventario2017.Models
{
    [Bind(Exclude = "CodigoProducto")]
    public class Productos
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CodigoProducto { get; set; }
        [Required(ErrorMessage = "Debe selecionar una categoria")]
        [Display(Name = "Categoria")]
        public int CodigoCategoria { get; set; }
        [Display(Name ="Tipo de empaque")]
        [Required(ErrorMessage = "Debe seleccionar un tipo de empaque")]
        public int CodigoTipoEmpaque { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<Decimal> PrecioUnitario { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<Decimal> PrecioPorDocena { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<Decimal> PrecioPorMayor { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<int> Existencia { get; set; }
        public string imagen { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual TipoEmpaque TipoEmpaque { get; set; }        
    }
}