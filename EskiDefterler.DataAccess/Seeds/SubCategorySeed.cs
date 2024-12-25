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
    public class SubCategorySeed : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasData(

                new SubCategory
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Aşk ve Romantik"
                },
                new SubCategory
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Bilim Kurgu"
                },
                new SubCategory
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Biyogrofi ve Otobiyografi"
                },
                new SubCategory
                {
                    Id = 4,
                    CategoryId = 1,
                    Name = "Bilim ve Araştırma"
                },
                new SubCategory
                {
                    Id = 5,
                    CategoryId = 1,
                    Name = "Deneme ve Makale"
                },
                new SubCategory
                {
                    Id = 6,
                    CategoryId = 1,
                    Name = "Ders Kitapları"
                },
                new SubCategory
                {
                    Id = 7,
                    CategoryId = 1,
                    Name = "Fantastik ve Mitoloji"
                },
                new SubCategory
                {
                    Id = 8,
                    CategoryId = 1,
                    Name = "Gerilim"
                },
                new SubCategory
                {
                    Id = 9,
                    CategoryId = 1,
                    Name = "Hobi ve İlgi Alanları"
                },
                new SubCategory
                {
                    Id = 10,
                    CategoryId = 1,
                    Name = "Kişisel Gelişim"
                },
                new SubCategory
                {
                    Id = 11,
                    CategoryId = 1,
                    Name = "Macera"
                },
                new SubCategory
                {
                    Id = 12,
                    CategoryId = 1,
                    Name = "Öykü"
                },
                new SubCategory
                {
                    Id = 13,
                    CategoryId = 1,
                    Name = "Polisiye"
                },
                new SubCategory
                {
                    Id = 14,
                    CategoryId = 1,
                    Name = "Roman"
                },
                new SubCategory
                {
                    Id = 15,
                    CategoryId = 1,
                    Name = "Şiir"
                },
                new SubCategory
                {
                    Id = 16,
                    CategoryId = 1,
                    Name = "Sözlük ve Ansiklopediler"
                },
                new SubCategory
                {
                    Id = 17,
                    CategoryId = 1,
                    Name = "Tarih"
                },
                new SubCategory
                {
                    Id = 18,
                    CategoryId = 1,
                    Name = "Tiyatro"
                },
                new SubCategory
                {
                    Id = 19,
                    CategoryId = 3,
                    Name = "Alternatif Rock"
                },
                new SubCategory
                {
                    Id = 20,
                   CategoryId = 3,
                    Name = "Blues"
                },
                new SubCategory
                {
                    Id = 21,
                   CategoryId = 3,
                    Name = "Caz(Jazz)"
                },
                new SubCategory
                {
                    Id = 22,
                   CategoryId = 3,
                    Name = "Country"
                },
                new SubCategory
                {
                    Id = 23,
                   CategoryId = 3,
                    Name = "Dans"
                },
                new SubCategory
                {
                Id = 24,
               CategoryId = 3,
                Name = "Elektronik"
                },
                new SubCategory
                {
                    Id = 25,
                   CategoryId = 3,
                    Name = "Folk"
                },
                new SubCategory
                {
                    Id = 26,
                   CategoryId = 3,
                    Name = "Funk"
                },
                new SubCategory
                {
                    Id = 27,
                   CategoryId = 3,
                    Name = "Gospel"
                },
                new SubCategory
                {
                    Id = 28,
                   CategoryId = 3,
                    Name = "Hard Rock"
                },
                new SubCategory
                {
                    Id = 29,
                   CategoryId = 3,
                    Name = "Heavy Metal"
                },
                new SubCategory
                {
                    Id = 30,
                   CategoryId = 3,
                    Name = "Hip-Hop"
                },
                new SubCategory
                {
                    Id = 31,
                   CategoryId = 3,
                    Name = "Indie"
                },
                new SubCategory
                {
                    Id = 32,
                   CategoryId = 3,
                    Name = "Klasik"
                },
                new SubCategory
                {
                    Id = 33,
                   CategoryId = 3,
                    Name = "Latin"
                },
                new SubCategory
                {
                    Id = 34,
                   CategoryId = 3,
                    Name = "New Age"
                },
                new SubCategory
                {
                    Id = 35,
                   CategoryId = 3,
                    Name = "Opera"
                },
                new SubCategory
                {
                    Id = 36,
                   CategoryId = 3,
                    Name = "Pop"
                },
                new SubCategory
                {
                    Id = 37,
                   CategoryId = 3,
                    Name = "Punk"
                },
                new SubCategory
                {
                    Id = 38,
                   CategoryId = 3,
                    Name = "R&B"
                },
                new SubCategory
                {
                    Id = 39,
                   CategoryId = 3,
                    Name = "Rap"
                },
                new SubCategory
                {
                    Id = 40,
                   CategoryId = 3,
                    Name = "Reggae"
                },
                new SubCategory
                {
                    Id = 41,
                   CategoryId = 3,
                    Name = "Rock"
                },
                new SubCategory
                {
                    Id = 42,
                   CategoryId = 3,
                    Name = "Soul"
                },
                new SubCategory
                {
                    Id = 43,
                   CategoryId = 3,
                    Name = "Tekno"
                },
                new SubCategory
                {
                    Id = 44,
                   CategoryId = 3,
                    Name = "Trap"
                },
                new SubCategory
                {
                    Id = 45,
                   CategoryId = 3,
                    Name = "Türk Halk Müziği"
                },
                new SubCategory
                {
                    Id = 46,
                   CategoryId = 3,
                    Name = "Türk Sanat Müziği"
                },
                new SubCategory
                {
                    Id = 47,
                   CategoryId = 3,
                    Name = "World Music"
                }

            );
        }
    }
}
