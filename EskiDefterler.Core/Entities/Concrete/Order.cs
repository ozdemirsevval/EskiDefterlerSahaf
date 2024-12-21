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
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipVia { get; set; } //KargoFirmasi
        public decimal Freight { get; set; } //GönderimÜcreti
        public string ShipAdress { get; set; } //Gönderim Adresi
        public string ShipCity { get; set; } //Gönderimİli
        public int? ShipPostalCode { get; set; } //PostaKodu


        public int ShipperId { get; set; } //foreign key
        
        public Shipper Shipper { get; set; } //NavigationProperty

        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
