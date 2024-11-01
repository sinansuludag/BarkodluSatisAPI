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
    public class BarkodConfiguration : IEntityTypeConfiguration<Barkod>
    {
        public void Configure(EntityTypeBuilder<Barkod> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(k => k.Id).UseIdentityColumn();
            builder.Property(k => k.BarkodNo).IsRequired().HasMaxLength(50);

        }
    }
}
