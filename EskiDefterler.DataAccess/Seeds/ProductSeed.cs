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
                    Description = "Yönetmen: Yann Samuell Oyuncular: Guillaume Canet, Marion Cotillard, Thibault Verhaeghe" +
                                  "Özet: Sophie ve Julien, çocukluklarından bu yana bir “cesaret oyunuyla” birbirlerine bağlanmış iki arkadaştır. " +
                                  "Aradan geçen zaman, ikilinin arasına giren insanlar, kızgınlıklar ve hayal kırıklıkları, hepsi oyunun aşılması gereken " +
                                  "engellerine dönüşür. Kahramanlarımızın arasında hayal gücünün sınırlarını zorlayan bir aşk yaratan bu oyun, maalesef " +
                                  "kavuşmalarını da engeller. Şimdi bu iki genç aşığın önündeki son ve en zorlu görev, aşklarını yaratan bu yıkıcı oyunla " +
                                  "başa çıkarak, bir arada olmayı öğrenmektir.",
                    Price = 25,
                    StockQuantity = 1,
                    SubCategoryId = 1 // Değiştirilecek
                }
            
            );
        }
    }
}
