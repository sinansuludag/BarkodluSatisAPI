using BarkodluSatis.DLL.BarkodDBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface IKullaniciService
    {
        Task <IEnumerable<Kullanici>> GetAllKullaniciAsync();
        Task<Kullanici> GetOneKullaniciAsync(int id);
        Task<Kullanici> AddOneKullaniciAsync(Kullanici kullanici);
        Task<Kullanici> UpdateOneKullaniciAsync(int id,Kullanici kullanici);
        Task DeleteOneKullaniciAsync(int id);
    }
}
