﻿using System;
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
    public class TipoEmpaquesController : Controller
    {
        private ProductosEntity db = new ProductosEntity();

        // GET: TipoEmpaques
        public ActionResult Index()
        {
            return View(db.TipoDeEmpaques.ToList());
        }

        // GET: TipoEmpaques/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEmpaque tipoEmpaque = db.TipoDeEmpaques.Find(id);
            if (tipoEmpaque == null)
            {
                return HttpNotFound();
            }
            return View(tipoEmpaque);
        }

        // GET: TipoEmpaques/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEmpaques/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoEmpaque tipoEmpaque)
        {
            if (ModelState.IsValid)
            {
                db.TipoDeEmpaques.Add(tipoEmpaque);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoEmpaque);
        }

        // GET: TipoEmpaques/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEmpaque tipoEmpaque = db.TipoDeEmpaques.Find(id);
            if (tipoEmpaque == null)
            {
                return HttpNotFound();
            }
            return View(tipoEmpaque);
        }

        // POST: TipoEmpaques/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoEmpaque tipoEmpaque)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoEmpaque).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoEmpaque);
        }

        // GET: TipoEmpaques/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEmpaque tipoEmpaque = db.TipoDeEmpaques.Find(id);
            if (tipoEmpaque == null)
            {
                return HttpNotFound();
            }
            return View(tipoEmpaque);
        }

        // POST: TipoEmpaques/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoEmpaque tipoEmpaque = db.TipoDeEmpaques.Find(id);
            db.TipoDeEmpaques.Remove(tipoEmpaque);
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
