using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class ProductImage : BaseEntity
    {
        public string? PhotoTitle { get; set; }
        public string PhotoPath { get; set; }

        public int ProductId { get; set; } // Foreign Key
        public Product Product { get; set; } //navigtaion property
    }
}
