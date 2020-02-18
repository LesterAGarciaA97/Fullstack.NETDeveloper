using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaInventario2017.Models;
using SistemaInventario2017.ViewModels;
namespace SistemaInventario2017.Controllers
{
    public class RegistroCompraController : Controller
    {
        // GET: RegistroCompra
        private InventarioContext db = new InventarioContext();
        public ActionResult Index()
        {
            var Compra = BitacoraRegistroCompras.GetBitacoraRegistroCompra(this.HttpContext);
            var viewModel = new RegistroCompraViewModel
            {
                ElementosRegistroCompras = Compra.GetElementosRegistroCompra(),
                TotalRegistroCompra = Compra.GetTotalCompra()
            };
            return View(viewModel);
        }
        public ActionResult EliminarCompra(int Id)
        {
            var Compra = BitacoraRegistroCompras.GetBitacoraRegistroCompra(this.HttpContext);
            Compra.EliminarDeLaCompra(Id);
            return View();
        }

    }
}