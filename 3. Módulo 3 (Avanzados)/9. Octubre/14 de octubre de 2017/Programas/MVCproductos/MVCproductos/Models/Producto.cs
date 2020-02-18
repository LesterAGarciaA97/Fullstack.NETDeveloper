using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace MVCproductos.Models
{
    [Bind(Exclude = "CodigoProducto")]
    public class Producto
    {
        [Key]
        public int CodigoProducto { get; set; }
        [DisplayName("Producto")]
        [Required(ErrorMessage ="Debe ingresar una descripción")]
        public string Descripcion { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<Decimal> PrecioUnitario { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<Decimal> PrecioPorDocena { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<Decimal> PrecioPorMayor { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<int> Existencia { get; set; }
        [DisplayName("Imagen")]
        public string Imagen { get; set; }
        [DisplayName("Categoria")]
        public int CodigoCategoria { get; set; }
        [DisplayName("Tipo de empaque")]
        public int CodigoTipoEmpaque { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual TipoEmpaque TipoEmpaque { get; set; }
    }
}