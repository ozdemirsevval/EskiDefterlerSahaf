using AspNetCoreHero.ToastNotification.Abstractions;
using EskiDefterler.BusinessLogic.Abstract;
using EskiDefterler.Core.Entities.Concrete;
using EskiDefterler.MVC.Models.ViewModels.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Security.Claims;

namespace EskiDefterler.MVC.Controllers
{
    public class AccountController(IManager<User> userManager, 
                                   IManager<User> adminManager, 
                                   INotyfService notyfService): Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            LoginVM loginVM = new LoginVM();
            return View(loginVM);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult>Login(LoginVM loginVM)
        {
           var user = userManager.GetAllInclude(p=>p.Email == loginVM.Email && p.Password == loginVM.Password).FirstOrDefault();
           var admin = adminManager.GetAllInclude(p => p.Email == loginVM.Email && p.Password == loginVM.Password).FirstOrDefault();

            if (user == null)
            {
                if (admin == null)
                {
                    notyfService.Error("Mail ya da Şifre Hatalı");
                    return View(loginVM);
                }
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,loginVM.Email)
            };

            if (user != null) 
            { 
            claims.Add(new Claim("userId",user.Id.ToString()));
            }

            var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

            var authenticationProperty = new AuthenticationProperties()
            {
                IsPersistent = loginVM.RememberMe
            };

            var userPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, 
                                            userPrincipal, authenticationProperty);
            return RedirectToAction("Index", "Home");

            
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        #region Yeni Kullanıcı Kayıt İşlemleri

        [HttpGet]
        [AllowAnonymous]
        public IActionResult UserInsert()
        {
            UserInsertVM userInsertVM = new UserInsertVM();
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult UserInsert(UserInsertVM userInsertVM)
        {
            if (!ModelState.IsValid)
            {
                notyfService.Error("You need to check your informations");
                return View(userInsertVM);
            }
            User user = new User();
            user.FirstName = userInsertVM.FirstName;
            user.LastName = userInsertVM.LastName;
            user.BirthDate = userInsertVM.BirthDate;
            user.Email = userInsertVM.Email;
            user.Phone = userInsertVM.Phone;
            user.Password = userInsertVM.Password;

            userManager.Create(user);

            notyfService.Success("mission is possible");

            return RedirectToAction("Login", "Account");
        } 
        #endregion

    }
}
