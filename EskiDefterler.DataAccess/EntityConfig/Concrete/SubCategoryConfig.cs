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
    public class SubCategoryConfig : BaseConfig<SubCategory>
    {
        public override void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);//PrimaryKey
            builder.Property(x => x.Name).HasMaxLength(150).IsRequired();

            builder.HasOne(p => p.Category)
                .WithMany(p => p.SubCategories)
                .HasForeignKey(p => p.CategoryId);

        }
    }
}
