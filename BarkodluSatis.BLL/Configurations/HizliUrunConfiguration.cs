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
    public class HizliUrunConfiguration : IEntityTypeConfiguration<HizliUrun>
    {
        public void Configure(EntityTypeBuilder<HizliUrun> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(k=>k.Id).UseIdentityColumn();

        }
    }
}
