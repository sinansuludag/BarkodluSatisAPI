using BarkodluSatis.DLL.BarkodDBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface ISatisService
    {
        Task<IEnumerable<Satis>> GetAllSatisAsync();
        Task<Satis> GetOneSatisAsync(int id);
        Task<Satis> AddOneSatisAsync(Satis satis);
        Task<Satis> UpdateOneSatisAsync(int id, Satis satis);
        Task DeleteOneSatisAsync(int id);
    }
}
