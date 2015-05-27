using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Abhi1.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Abhi1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db) {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = 15;
            var employees = _db.Employees.ToList();
            return View(employees);
        }
        public IActionResult Details(int id)
        {
            var employee = _db.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            return View(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            var employees = _db.Employees.ToList();
            return employees;
        }

        public IActionResult ExceptionAction() {
            throw new Exception();
        }
    }
}
