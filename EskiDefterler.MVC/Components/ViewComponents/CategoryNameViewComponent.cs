using EskiDefterler.BusinessLogic.Abstract;
using EskiDefterler.Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EskiDefterler.MVC.Components.ViewComponents
{
    public class CategoryNameViewComponent : ViewComponent
    {
        private readonly IManager<Category> categoryManager;

        public CategoryNameViewComponent(IManager<Category> categoryManager)
        {
            this.categoryManager = categoryManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var category = categoryManager.GetAll();
            return View(category);
        }
    }
}
