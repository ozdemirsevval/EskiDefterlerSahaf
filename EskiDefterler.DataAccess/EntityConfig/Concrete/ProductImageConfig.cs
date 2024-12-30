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
    public class ProductImageConfig : BaseConfig<ProductImage>
    {
        public override void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            base.Configure(builder);
            builder.Property(pi=>pi.ProductId).IsRequired();
            builder.Property(pi=>pi.PhotoPath).IsRequired();
            
        }
    }
}
