using EskiDefterler.BusinessLogic.Abstract;
using EskiDefterler.Core.Entities.Concrete;
using EskiDefterler.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EskiDefterler.MVC.Components.ViewComponents
{
    public class UserNameViewComponent : ViewComponent
    {
        private readonly IManager<User> userManager;

        public UserNameViewComponent(IManager<User> userManager)
        {
            this.userManager = userManager;
        }
        public async Task <IViewComponentResult>InvokeAsync()
        {
            return View();
        }

        //public async Task<IViewComponentResult>InvokeAsync()
        //{
        //    if (!int.TryParse(HttpContext.User?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value, out var userId))
        //    {
        //        return View("Default", "Misafir");
        //    }

        //    var user = await userManager.GetByIdAsync(userId);
        //    var userName = user?.FirstName ?? "Misafir";
        //    return View("Default", userName);



        //}
    }
}
     //private readonly AppDbContext _context;

     //   public UserNameViewComponent(AppDbContext context)
     //   {
     //       _context = context;
     //   }

     //   public async Task<IViewComponentResult> InvokeAsync(string userName)
     //   {
     //       userName = "";
     //       if (User.Identity.IsAuthenticated)
     //       {
     //           string userId = (User as ClaimsPrincipal)?.FindFirstValue(ClaimTypes.NameIdentifier);

     //           if (int.TryParse(userId, out int parsedUserId))
     //           {
     //               var user = await _context.Users.FindAsync(parsedUserId);
     //               if (user != null)
     //               {
     //                   userName = user.FirstName + " " + user.LastName;
     //                   return View("Default", userName);
     //               }
     //           }
     //       }
     //       else
     //       {
     //           Console.WriteLine("Hoşgeldiniz, Ziyaretçi");
     //       }

     //       return View("Default", userName);
     //   }
    
