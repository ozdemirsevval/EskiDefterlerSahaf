using AspNetCoreHero.ToastNotification;
using EskiDefterler.DataAccess;
using EskiDefterler.MVC.Extensions;
using Microsoft.EntityFrameworkCore;

namespace EskiDefterler.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            #region DbContext DI
            var conn = builder.Configuration.GetConnectionString("EskiDefterlerDb");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conn));
            #endregion

            #region Notify Configuration

            builder.Services.AddNotyf(p =>
            {
                p.Position = NotyfPosition.BottomRight;
                p.DurationInSeconds = 5;
                p.IsDismissable = true;
            });

            #endregion

            builder.Services.AddAppService(); //DI baðýmlýlýklarýný Exceptions/AppExtentions sýnýfýnda tanýmladýk.

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
