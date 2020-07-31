using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pacifice_Website.Areas.Admin.Controllers
{
    [Area("Admin")] //here i alwas make mistake
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}