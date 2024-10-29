using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.DLL.BarkodDBObjects
{
    public class HizliUrun
    {
        public int Id { get; set; }
        public string Barkod { get; set; }
        public string UrunAd { get; set; }
        public double Fiyat { get; set; }
    }
}
