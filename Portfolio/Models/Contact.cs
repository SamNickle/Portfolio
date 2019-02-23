namespace Portfolio.Models
{
    using System.ComponentModel;

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
