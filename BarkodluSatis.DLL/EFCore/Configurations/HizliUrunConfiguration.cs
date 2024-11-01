using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.EFCore.Configurations
{
    public class HizliUrunConfiguration : IEntityTypeConfiguration<HizliUrun>
    {
        public void Configure(EntityTypeBuilder<HizliUrun> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(k => k.Id).UseIdentityColumn();
            builder.Property(k => k.Barkod).IsRequired().HasMaxLength(50);
            builder.Property(k => k.UrunAd).IsRequired().HasMaxLength(150);
        }
    }
}
