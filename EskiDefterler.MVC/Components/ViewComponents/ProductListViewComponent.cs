using EskiDefterler.BusinessLogic.Abstract;
using EskiDefterler.Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EskiDefterler.MVC.Components.ViewComponents
{
    public class ProductListViewComponent : ViewComponent
    {
        private readonly IManager<Product> productManager;

        public ProductListViewComponent(IManager<Product> productManager)
        {
            this.productManager = productManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var product = productManager.GetAll();
            return View(product);
        }
    }
}
