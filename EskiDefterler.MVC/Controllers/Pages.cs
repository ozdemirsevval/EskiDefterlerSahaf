using EskiDefterler.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace EskiDefterler.MVC.Controllers
{
    public class Pages : Controller
    {
        private readonly AppDbContext _dbContext;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Categories()
        {
            var categories = _dbContext.Categories.ToList();
            return View(categories);
        }
    }
}
