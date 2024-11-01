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
    public class IslemConfiguration : IEntityTypeConfiguration<Islem>
    {
        public void Configure(EntityTypeBuilder<Islem> builder)
        {
            builder.HasKey(k=>k.Id);
            builder.Property(k=>k.Id).UseIdentityColumn();
            builder.Property(k => k.IslemNo).IsRequired();
        }
    }
}
