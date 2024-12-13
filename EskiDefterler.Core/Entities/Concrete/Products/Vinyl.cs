﻿using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete.Products
{
    public class Vinyl : BaseEntity
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public string Producer { get; set; }//Yayımlayan şirket kim? Kekova mı Esen mi?
        public string Format { get; set; } //
        public string RPM { get; set; } //33,45 
        public bool IsSigned { get; set; } = false; //İmzalı mı Koleksiyonluk mu?
    }
}
