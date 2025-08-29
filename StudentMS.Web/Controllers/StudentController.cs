using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentMS.Web.Data;
using StudentMS.Web.Models;
using System.Diagnostics;

namespace StudentMS.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbcontext dbContext;

        public StudentController(ApplicationDbcontext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();

        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            dbContext.Students.Add(student);
            dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult List()
        {
            var students = dbContext.Students.ToList();
            return View();
        }
    }

}
