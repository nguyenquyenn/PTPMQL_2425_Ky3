using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee ep)
        {
            string strOutput = "Xin chao" + ep.EmployeeId + "-" + ep.Age;
            ViewBag.InfoPerson = strOutput;
            return View();
        }
    }
}
