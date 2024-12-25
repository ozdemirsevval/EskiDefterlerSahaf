using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class Address : BaseEntity
    {
        public string AddressName { get; set; } //Office, Home etc.
        public string AddressDescription { get; set; } //Street,Neigboorhood,Apartment etc.
        public string District {  get; set; } //Kadıköy, Beşiktaş etc.
        public string Province { get; set; } //İstanbul,Balıkesir etc.

        public int UserId { get; set; }
    }
}
