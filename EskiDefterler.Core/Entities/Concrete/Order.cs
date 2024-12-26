using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public DateOnly OrderDate { get; set; }
        public DateOnly? RequiredDate { get; set; }
        public DateOnly? ShippedDate { get; set; }
        public decimal Freight { get; set; } //GönderimÜcreti

        // Foreign Key
        public int AddressId { get; set; } 
        public int UserId { get; set; } 
        public int ShipperId { get; set; }

        //NavigationProperty
        public Address Addresses { get; set; }
        public User User { get; set; } // Her order bir usera aittir
        public Shipper Shipper { get; set; } 
        public ICollection<OrderDetail> OrderDetails { get; set; } 


    }
}
