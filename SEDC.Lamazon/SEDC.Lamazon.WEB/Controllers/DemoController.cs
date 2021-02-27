using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Lamazon.WEB.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Test(int id, string fName, string lName, int age, string message)
        {
            ViewBag.Id = id;
            ViewBag.FirstName = fName;
            ViewBag.LastName = lName;
            ViewBag.Age = age;
            ViewBag.Message = message;

            return View();
        }
    }
}
