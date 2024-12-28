using EskiDefterler.BusinessLogic.Abstract;
using EskiDefterler.BusinessLogic.Concrete;

namespace EskiDefterler.MVC.Extensions
{
    public static class AppExtensions
    {
        public static IServiceCollection AddAppService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IManager<>), typeof(Manager<>));
            return services;
        }
    }
}