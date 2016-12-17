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
    public class EmpleadoController : Controller
    {
        private ExpedienteDigitalContext db = new ExpedienteDigitalContext();

        // GET: Empleado
        public ActionResult Index()
        {
           
           return View(db.Empleadoes.ToList());
        }

        // GET: Empleado/Details/5
        public ActionResult Detalles(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleadoes.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // GET: Empleado/Create
        public ActionResult Create()
        {
            //Llena la lista
            ViewBag.StateEmpleyeesId = new SelectList(db.State_Employees, "StateEmpleyeesId", "Description");


            SelectList ListStateCivil = new SelectList(db.Civil_Status, "CivilStatusID", "Description");

            List<SelectList> newList = new List<SelectList>();


           

            ViewBag.CivilStatusID = ListStateCivil;





            ViewBag.DocumentTypeId = new SelectList(db.Document_Type, "DocumentTypeId","Description");
            return View();

        }

        // POST: Empleado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpleadoID,Nombre,Apellido,SegundoApellido,Edad,FechaNacimiento,FechaIngreso,Direccion,Email,Salario,Cedula,telefono,Puesto,StateEmpleyeesId,CivilStatusID,DocumentTypeId")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.Empleadoes.Add(empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Error");
        }

        // GET: Empleado/Edit/5

            //ESTO ES UNA PRUEBA

        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleadoes.Find(id);
            var listaEstado = db.State_Employees.ToList();
            listaEstado = listaEstado.OrderBy(x => x.StateEmpleyeesId != empleado.StateEmpleyeesId).ToList();
            ViewBag.StateEmpleyeesId = new SelectList(listaEstado, "StateEmpleyeesId", "Description");
            ViewBag.FechaIngreso = empleado.FechaIngreso;


            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // POST: Empleado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "EmpleadoID,Nombre,Apellido,SegundoApellido,Edad,FechaNacimiento,FechaIngreso,Direccion,Email,Salario,Cedula,telefono,Puesto,StateEmpleyeesId")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

        // GET: Empleado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleadoes.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // POST: Empleado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = db.Empleadoes.Find(id);
            db.Empleadoes.Remove(empleado);
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
