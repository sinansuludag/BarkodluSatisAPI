using BarkodluSatis.DLL.BarkodDBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface IBarkodService
    {
        IEnumerable<Barkod> GetAllBarkods();
        Barkod GetOneBarkodById(int id);
        Barkod AddOneBarkod(Barkod barkod);
        void DeleteOneBarkod(int id);
        void UpdateOneBarkod(int id, Barkod barkod);

    }
}
