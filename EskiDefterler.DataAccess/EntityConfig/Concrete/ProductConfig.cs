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
    public class ProductConfig : BaseConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Title).HasMaxLength(100);

            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(100);

            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Price).HasMaxLength(100);

            builder.Property(p => p.StockQuantity).IsRequired();
            builder.Property(p => p.StockQuantity).HasMaxLength(100);

            builder.HasOne(p => p.SubCategories)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.SubCategoryId);

        }
    }
}
