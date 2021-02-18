using CodeFirst2.Context;
using CodeFirst2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace CodeFirst.Controllers {
    public class DepartmentController : Controller {
        DepartmentContext db = new DepartmentContext();
        // GET: Department
        public ActionResult Index() {
            return View(db.Departments.ToList());
        }



        // GET: Department/Details/5
        public ActionResult Details(int id) {
            Department entry = db.Departments.Find(id);
            return View("Details", entry);
        }



        // GET: Department/Create
        public ActionResult Create() {
            return View();
        }



        // POST: Department/Create
        [HttpPost]
        public ActionResult Create(Department department) {
            try {
                // TODO: Add insert logic here
                if (ModelState.IsValid) {
                    db.Departments.Add(department);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View("Index");
            } catch {
                return View();
            }
        }



        // GET: Department/Edit/5
        public ActionResult Edit(int id) {
            Department entry = db.Departments.Find(id);
            return View("Edit", entry);
        }



        // POST: Department/Edit/5
        [HttpPost]
        public ActionResult Edit(Department collection) {
            try {
                // TODO: Add update logic here



                db.Entry(collection).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }



        // GET: Department/Delete/5
        public ActionResult Delete(int id) {
            return View(db.Departments.Find(id));
        }





        // POST: Department/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) {
            try {
                // TODO: Add delete logic here
                db.Departments.Remove(db.Departments.Find(id));
                db.SaveChanges();
                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }
    }
}