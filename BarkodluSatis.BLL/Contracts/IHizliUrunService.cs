using BarkodluSatis.DLL.BarkodDBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface IHizliUrunService
    {
        Task<IEnumerable<HizliUrun>> GetAllHizliUrunAsync();
        Task<HizliUrun> GetOneHizliUrunByIdAsync(int id);
        Task<HizliUrun> AddOneHizliUrunAsync(HizliUrun hizliUrun);
        Task DeleteOneHizliUrunAsync(int id);
        Task UpdateOneHizliUrunAsync(int id, HizliUrun hizliUrun);
    }
}
