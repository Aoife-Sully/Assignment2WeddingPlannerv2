using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WeddingPlanner.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Http(int statusCode)
        {
           if (statusCode == 404)
            {
                return View("Error404");
            }

            return View("Error404");
        }
    }
}
