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
    public class AddressSeed : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(

                new Address { 
                    Id = 1,
                    UserId = 1,
                    AddressName = "Home",
                    AddressDescription = "Sevgi Caddesi,Susam Sokağı, Minik Kuş Apartmanı No:13 / Daire:2",
                    District = "Kadıköy",
                    Province = "İstanbul"
                },
                new Address
                {
                    Id = 2,
                    UserId = 2,
                    AddressName = "Office",
                    AddressDescription = "Gökçe Mahallesi, Yıldız Apartmanı No:21 Daire:7",
                    District = "Mustafakemalpaşa",
                    Province = "Bursa"
                },
                new Address
                {
                    Id = 3,
                    UserId = 3,
                    AddressName = "Evim",
                    AddressDescription = "Kutlu Sokak, Doğan Apt. No:12 Daire:1",
                    District = "Karşıyaka",
                    Province = "İzmir"
                },
                new Address
                {
                    Id = 4,
                    UserId = 4,
                    AddressName = "Annemler",
                    AddressDescription = "Perihan Mahallesi, Savaş Sokak, Çiçek Apt. No:12 Daire:9",
                    District = "Maltepe",
                    Province = "İstanbul"
                },
                new Address
                {
                    Id = 5,
                    UserId = 5,
                    AddressName = "MyHome",
                    AddressDescription = "Balıkesir Mh. , Perdane Sokak, Özdemir Sitesi B Blok Daire:13",
                    District = "Çankaya",
                    Province = "Ankara"
                }
            );
        }
    }
}
