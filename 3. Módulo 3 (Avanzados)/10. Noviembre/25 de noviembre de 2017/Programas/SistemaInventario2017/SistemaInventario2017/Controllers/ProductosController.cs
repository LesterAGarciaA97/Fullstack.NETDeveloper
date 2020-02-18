using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaInventario2017.Models;
using SistemaInventario2017.ViewModels;
namespace SistemaInventario2017.Controllers
{
    public class ProductosController : Controller
    {
        private InventarioContext db = new InventarioContext();

        // GET: Productos
        public ActionResult Index()
        {
            var productos = db.Productos.Include(p => p.Categoria).Include(p => p.TipoEmpaque);
            return View(productos.ToList());
        }

        // GET: Productos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            return View(productos);
        }

        // GET: Productos/Create
        public ActionResult Create()
        {
            ViewBag.CodigoCategoria = new SelectList(db.Categorias, "CodigoCategoria", "Descripcion");
            ViewBag.CodigoTipoEmpaque = new SelectList(db.TipoEmpaques, "CodigoTipoEmpaque", "Descripcion");
            return View();
        }
        public ActionResult RegistrarCompraProducto(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            var viewModelProducto = new CompraProductoViewModel
            {
                CodigoProducto = producto.CodigoProducto,
                Descripcion = producto.Descripcion,
                PrecioCompra = 0,
                Cantidad = 0
            };
            return View(viewModelProducto);
        }
        [HttpPost]
        public ActionResult RegistrarCompraProducto(CompraProductoViewModel producto)
        {
            var Compra = BitacoraRegistroCompras.GetBitacoraRegistroCompra(this.HttpContext);
            Compra.AgregarRegistroCompra(producto);
            return RedirectToAction("Index","RegistroCompra");
        }

        // POST: Productos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Productos productos)
        {
            if (ModelState.IsValid)
            {
                db.Productos.Add(productos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CodigoCategoria = new SelectList(db.Categorias, "CodigoCategoria", "Descripcion", productos.CodigoCategoria);
            ViewBag.CodigoTipoEmpaque = new SelectList(db.TipoEmpaques, "CodigoTipoEmpaque", "Descripcion", productos.CodigoTipoEmpaque);
            return View(productos);
        }

        // GET: Productos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            ViewBag.CodigoCategoria = new SelectList(db.Categorias, "CodigoCategoria", "Descripcion", productos.CodigoCategoria);
            ViewBag.CodigoTipoEmpaque = new SelectList(db.TipoEmpaques, "CodigoTipoEmpaque", "Descripcion", productos.CodigoTipoEmpaque);
            return View(productos);
        }

        // POST: Productos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Productos productos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CodigoCategoria = new SelectList(db.Categorias, "CodigoCategoria", "Descripcion", productos.CodigoCategoria);
            ViewBag.CodigoTipoEmpaque = new SelectList(db.TipoEmpaques, "CodigoTipoEmpaque", "Descripcion", productos.CodigoTipoEmpaque);
            return View(productos);
        }

        // GET: Productos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            return View(productos);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Productos productos = db.Productos.Find(id);
            db.Productos.Remove(productos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
