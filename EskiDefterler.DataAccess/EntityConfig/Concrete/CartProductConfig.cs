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
    public class CartProductConfig : BaseConfig<CartProduct>
    {
        public override void Configure(EntityTypeBuilder<CartProduct> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.Quantity).HasMaxLength(100);

            builder.HasOne(cp => cp.Cart)
                .WithMany(c => c.CartProducts)
                .HasForeignKey(cp => cp.ProductId);

            builder.HasOne(cp=>cp.Product)
                .WithMany(p=>p.CartProducts)
                .HasForeignKey(cp => cp.ProductId);
        }
    }
}
