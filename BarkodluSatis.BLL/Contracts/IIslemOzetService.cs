using BarkodluSatis.DLL.BarkodDBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface IIslemOzetService
    {
        Task<IEnumerable<IslemOzet>> GetAllIslemOzetAsync();
        Task<IslemOzet> GetOneIslemOzetAsync(int id);
        Task<IslemOzet> AddOneIslemOzetAsync(IslemOzet islemOzet);
        Task DeleteOneIslemOzetAsync(int id);
        Task<IslemOzet> UpdateOneIslemOzetasync(int id,IslemOzet islemOzet);
    }
}
