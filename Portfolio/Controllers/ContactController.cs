namespace Portfolio.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;

    using Portfolio.Models;

    using System.Net.Mail;

    public class ContactController : Controller
    {
        private readonly SmtpConfig _myConfiguration;
        public ContactController(IOptions<SmtpConfig> myConfiguration)
        {
            _myConfiguration = myConfiguration.Value;
        }

        [HttpPost]
        public IActionResult SendEmail(Contact contact)
        {
            if (contact != null)
            {
                var mail = new MailMessage(_myConfiguration.User, contact.Email, $"Portfolio enquiry from {contact.Name}", contact.Message);
                var client = new SmtpClient(_myConfiguration.Server, _myConfiguration.Port);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                contact.IsSuccess = true;
            }

            return RedirectToAction("FormSuccess", "Contact", contact);
        }

        public IActionResult FormSuccess(Contact contact)
        {
            return View(contact);
        }
    }
}