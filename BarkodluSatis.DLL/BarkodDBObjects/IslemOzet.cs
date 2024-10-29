using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.DLL.BarkodDBObjects
{
    public class IslemOzet
    {
        public int Id { get; set; }
        public int IslemNo { get; set; }
        public bool Iade { get; set; }
        public string OdemeSekli { get; set; }
        public double Nakit { get; set; }
        public double Kart { get; set; }
        public bool Gelir { get; set; }
        public bool Gider { get; set; }
        public double AlisFiyatToplam { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public string Kullanici { get; set; }
    }
}
