using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class CartProduct :BaseEntity
    {
        public int Quantity { get; set; }

        //ForeignKey
        public int ProductId { get; set; }
        public int UserId { get; set; }

        //NavigationProp

        public Cart Cart { get; set; }
        public Product Product { get; set; }

    }
}
