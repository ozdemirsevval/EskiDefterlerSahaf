using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete.Products
{
    public class Book : BaseEntity
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string PublishYear { get; set; }
        public string Genre { get; set; }
        public bool IsSigned { get; set; } = false; //İmzalı mı Koleksiyonluk mu?
    }
}
