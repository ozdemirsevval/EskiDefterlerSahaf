using EskiDefterler.Core.Entities.Concrete;
using EskiDefterler.DataAccess.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.DataAccess.EntityConfig.Concrete
{
    public class UserConfig : BaseConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id); //PrimaryKey

            builder.Property(p => p.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(30).IsRequired();
            //builder.Property(p => p.Adress).HasMaxLength(500).IsRequired();

            //Genel Kısıt İsimlendirme: CK_[TabloAdı]_[AlanAdı]_[Koşul]
            //Örneğin: CK_User_AdressId_NotNull.
            //Bu ne demek oluyor benim iki farlı user rolüm var Admin ve customer.
            //Ben adres bilgisi customer için zorunlu iken admin için zorunlu olmasın istiyorum.

            //builder.ToTable(t =>
            //    t.HasCheckConstraint("CK_User_AdressId_ForCustomers", "RoleId = 1 AND AdressId IS NOT NULL OR RoleId = 2"));


            builder.HasOne(p => p.Role)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.RoleId);

        }
    }
}
