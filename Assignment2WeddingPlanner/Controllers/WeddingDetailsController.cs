using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WeddingPlanner.Controllers
{
    public class WeddingDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
