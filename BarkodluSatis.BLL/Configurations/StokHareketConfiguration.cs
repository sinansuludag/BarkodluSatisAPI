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
    public class StokHareketConfiguration : IEntityTypeConfiguration<StokHareket>
    {
        public void Configure(EntityTypeBuilder<StokHareket> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(x => x.UrunAd).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Kullanici).IsRequired().HasMaxLength(75);
            builder.Property(x => x.UrunGrup).IsRequired();
            builder.Property(x => x.Birim).IsRequired();
            builder.Property(x => x.Miktar).IsRequired();
            builder.Property(x => x.UrunGrup).IsRequired();
            builder.Property(x => x.Tarih).IsRequired();
        }
    }
}
