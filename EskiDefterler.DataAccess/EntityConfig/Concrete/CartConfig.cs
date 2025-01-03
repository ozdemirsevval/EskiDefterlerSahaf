﻿using EskiDefterler.Core.Entities.Concrete;
using EskiDefterler.DataAccess.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.DataAccess.EntityConfig.Concrete
{
    public class CartConfig : BaseConfig<Cart>
    {
        public override void Configure(EntityTypeBuilder<Cart> builder)
        {
            base.Configure(builder);
        }
    }
}
