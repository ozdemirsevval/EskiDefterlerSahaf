﻿using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class Cart : BaseEntity
    {
        public int ProductId { get; set; }


        public int Quantity { get; set; }


        public decimal Price { get; set; }


        public DateTime Date { get; set; }


        public string? Image { get; set; }


        public int UserId { get; set; }
    }
}
