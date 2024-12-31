using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Condition { get; set; }
        public string PhotoUrl { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; } //NavigationProperty
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<CartProduct> CartProducts { get; set; }

        public int SubCategoryId { get; set; }
        public SubCategory SubCategories { get; set; }
    }
}
