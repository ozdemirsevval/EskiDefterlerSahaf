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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(

                new Category
                {
                    Id = 1,
                    CategoryName = "Kitap",
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Walkmen"
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Pikap"
                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Kaset"
                },
                new Category
                {
                    Id = 5,
                    CategoryName = "Plak"
                },
                new Category
                {
                    Id = 6,
                    CategoryName = "DVD"
                },
                new Category
                {
                    Id = 7,
                    CategoryName = "CD"
                },
                new Category
                {
                    Id = 8,
                    CategoryName = "İmzalı Ürünler"
                },
                new Category
                {
                    Id = 9,
                    CategoryName = "Diğerleri"
                }

            );
        }
    }
}
