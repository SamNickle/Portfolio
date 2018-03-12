using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Contact
    {
        [DisplayName("Your name")]
        public string Name { get; set; }
        [DisplayName("Your email")]
        public string Email { get; set; }
        [DisplayName("Tell me about your project ")]
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
