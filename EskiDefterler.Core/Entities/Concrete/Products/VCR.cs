using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete.Products
{
    public class VCR : BaseEntity
    {
        public DateTime ReleaseYear { get; set; } //Yayınlanma Tarihi
        public string Director {  get; set; }
        public string Producer { get; set; }
    }
}
