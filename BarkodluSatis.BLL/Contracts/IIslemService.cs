using BarkodluSatis.DLL.BarkodDBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface IIslemService
    {
        Task<IEnumerable<Islem>> GetAllIslemAsync();
        Task<Islem> GetOneIslemByIdAsync(int id);
        Task<Islem> AddOneIslemAsync(Islem entity);
        Task<Islem> UpdateOneIslemAsync(int id,Islem entity);
        Task DeleteOneIslemAsync(int id);
    }
}
