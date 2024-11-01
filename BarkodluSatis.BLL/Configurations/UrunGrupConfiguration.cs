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
    public class UrunGrupConfiguration : IEntityTypeConfiguration<UrunGrup>
    {
        public void Configure(EntityTypeBuilder<UrunGrup> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(x => x.UrunGrupAd).IsRequired().HasMaxLength(100);
        }
    }
}
