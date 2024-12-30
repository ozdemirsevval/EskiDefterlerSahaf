using EskiDefterler.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace EskiDefterler.MVC.Controllers
{
    public class Pages : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
