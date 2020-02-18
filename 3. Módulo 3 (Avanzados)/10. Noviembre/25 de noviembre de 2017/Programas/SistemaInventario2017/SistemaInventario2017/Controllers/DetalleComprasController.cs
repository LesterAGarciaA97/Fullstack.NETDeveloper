using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaInventario2017.Models;

namespace SistemaInventario2017.Controllers
{
    public class DetalleComprasController : Controller
    {
        private InventarioContext db = new InventarioContext();

        // GET: DetalleCompras
        public ActionResult Index()
        {
            var detalleCompras = db.DetalleCompras.Include(d => d.Compra).Include(d => d.Producto);
            return View(detalleCompras.ToList());
        }

        public ActionResult VerDetalleCompra(int? id)
        {
            var detalleCompras = db.DetalleCompras.Include(d => d.Producto).Where(d => d.NumeroDocumento == id);
            return View(detalleCompras.ToList());
        }

        // GET: DetalleCompras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleCompras detalleCompras = db.DetalleCompras.Find(id);
            if (detalleCompras == null)
            {
                return HttpNotFound();
            }
            return View(detalleCompras);
        }

        // GET: DetalleCompras/Create
        public ActionResult Create()
        {
            ViewBag.NumeroDocumento = new SelectList(db.Compras, "NumeroDocumento", "NombreUsuario");
            ViewBag.CodigoProducto = new SelectList(db.Productos, "CodigoProducto", "Descripcion");
            return View();
        }

        // POST: DetalleCompras/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DetalleCompras detalleCompras)
        {
            if (ModelState.IsValid)
            {
                db.DetalleCompras.Add(detalleCompras);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NumeroDocumento = new SelectList(db.Compras, "NumeroDocumento", "NombreUsuario", detalleCompras.NumeroDocumento);
            ViewBag.CodigoProducto = new SelectList(db.Productos, "CodigoProducto", "Descripcion", detalleCompras.CodigoProducto);
            return View(detalleCompras);
        }

        // GET: DetalleCompras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleCompras detalleCompras = db.DetalleCompras.Find(id);
            if (detalleCompras == null)
            {
                return HttpNotFound();
            }
            ViewBag.NumeroDocumento = new SelectList(db.Compras, "NumeroDocumento", "NombreUsuario", detalleCompras.NumeroDocumento);
            ViewBag.CodigoProducto = new SelectList(db.Productos, "CodigoProducto", "Descripcion", detalleCompras.CodigoProducto);
            return View(detalleCompras);
        }

        // POST: DetalleCompras/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DetalleCompras detalleCompras)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalleCompras).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NumeroDocumento = new SelectList(db.Compras, "NumeroDocumento", "NombreUsuario", detalleCompras.NumeroDocumento);
            ViewBag.CodigoProducto = new SelectList(db.Productos, "CodigoProducto", "Descripcion", detalleCompras.CodigoProducto);
            return View(detalleCompras);
        }

        // GET: DetalleCompras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleCompras detalleCompras = db.DetalleCompras.Find(id);
            if (detalleCompras == null)
            {
                return HttpNotFound();
            }
            return View(detalleCompras);
        }

        // POST: DetalleCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetalleCompras detalleCompras = db.DetalleCompras.Find(id);
            db.DetalleCompras.Remove(detalleCompras);
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
