using FirstMvcApplication.DataAccess;
using FirstMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace FirstMvcApplication.Controllers
{
    public class CourseController : Controller
    {
        private RouxAcademyDbContext db = new RouxAcademyDbContext();
        public ActionResult Online()
        {
            /*var courses = db.Courses.Where(c => c.IsVirtual).OrderBy(c => c.Name).ToList();
            return View(courses);*/

            var courses = from c in db.Courses
                          where c.IsVirtual
                          orderby c.Name
                          select c;
            return View(courses.ToList());
        }
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            var courses = db.Courses.Where(c => c.Id == id).SingleOrDefault();
            return View(courses);
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        public ActionResult Create(Course course)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using(var context = new RouxAcademyDbContext())
                    {
                        context.Courses.Add(course);
                        context.SaveChanges();
                    }

                    return RedirectToAction("Index");
                }
                return View(course);
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Review()
        {
            return View();
        }
        public ActionResult Review(CourseReview review)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
