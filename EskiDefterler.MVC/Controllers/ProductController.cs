using EskiDefterler.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EskiDefterler.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;

        // Constructor Injection
        public ProductController(AppDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product_List()
        {
            return View();
        }
    }
}
