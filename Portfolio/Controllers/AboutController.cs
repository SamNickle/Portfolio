using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.Controllers
{
    public class AboutController : Controller
    {
        // GET: /<controller>/
        public IActionResult Me()
        {
            var foo = Startup.Configuration.GetConnectionString("DefaultConnection");

            return View();
        }

        public IActionResult Work()
        {
            return View();
        }
    }
}
