using EskiDefterler.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.DataAccess.Seeds
{
    public class ProductImageSeed : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasData(
                new ProductImage
                {
                    Id = 1,
                    ProductId = 1,
                    PhotoTitle = "Ortaçgil",
                    PhotoPath = "https://ideacdn.net/idea/ce/36/myassets/products/164/img-e5560.JPG?revision=1720098706"
                },
                new ProductImage
                {
                    Id = 2,
                    ProductId = 2,
                    PhotoTitle = "İnceMemed",
                    PhotoPath = "https://s3.cloud.ngn.com.tr/kitantik/images/2024-06-12/1br9qfwlxbwuygk13hk.jpg"
                },
                new ProductImage
                {
                    Id = 3,
                    ProductId = 3,
                    PhotoPath = "https://www.plakperest.com/img/products/16742102032787432570614927694837_20.01.2023_a1433d3.jpg"
                }
            );
        }
    }
}
