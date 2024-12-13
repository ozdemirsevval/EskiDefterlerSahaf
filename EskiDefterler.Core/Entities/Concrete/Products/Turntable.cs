using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete.Products
{
    public class Turntable : BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string RPM { get; set; }
    }
}
