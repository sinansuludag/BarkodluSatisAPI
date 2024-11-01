using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Configurations
{
    public class KullaniciConfiguration : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(x => x.AdSoyad).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Telefon).IsRequired();
            builder.Property(x=>x.Eposta).IsRequired();
            builder.Property(x=>x.KullaniciAd).IsRequired();
            builder.Property(x => x.Sifre).IsRequired();
        }
    }
}
