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
    public class IslemOzetConfiguration : IEntityTypeConfiguration<IslemOzet>
    {
        public void Configure(EntityTypeBuilder<IslemOzet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IslemNo).IsRequired();
            builder.Property(x => x.Iade).IsRequired();
            builder.Property(x => x.OdemeSekli).IsRequired();
            builder.Property(x => x.AlisFiyatToplam).IsRequired();
            builder.Property(x => x.Tarih).IsRequired();
            builder.Property(x => x.Kullanici).IsRequired().HasMaxLength(100);

        }
    }
}
