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
    public class OrderDetailConfig : BaseConfig<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.UnitPrice).IsRequired();
            builder.Property(p => p.UnitPrice).HasMaxLength(100);

            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.Quantity).HasMaxLength(100);

            builder.Property(p => p.Discount).IsRequired();
            builder.Property(p => p.Discount).HasMaxLength(100);

            builder.HasOne(p => p.Orders)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.OrderId);

            builder.HasOne(p => p.Products)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.ProductId);
        }
    }
}

