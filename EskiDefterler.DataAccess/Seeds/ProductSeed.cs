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
                    StockQuantity=1, 
                    SubCategoryId=36,
                },
                new Product
                {
                    Id = 2,
                    Title = "İnce Memed II",
                    Condition="İkinci el",
                    Description = "Cem Yayınları, 1971. Karton Kapak",
                    Price=100,
                    StockQuantity=2,
                    SubCategoryId = 14
                },
                new Product
                {
                    Id = 3,
                    Title = "Cesaretin var mı aşka?",
                    Condition = "İkinci El",
                    Description = "Yönetmen: Yann Samuell Oyuncular: Guillaume Canet, Marion Cotillard, Thibault Verhaeghe",
                    Price = 25,
                    StockQuantity = 1,
                    SubCategoryId = 1 // Değiştirilecek
                }
            
            );
        }
    }
}
