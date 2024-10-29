using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.DLL.BarkodDBObjects
{
    public class Satis
    {
        public int SatisId { get; set; }
        public int IslemNo { get; set; }
        public string UrunAd { get; set; }
        public string Barkod { get; set; }
        public string UrunGrup { get; set; }
        public string Birim { get; set; }
        public double AlisFiyat { get; set; }
        public double SatisFiyat { get; set; }
        public double Miktar { get; set; }
        public double Toplam { get; set; }
        public double KdvTutari { get; set; }
        public string OdemeSekli { get; set; }
        public bool Iade { get; set; }
        public DateTime Tarih { get; set; }
        public string Kullanici { get; set; }
    }
}
