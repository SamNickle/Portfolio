using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.ViewModels
{
    public class AboutWorkVM
    {
        public List<WorkExperience> WorkExp { get; set; }
        public List<Technology> Technologies { get; set; }
    }
}
