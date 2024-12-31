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
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            
                new Product { 
                    Id = 1, 
                    Title= "1999 Bülent Ortaçgil - Eski Defterler Kaseti",
                    Condition = "Yeni Gibi", 
                    Description="Ada Müzk Yapım şirketi imzalı 99 çıkışlı albümü",
                    Price=200,
                    PhotoUrl = "https://ideacdn.net/idea/ce/36/myassets/products/164/img-e5560.JPG?revision=1720098706",
                    StockQuantity =1, 
                    SubCategoryId=36,
                },
                new Product
                {
                    Id = 2,
                    Title = "İnce Memed II",
                    Condition="İkinci el",
                    Description = "Cem Yayınları, 1971. Karton Kapak",
                    Price=100,
                    PhotoUrl= "https://s3.cloud.ngn.com.tr/kitantik/images/2024-06-12/1br9qfwlxbwuygk13hk.jpg",
                    StockQuantity =2,
                    SubCategoryId = 14
                },
                new Product
                {
                    Id = 3,
                    Title = "Cesaretin var mı aşka?",
                    Condition = "İkinci El",
                    Description = "Yönetmen: Yann Samuell Oyuncular: Guillaume Canet, Marion Cotillard, Thibault Verhaeghe",
                    Price = 25,
                    PhotoUrl= "https://www.plakperest.com/img/products/16742102032787432570614927694837_20.01.2023_a1433d3.jpg",
                    StockQuantity = 1,
                    SubCategoryId = 1 // Değiştirilecek
                }
            
            );
        }
    }
}
