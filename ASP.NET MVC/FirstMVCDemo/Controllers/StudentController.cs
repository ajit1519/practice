using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCDemo.Models;

namespace FirstMVCDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private static List<Student> students=null;

        public static List<Student> Students
        {
            get
            {
                if(students==null)
                {
                    students = new List<Student>();
                    students.Add(new Student { RollNo = 101, Name = "Alok", Address = "Pune" });
                    students.Add(new Student { RollNo = 102, Name = "Ali", Address = "Delhi" });
                    students.Add(new Student { RollNo = 103, Name = "Aliya", Address = "Chennai" });
                }
                return students;
            }
            set
            {
                students = value;
            }  
          
        }

        public StudentController()
        {
            //students = new List<Student>();

        }
        public ActionResult Index()
        {
            //students.Clear();
            //students.Add(new Student { RollNo = 101, Name = "Alok", Address="Pune"});
            //students.Add(new Student { RollNo = 102, Name = "Ali", Address = "Delhi" });
            //students.Add(new Student { RollNo = 103, Name = "Aliya", Address = "Chennai" });
            return View(Students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student s1)
        {
            try
            {
                // TODO: Add insert logic here
                Students.Add(s1);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Students.Where(s=>s.RollNo==id).FirstOrDefault());
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student s1)
        {
            try
            {
                // TODO: Add update logic here
                var res = Students.FirstOrDefault(e => e.RollNo == id);
                if(res!=null)
                {
                    res.Name = s1.Name;
                    res.Age = s1.Age;
                    res.Address = s1.Address;
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Students.Where(s => s.RollNo == id).FirstOrDefault());
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Student s1)
        {
            try
            {
                // TODO: Add delete logic here
                Students.RemoveAll(s => s.RollNo == id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Display()
        {
            List<string> Student = new List<string>();
            Student.Add("Alok");
            Student.Add("Riya");
            Student.Add("Raman");
            ViewData["Student"] = Student;
            return View();
        }

        public ActionResult DisplayStudents()
        {
            List<Student> students1 = new List<Student>();
            students1.Add(new Student { RollNo = 101, Name = "Alok", Address = "Pune" });
            students1.Add(new Student { RollNo = 102, Name = "Ali", Address = "Delhi" });
            students1.Add(new Student { RollNo = 103, Name = "Aliya", Address = "Chennai" });
            ViewData["Student"] = students1;
            return View(students1);
        }

        public ActionResult ShowHome()
        {
            return View();
        }

        public ActionResult ShowAllStudents()
        {
            return View(Students);
        }
        //public JsonResult MyData()
        //{
        //    return View();
        //}
    }
}
