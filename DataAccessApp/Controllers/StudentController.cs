using DataAccessApp.DataAccess;
using DataAccessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAccessApp.Controllers
{
    public class StudentController : Controller
    {
        private StudentDbContext db = new StudentDbContext();
        public ActionResult Online()
        {
            // var std = db.Students.OrderBy(c => c.Name);
            var std = from c in db.Students
                      orderby c.Name
                      select c;
            return View(std.ToList());
        }
        // GET: Student
        public ActionResult Index()
        {

            return View();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            var std =db.Students.Where(c=>c.Id == id).SingleOrDefault();
            return View(std);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student students)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    using(var context = new StudentDbContext())
                    {
                        context.Students.Add(students);
                        context.SaveChanges();
                    }
                    return RedirectToAction("Online");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            var std = (from c in db.Students
                       where c.Id == id
                       select c).First();

            return View(std);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var std = (from c in db.Students
                              where c.Id == id
                              select c).First();
                    std.Name = collection["Name"];
                    std.Course = collection["Course"];
                    std.RollNo = collection["RollNo"];
                    std.Mobile = collection["Mobile"];
                    db.SaveChanges();
                }
                return RedirectToAction("Online");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            var std = db.Students.Find(id);
            return View(std);
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    var std = db.Students.Find(id);
                    db.Students.Remove(std);
                    db.SaveChanges();
                }
                return RedirectToAction("Online");
            }
            catch
            {
                return View();
            }
        }
    }
}
