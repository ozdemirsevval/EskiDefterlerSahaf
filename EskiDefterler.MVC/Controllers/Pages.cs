using EskiDefterler.DataAccess;
using EskiDefterler.MVC.Models.ViewModels.Pages;
using EskiDefterler.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EskiDefterler.MVC.Controllers
{
    public class Pages : Controller
    {
        private readonly EmailService _emailService;

        public Pages(EmailService emailService)
        {
            _emailService = emailService;
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Send(ContactFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                string subject = "Yeni İletişim Formu Mesajı";
                string message = $"{model.Name} ({model.Email}) aşağıdaki mesajı gönderdi: {model.Message}";

                await _emailService.SendEmailAsync("sevvalozdemir.tech@gmail.com", subject, message);
                return RedirectToAction("Index", "Home"); // Başarılı bir şekilde yönlendirme yapılır.
            }
            return View(model);
        }
    }
}
