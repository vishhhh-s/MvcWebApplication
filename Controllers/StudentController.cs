using Microsoft.AspNetCore.Mvc;
using MvcWebApplication.Models;
using MvcWebApplication.Repository;

namespace MvcWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = StudentRepository.GetAll();

            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            StudentRepository.Add(student);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string name)
        {
            StudentRepository.Delete(name);
            return RedirectToAction("Index");

        }
        public IActionResult Details(string name)
        {
            var students = StudentRepository.GetAll();
            var student = students.FirstOrDefault(student=>student.Name==name);
            if (student == null)
                return NotFound();

            return View(student);
        }
    }
}
