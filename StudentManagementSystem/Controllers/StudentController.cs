using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _Db;

        public StudentController(ApplicationDbContext Db)
        {
            _Db=Db;
        }


        public IActionResult Index()
        {
           IEnumerable<Student> obj = _Db.Students.ToList();
            return View(obj);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Student obj)
        {
            if (ModelState.IsValid) { 
                _Db.Students.Add(obj);
                _Db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        public  IActionResult Edit(int id)
        {
            Student obj = _Db.Students.FirstOrDefault(u => u.StudentId == id);
            return View(obj);
        }


        [HttpPost]
        public IActionResult Edit(Student obj)
        {
            if (ModelState.IsValid)
            {
                _Db.Students.Update(obj);
                _Db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        public IActionResult Delete(int id)
        {
            Student obj = _Db.Students.FirstOrDefault(u=>u.StudentId==id);
            return View(obj);
        }


        [HttpPost]
        public IActionResult Delete(int? id)
        {
            Student obj = _Db.Students.FirstOrDefault(u => u.StudentId == id);
            if (ModelState.IsValid)
            {
                _Db.Students.Remove(obj);
                _Db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


    }
}
