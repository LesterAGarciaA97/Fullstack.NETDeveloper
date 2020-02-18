using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaInventario2017.Models;
namespace SistemaInventario2017.ViewModels
{
    public class RegistroCompraViewModel
    {
        public List<RegistroCompras> ElementosRegistroCompras { get; set; }
        public decimal TotalRegistroCompra { get; set; }
    }
}