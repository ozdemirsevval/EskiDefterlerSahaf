using EskiDefterler.Core.Entities.Abstract;
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
    public class OrderConfig:BaseConfig<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.OrderDate).IsRequired();
            builder.Property(x => x.OrderDate).ValueGeneratedOnAdd()
                                              .HasDefaultValueSql("GETDATE()"); //varsayılan değer
                

            builder.HasOne(o => o.Shipper)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.ShipperId);

            builder.HasOne(o=>o.User)
                .WithMany(u=>u.Orders)
                .HasForeignKey(o => o.UserId);

            builder.HasOne(o=>o.Addresses) //order sınıfındaki adres navigation propertysi
                .WithMany(a=>a.Orders) //adres sınıfınfaki order navigation propertysi
                .HasForeignKey(o=>o.AddressId); // order sınıfındaki foreign key AdressId
        }
    }
}
