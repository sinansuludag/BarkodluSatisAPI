using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.EFCore
{
    public class BarkodContextDB : DbContext
    {
        public BarkodContextDB()
        {

        }

        public BarkodContextDB(DbContextOptions<BarkodContextDB> options) : base(options)
        {

        }


        public DbSet<Barkod> Barkod { get; set; }
        public DbSet<HizliUrun> HizliUrun { get; set; }
        public DbSet<Islem> Islem { get; set; }
        public DbSet<IslemOzet> IslemOzet { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Sabit> Sabit { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<StokHareket> StokHareket { get; set; }
        public DbSet<Terazi> Terazi { get; set; }
        public DbSet<UrunGrup> UrunGrup { get; set; }






        /*
         Yapılan tablo altında kolon ayarları tablo ile birleştirilmesi gereklidir. Bunu her bir tablo için ayrı ayrı yapabildiğimiz gibi (uzun yol)
            bütün tablolar için ortak bir kod ile de yapabiliriz
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // IEntityTypeConfiguration Implement olan bütün classları görecektir
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            /*1.Adım=> Tablo yap
             * 2.Adım=> Tabloda configration ayarları yap
             * 3.Adım=> DB classında (bu class ta) birleştir ayarı yap    
             * 4.Adım=> Migration yap
             
             */

        }

    }
}
