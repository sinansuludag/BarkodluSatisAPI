using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.DLL.BarkodDBObjects
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public bool Satis { get; set; }
        public bool Rapor { get; set; }
        public bool Stok { get; set; }
        public bool UrunGiris { get; set; }
        public bool Ayarlar { get; set; }
        public bool FiyatGuncelle { get; set; }
        public bool Yedekleme { get; set; }
    }
}
