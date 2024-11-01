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
    public class UrunConfiguration : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.HasKey(x=>x.UrunId);
            builder.Property(x=>x.UrunId).UseIdentityColumn();
            builder.Property(x => x.UrunAd).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Kullanici).IsRequired().HasMaxLength(75);
            builder.Property(x => x.Barkod).IsRequired();
            builder.Property(x => x.UrunGrup).IsRequired(); 
            builder.Property(x => x.AlisFiyati).IsRequired();
            builder.Property(x => x.SatisFiyati).IsRequired();
            builder.Property(x => x.KdvTutari).IsRequired();
            builder.Property(x => x.Birim).IsRequired();
            builder.Property(x => x.Miktar).IsRequired();
            builder.Property(x => x.Tarih).IsRequired();
    }
    }
}
