using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCproductos.Models;

namespace MVCproductos.Controllers
{
    public class ProductoesController : Controller
    {
        private ProductosEntity db = new ProductosEntity();

        // GET: Productoes
        public ActionResult Index()
        {
            var productos = db.Productos.Include(p => p.Categoria).Include(p => p.TipoEmpaque);
            return View(productos.ToList());
        }

        // GET: Productoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // GET Productos/Categoria
        public ActionResult CategoriaProductos(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var Producto = db.Productos.Where(p => p.CodigoCategoria == id);
            if (Producto == null)
            {
                return HttpNotFound();
            }
            return View(Producto.ToList());
        }

        // GET: Productoes/Create
        public ActionResult Create()
        {
            ViewBag.CodigoCategoria = new SelectList(db.Categorias, "CodigoCategoria", "Descripcion");
            ViewBag.CodigoTipoEmpaque = new SelectList(db.TipoDeEmpaques, "CodigoTipoEmpaque", "Descripcion");
            return View();
        }

        // POST: Productoes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Productos.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CodigoCategoria = new SelectList(db.Categorias, "CodigoCategoria", "Descripcion", producto.CodigoCategoria);
            ViewBag.CodigoTipoEmpaque = new SelectList(db.TipoDeEmpaques, "CodigoTipoEmpaque", "Descripcion", producto.CodigoTipoEmpaque);
            return View(producto);
        }

        // GET: Productoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            ViewBag.CodigoCategoria = new SelectList(db.Categorias, "CodigoCategoria", "Descripcion", producto.CodigoCategoria);
            ViewBag.CodigoTipoEmpaque = new SelectList(db.TipoDeEmpaques, "CodigoTipoEmpaque", "Descripcion", producto.CodigoTipoEmpaque);
            return View(producto);
        }

        // POST: Productoes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CodigoCategoria = new SelectList(db.Categorias, "CodigoCategoria", "Descripcion", producto.CodigoCategoria);
            ViewBag.CodigoTipoEmpaque = new SelectList(db.TipoDeEmpaques, "CodigoTipoEmpaque", "Descripcion", producto.CodigoTipoEmpaque);
            return View(producto);
        }

        // GET: Productoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Producto producto = db.Productos.Find(id);
            db.Productos.Remove(producto);
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
