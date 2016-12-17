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
    public class StateEmployeesController : Controller
    {
        private ExpedienteDigitalContext db = new ExpedienteDigitalContext();

        // GET: StateEmployees
        public ActionResult Index()
        {
            return View(db.State_Employees.ToList());
        }

        // GET: StateEmployees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            State_Employees state_Employees = db.State_Employees.Find(id);
            if (state_Employees == null)
            {
                return HttpNotFound();
            }
            return View(state_Employees);
        }

        // GET: StateEmployees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StateEmployees/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StateEmpleyeesId,Description,Code")] State_Employees state_Employees)
        {
            if (ModelState.IsValid)
            {
                db.State_Employees.Add(state_Employees);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(state_Employees);
        }

        // GET: StateEmployees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            State_Employees state_Employees = db.State_Employees.Find(id);
            
            if (state_Employees == null)
            {
                return HttpNotFound();
            }
            return View(state_Employees);
        }

        // POST: StateEmployees/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StateEmpleyeesId,Description,Code")] State_Employees state_Employees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(state_Employees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(state_Employees);
        }

        // GET: StateEmployees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            State_Employees state_Employees = db.State_Employees.Find(id);
            if (state_Employees == null)
            {
                return HttpNotFound();
            }
            return View(state_Employees);
        }

        // POST: StateEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            State_Employees state_Employees = db.State_Employees.Find(id);
            db.State_Employees.Remove(state_Employees);
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
