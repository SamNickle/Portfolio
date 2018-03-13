using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Portfolio.ViewModels;
using Portfolio.Models;

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
            var VM = new AboutWorkVM();
            VM.WorkExp = new List<WorkExperience>()
            {
                new WorkExperience { Id = 1, CompanyName = "Exbos", Location = "Bradford", Position = "Junior Web Developer", StartDate = DateTime.Parse("14/09/2015"), EndDate = DateTime.Parse("17/03/2017"), WorkDescription = "I started working for Exbos Ltd in September 2015. My role there for the first year was an Apprentice Web Developer. This progressed into becoming a Junior Web Developer. Throughout my time at Exbos I created and maintained websites for companies such as B&Q, Mondelēz (Cadburys), Primark and Costa. Each project offered a variety of work to progress my skills, from back end developing, such as database maintenance or code changes using C#, .NET and Web Forms. To front end design such as CSS, JavaScript, and email templates. As my employment was an apprenticeship I did have to go to college. During my time at college, I learnt about Object Oriented Programming, SQL, ASP.NET, and Windows Forms over the course of a year." },
                new WorkExperience { Id = 1, CompanyName = "Meritec", Location = "Skipton", Position = "Junior Web Developer", StartDate = DateTime.Parse("20/03/2017"), EndDate = DateTime.Parse("16/02/2018"), WorkDescription = "During my time at Meritec, I further progressed my current skills, such as C#, SQL and jQuery. I also got exposure to new technologies such as API’s, Umbraco, and Angular. The given work offered a variety of different tasks, from front to back end. Using both Web Forms and MVC to create and maintain websites gave me a wider understanding of web development using the Microsoft technology stack. <br />At Meritec I gained experience in technologies that I have used little of before. Such as Bootstrap, Umbraco and API's. Practising these made me more efficient at completing a multitude of tasks. This paired with my knowledge of other languages, like C#, javascript, and CSS allowed me to perform the majority of tasks with ease and more efficiently." },
                new WorkExperience { Id = 1, CompanyName = "enquiryMAX", Location = "Leeds", Position = ".Net Developer", StartDate = DateTime.Parse("19/02/2018"), EndDate = null, WorkDescription = "Worked here enquiryMAX" }
            }.OrderBy(x => x.StartDate).Reverse().ToList();
            VM.Technologies = new List<Technology>()
            {
                new Technology { Id = 1, OrderId = 6, Name = "Angular", ImageUrl = "/Images/Technologies/angular.svg" },
                new Technology { Id = 2, OrderId = 3, Name = "Bootstrap", ImageUrl = "/Images/Technologies/bootstrap.svg" },
                new Technology { Id = 3, OrderId = 10, Name = "C#", ImageUrl = "/Images/Technologies/CSharp.svg" },
                new Technology { Id = 4, OrderId = 2, Name = "CSS3", ImageUrl = "/Images/Technologies/css3.svg" },
                new Technology { Id = 5, OrderId = 12, Name = ".Net Core", ImageUrl = "/Images/Technologies/DotNetCore.svg" },
                new Technology { Id = 6, OrderId = 11, Name = ".Net Framework", ImageUrl = "/Images/Technologies/DotNetFramework.svg" },
                new Technology { Id = 7, OrderId = 7, Name = "Gulp", ImageUrl = "/Images/Technologies/gulp.svg" },
                new Technology { Id = 8, OrderId = 1, Name = "HTML5", ImageUrl = "/Images/Technologies/html5.svg" },
                new Technology { Id = 9, OrderId = 5, Name = "Javascript", ImageUrl = "/Images/Technologies/javascript.svg" },
                new Technology { Id = 10, OrderId = 8, Name = "jQuery", ImageUrl = "/Images/Technologies/jquery.svg" },
                new Technology { Id = 11, OrderId = 13, Name = "JSON", ImageUrl = "/Images/Technologies/json.svg" },
                new Technology { Id = 12, OrderId = 9, Name = "MySQL", ImageUrl = "/Images/Technologies/mysql.svg" },
                new Technology { Id = 13, OrderId = 14, Name = "Redis", ImageUrl = "/Images/Technologies/redis.svg" },
                new Technology { Id = 14, OrderId = 4, Name = "SASS", ImageUrl = "/Images/Technologies/sass.svg" },
                new Technology { Id = 15, OrderId = 8, Name = "SQL Server", ImageUrl = "/Images/Technologies/SQLServer.svg" },
                new Technology { Id = 16, OrderId = 15, Name = "Visual Studio", ImageUrl = "/Images/Technologies/visualstudio.svg" },
            }.OrderBy(x => x.OrderId).ToList();

            return View(VM);
        }
    }
}
