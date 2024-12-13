using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete.Categories
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } // Örneğin: "Yayınevi", "Tür", "Yazar"
        public int ProductTypeId { get; set; } // Hangi ürün türüne ait olduğu
        public ProductType ProductType { get; set; } // Ürün türüyle ilişki
    }
}
