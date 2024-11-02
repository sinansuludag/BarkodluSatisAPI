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
        Task<IEnumerable<Barkod>> GetAllBarkodAsync();
        Task<Barkod> GetOneBarkodByIdAsync(int id);
        Task<Barkod> AddOneBarkodAsync(Barkod barkod);
        Task DeleteOneBarkodAsync(int id);
        Task UpdateOneBarkodAsync(int id, Barkod barkod);

    }
}
