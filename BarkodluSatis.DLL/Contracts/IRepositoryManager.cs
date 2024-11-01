using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.DLL.Contracts
{
    public interface IRepositoryManager
    {
        IBarkodRepository Barkod { get;}
        void Save();
    }
}
