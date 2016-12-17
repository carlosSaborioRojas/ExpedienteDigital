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
    public class CivilStatusController : Controller
    {
        private ExpedienteDigitalContext db = new ExpedienteDigitalContext();

        // GET: CivilStatus
        public ActionResult Index()
        {
            return View(db.Civil_Status.ToList());
        }

        // GET: CivilStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Civil_Status civil_Status = db.Civil_Status.Find(id);
            if (civil_Status == null)
            {
                return HttpNotFound();
            }
            return View(civil_Status);
        }

        // GET: CivilStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CivilStatus/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CivilStatusID,Description,Code")] Civil_Status civil_Status)
        {
            if (ModelState.IsValid)
            {
                db.Civil_Status.Add(civil_Status);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(civil_Status);
        }

        // GET: CivilStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Civil_Status civil_Status = db.Civil_Status.Find(id);
            if (civil_Status == null)
            {
                return HttpNotFound();
            }
            return View(civil_Status);
        }

        // POST: CivilStatus/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CivilStatusID,Description,Code")] Civil_Status civil_Status)
        {
            if (ModelState.IsValid)
            {
                db.Entry(civil_Status).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(civil_Status);
        }

        // GET: CivilStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Civil_Status civil_Status = db.Civil_Status.Find(id);
            if (civil_Status == null)
            {
                return HttpNotFound();
            }
            return View(civil_Status);
        }

        // POST: CivilStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Civil_Status civil_Status = db.Civil_Status.Find(id);
            db.Civil_Status.Remove(civil_Status);
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
