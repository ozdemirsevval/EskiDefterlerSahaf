using EskiDefterler.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace EskiDefterler.MVC.Controllers
{
    public class Pages : Controller
    {
        private readonly AppDbContext _dbContext;

        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            return View();

        }

        public IActionResult About()
        {
            return View();
        }

        //public IActionResult Categories()
        //{
        //    return View(categories);
        //}
    }
}
