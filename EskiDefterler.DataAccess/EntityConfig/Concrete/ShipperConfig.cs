using EskiDefterler.Core.Entities.Concrete;
using EskiDefterler.DataAccess.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.DataAccess.EntityConfig.Concrete
{
    public class ShipperConfig : BaseConfig<Shipper>
    {
        public override void Configure(EntityTypeBuilder<Shipper> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.CompanyName).IsRequired();
            builder.Property(p => p.CompanyName).HasMaxLength(100);


            builder.Property(p => p.Phone).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(20);
            builder.HasIndex(p => p.Phone).IsUnique();

        }
    }
}
