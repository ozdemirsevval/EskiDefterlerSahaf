using EskiDefterler.Core.Entities.Concrete;
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
    public class SaleConfig : BaseConfig<Sale>
    {
        public override void Configure(EntityTypeBuilder<Sale> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.Quantity).HasMaxLength(100);

            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Price).HasMaxLength(100);

            //builder.Property(x=>x.Image).IsRequired();
            builder.Property(x => x.Image).HasMaxLength(100);

            builder.Property(x => x.Date).ValueGeneratedOnAdd()
                                              .HasDefaultValueSql("GETDATE()"); ;
            builder.Property(x => x.Date).HasMaxLength(20);


        }
    }
}
