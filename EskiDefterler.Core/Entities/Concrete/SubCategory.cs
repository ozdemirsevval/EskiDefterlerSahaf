using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class SubCategory : BaseEntity
    {
        public string Name { get; set; } // Örneğin: "Yayınevi", "Tür", "Yazar"
        public int CategoryId { get; set; } // Hangi ürün türüne ait olduğu
        
        //NavigationProperty
        public Category Category { get; set; } 
        public ICollection<Product> Products { get; set; } 
    }
}
