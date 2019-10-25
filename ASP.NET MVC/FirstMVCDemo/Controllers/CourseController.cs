using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCDemo.Models;

namespace FirstMVCDemo.Controllers
{
    public class CourseController : Controller
    {
        private static List<Course> courses = new List<Course>();

        public static List<Course> Courses
        {
            get
            {
                if (courses == null)
                {
                    courses = new List<Course>();
                    courses.Add(new Course { courseID = 10, courseName="ASP.NET MVC" });
                    courses.Add(new Course { courseID = 11, courseName = "ASP.NET Blazer" });

                }
                return courses;
            }
            set
            {
                courses = value;
            }
            
        }

        // GET: Course
        public ActionResult Index()
        {
            return View(Courses);
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
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
    }
}
