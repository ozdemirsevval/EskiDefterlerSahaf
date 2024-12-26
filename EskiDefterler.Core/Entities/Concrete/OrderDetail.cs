using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class OrderDetail : BaseEntity
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
       
        public int OrderId { get; set; } //Foreign Key
        public Order Orders { get; set; } //Navigation Property

        public int ProductId { get; set; } //Foreign Key
        public Product Products { get; set; } //Navigation Property

    }
}
