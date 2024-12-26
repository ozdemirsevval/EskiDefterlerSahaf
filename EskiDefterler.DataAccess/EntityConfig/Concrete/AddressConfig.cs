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
    public class AddressConfig :BaseConfig<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.AddressName).IsRequired().HasMaxLength(80);
            builder.Property(p => p.AddressDescription).IsRequired().HasMaxLength(300);
            builder.Property(p => p.District).IsRequired().HasMaxLength(20); //Türkiye'de en uzun ilçe ismi 16 karakter
            builder.Property(p => p.Province).IsRequired().HasMaxLength(15); //Türkiyede en uzun il ismi 9 karakter

            builder.HasOne(a => a.User)
                .WithMany(u => u.Addresses)
                .HasForeignKey(a => a.UserId);

        }
    }
}
