using EskiDefterler.Core.Entities.Abstract;
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
    public class OrderConfig:BaseConfig<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.OrderDate).IsRequired();
            builder.Property(x => x.OrderDate).ValueGeneratedOnAdd()
                                              .HasDefaultValueSql("GETDATE()"); //varsayılan değer
                
            builder.Property(X=>X.RequiredDate).IsRequired();
            
            builder.Property(x=>x.ShippedDate).IsRequired();

            builder.Property(x => x.ShipAdress).HasMaxLength(200);
            builder.Property(x=>x.ShipAdress).IsRequired();

            builder.Property(x=>x.ShipCity).IsRequired();
            builder.Property(x=>x.ShipCity).HasMaxLength(50);

            builder.Property(x => x.ShipPostalCode).HasMaxLength(10);

            builder.HasOne(p => p.Shipper)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.ShipperId);
        }
    }
}
