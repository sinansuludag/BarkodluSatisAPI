using BarkodluSatis.DLL.BarkodDBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface IStokHareketService
    {
        Task<IEnumerable<StokHareket>> GetAllStokHareketAsync();
        Task<StokHareket> GetOneStokHareketAsync(int id);
        Task<StokHareket> AddOneStokHareketAsync(StokHareket stokHareket);
        Task<StokHareket> UpdateOneStokHareketAsync(int id, StokHareket stokHareket);
        Task DeleteOneStokHareketAsync(int id);
    }
}
