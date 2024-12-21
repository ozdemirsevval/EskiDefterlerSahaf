using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class Category:BaseEntity
    {
        public string Name { get; set; } // Örneğin: "Kitap", "Müzik", "Dergi"

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
