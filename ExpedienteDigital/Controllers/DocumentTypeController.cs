using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExpedienteDigital.Models;

namespace ExpedienteDigital.Controllers
{
    public class DocumentTypeController : Controller
    {
        private ExpedienteDigitalContext db = new ExpedienteDigitalContext();

        // GET: DocumentType
        public ActionResult Index()
        {
            return View(db.Document_Type.ToList());
        }

        // GET: DocumentType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Document_Type document_Type = db.Document_Type.Find(id);
            if (document_Type == null)
            {
                return HttpNotFound();
            }
            return View(document_Type);
        }

        // GET: DocumentType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DocumentType/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DocumentTypeId,Description,Code")] Document_Type document_Type)
        {
            if (ModelState.IsValid)
            {
                db.Document_Type.Add(document_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(document_Type);
        }

        // GET: DocumentType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Document_Type document_Type = db.Document_Type.Find(id);
            if (document_Type == null)
            {
                return HttpNotFound();
            }
            return View(document_Type);
        }

        // POST: DocumentType/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DocumentTypeId,Description,Code")] Document_Type document_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(document_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(document_Type);
        }

        // GET: DocumentType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Document_Type document_Type = db.Document_Type.Find(id);
            if (document_Type == null)
            {
                return HttpNotFound();
            }
            return View(document_Type);
        }

        // POST: DocumentType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Document_Type document_Type = db.Document_Type.Find(id);
            db.Document_Type.Remove(document_Type);
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
