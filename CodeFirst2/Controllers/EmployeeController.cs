using CodeFirst2.Context;
using CodeFirst2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Controllers {
    public class EmployeeController : Controller {
        DepartmentContext db = new DepartmentContext();
        // GET: Employee
        public ActionResult Index() {
            return View(db.Employees.ToList());
        }





        // GET: Employee/Details/5
        public ActionResult Details(int id) {
            Employee emp = db.Employees.Find(id);
            return View(emp);
        }





        // GET: Employee/Create
        public ActionResult Create() {
            List<Department> list = db.Departments.ToList();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (Department department in list) {
                items.Add(new SelectListItem {
                    Text = department.DeptName,
                    Value = department.DeptId.ToString()
                });
            }
            ViewData["DeptID"] = items;
            return View();
        }





        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee) {
            try {
                // TODO: Add insert logic here
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }





        // GET: Employee/Edit/5
        public ActionResult Edit(int id) {
            List<Department> list = db.Departments.ToList();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (Department department in list) {
                items.Add(new SelectListItem {
                    Text = department.DeptName,
                    Value = department.DeptId.ToString()
                });
            }
            ViewData["DeptID"] = items;
            return View(db.Employees.Find(id));
        }





        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee employee) {
            try {
                // TODO: Add update logic here
                db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }





        // GET: Employee/Delete/5
        public ActionResult Delete(int id) {
            return View(db.Employees.Find(id));
        }





        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) {
            try {
                // TODO: Add delete logic here
                db.Employees.Remove(db.Employees.Find(id));
                db.SaveChanges();
                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }
    }
}