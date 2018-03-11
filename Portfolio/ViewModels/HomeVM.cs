using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class HomeVM
    {
        public List<Skill> Skills { get; set; }
        public List<Work> WorkExamples { get; set; }
        public List<Client> Clients { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
