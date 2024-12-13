using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete.Products
{
    public class Walkmen :BaseEntity
    {
        public string Brand { get; set; }
        public string Modal { get; set; }
    }
}
