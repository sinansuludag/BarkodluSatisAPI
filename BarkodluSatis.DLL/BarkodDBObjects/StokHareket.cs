using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.DLL.BarkodDBObjects
{
    public class StokHareket
    {
        public int Id { get; set; }
        public string Barkod { get; set; }
        public string UrunAd { get; set; }
        public string Birim { get; set; }
        public double Miktar { get; set; }
        public string UrunGrup { get; set; }
        public string Kullanici { get; set; }
        public DateTime Tarih { get; set; }
    }
}
