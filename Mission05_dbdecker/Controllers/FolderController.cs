using Microsoft.AspNetCore.Mvc;
using Mission05_dbdecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission05_dbdecker.Controllers
{
    public class FolderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Grades()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Grades (GradesModel model)
        {
            return View();
        }
    }
}
