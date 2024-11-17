using BarkodluSatis.DLL.BarkodDBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface IUrunGrupService
    {
        Task<IEnumerable<UrunGrup>> GetAllUrunGrupAsync();
        Task<UrunGrup> GetOneUrunGrupAsync(int id);
        Task<UrunGrup> AddOneUrunGrupAsync(UrunGrup grup);
        Task<UrunGrup> UpdateOneUrunGrupAsync(int id, UrunGrup grup);
        Task DeleteOneUrunGrupAsync(int id);
    }
}
