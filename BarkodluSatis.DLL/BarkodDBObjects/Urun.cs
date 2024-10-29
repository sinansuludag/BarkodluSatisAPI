using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.DLL.BarkodDBObjects
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string Barkod { get; set; }
        public string UrunAd { get; set; }
        public string Aciklama { get; set; }
        public string UrunGrup { get; set; }
        public double AlisFiyati { get; set; }
        public double SatisFiyati { get; set; }
        public int KdvOrani { get; set; }
        public double KdvTutari { get; set; }
        public string Birim { get; set; }
        public double Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public string Kullanici { get; set; }
    }
}
