using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Playground.Models;

namespace Playground.Controllers
{
    /// <summary>
    /// A controller intercepts the incoming browser request and returns
    /// an HTML view (.cshtml file) or any other type of data.
    /// </summary>
    public class HomeController : Controller
    {
        [ResponseCache(Duration = 3600)]
        public IActionResult Index()
        {
            //TODO Connect to db to get info
            var vm = new HomeVM();
            vm.Skills = new List<Skill>()
            {
                new Skill{ Name = "Communication", Ranking = 9 },
                new Skill{ Name = "Organisation", Ranking = 9 },
                new Skill{ Name = "Learning", Ranking = 7 },
                new Skill{ Name = "Teaching", Ranking = 6 },
                new Skill{ Name = "Planning", Ranking = 8 },
                new Skill{ Name = "Visual Design", Ranking = 10 },
                new Skill{ Name = "UX Design", Ranking = 8 },
                new Skill{ Name = "Programming", Ranking = 9 }
            };

            vm.WorkExamples = new List<Work>()
            {
                new Work{ Name = "Websites", ImageUrl = "/Images/Work/WorkImg1.jpg" },
                new Work{ Name = "E-Commerce", ImageUrl = "/Images/Work/WorkImg2.jpg" },
                new Work{ Name = "Crisp Icons", ImageUrl = "/Images/Work/WorkImg3.jpg" },
                new Work{ Name = "UI Design", ImageUrl = "/Images/Work/WorkImg4.jpg" },
                new Work{ Name = "Databases", ImageUrl = "/Images/Work/WorkImg5.jpg" },
                new Work{ Name = "Mobile Design", ImageUrl = "/Images/Work/WorkImg6.jpg" },
                new Work{ Name = "UX Design", ImageUrl = "/Images/Work/WorkImg7.jpg" },
                new Work{ Name = "Responsiveness", ImageUrl = "/Images/Work/WorkImg8.jpg" }
            };

            vm.Clients = new List<Client>()
            {
                new Client{ Name = "S'n'T Hair Studio", ClientName = "Toni Atkins", LogoUrl = "", Quote = "We had just started our business and wanted a website that our customers could use to look for prices and contact us. A friend recommended Sam to create the website. He made the website quickly and made it look exactly how we wanted it." },
                new Client{ Name = "House of Sweets", ClientName = "Karen Southall", LogoUrl = "", Quote = "My business started to grow and I needed a website where users could look at products, prices, and other info. Thanks to the website, my customers could look up information instead of messaging or ringing me, which freed up a lot of time." }
            };

            return View(vm);
        }
    }
}
