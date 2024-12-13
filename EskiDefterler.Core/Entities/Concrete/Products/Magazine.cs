using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete.Products
{
    public class Magazine : BaseEntity
    {
        public DateTime PublishDate { get; set; }
        public string Publisher { get; set; }
    }
}
