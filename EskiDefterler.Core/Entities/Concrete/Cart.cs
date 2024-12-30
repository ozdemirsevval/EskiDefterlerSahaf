using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class Cart : BaseEntity
    {
        public ICollection<CartProduct> CartProducts { get; set; }
    }
}
