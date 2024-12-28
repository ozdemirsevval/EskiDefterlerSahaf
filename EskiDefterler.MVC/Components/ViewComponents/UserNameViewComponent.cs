using EskiDefterler.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EskiDefterler.MVC.Components.ViewComponents
{
    public class UserNameViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public UserNameViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync( string userName)
        {
            userName = "";
            if (User.Identity.IsAuthenticated)
            {
                string userId = (User as ClaimsPrincipal)?.FindFirstValue(ClaimTypes.NameIdentifier);
                
                if (int.TryParse(userId, out int parsedUserId))
                {
                    var user = await _context.Users.FindAsync(parsedUserId);
                    userName = user.FirstName+" "+user.LastName;
                    return View("Default", userName);
                }
            }
            else
            {
                Console.WriteLine("Hoşgeldiniz,Ziyaretçi");
            }

            return View("Default",userName);
        }
    }
}
