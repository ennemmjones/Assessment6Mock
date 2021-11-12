using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment6Mock.Data;
using Assessment6Mock.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Assessment6Mock.Controllers
{
    public class HomeController : Controller
    {
        private readonly Assessment6MockContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Assessment6MockContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Employees()
        {

            var listOfEmployees = _context.Employee.ToList();
            return View(listOfEmployees);
        }

        [HttpPost]
        public IActionResult RetirementInfo(int id)
        {
            var employee = _context.Employee.FirstOrDefault(e => e.Id == id);
           
            if (employee.Age > 60)
            {
                ViewBag.CanRetire = true;
            }
            else
            {
                ViewBag.CanRetire = false;
            }

            ViewBag.Benefits = employee.Salary * .6M;


            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
