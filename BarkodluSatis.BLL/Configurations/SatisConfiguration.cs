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
    public class SatisConfiguration : IEntityTypeConfiguration<Satis>
    {
        public void Configure(EntityTypeBuilder<Satis> builder)
        {
            builder.HasKey(x=>x.SatisId);
            builder.Property(x => x.SatisId).UseIdentityColumn();
            builder.Property(x => x.IslemNo).IsRequired();
            builder.Property(x=>x.Barkod).IsRequired().HasMaxLength(50);
            builder.Property(x => x.UrunAd).IsRequired().HasMaxLength(100);
            builder.Property(x => x.UrunGrup).IsRequired();
            builder.Property(x => x.Birim).IsRequired();
            builder.Property(x => x.AlisFiyat).IsRequired();
            builder.Property(x => x.SatisFiyat).IsRequired();
            builder.Property(x => x.Iade).IsRequired();
            builder.Property(x => x.Kullanici).IsRequired().HasMaxLength(100);
            builder.Property(x => x.OdemeSekli).IsRequired();
            builder.Property(x => x.Tarih).IsRequired();


        }
    }
}
