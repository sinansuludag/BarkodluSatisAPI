using BarkodluSatis.DLL.BarkodDBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface IUrunService
    {
        Task<IEnumerable<Urun>> GetAllUrunAsync();
        Task<Urun> GetOneUrunAsync(int id);
        Task<Urun> AddOneUrunAsync(Urun urun);
        Task<Urun> UpdateOneUrunAsync(int id, Urun urun);   
        Task DeleteOneUrunAsync(int id);
    }
}
