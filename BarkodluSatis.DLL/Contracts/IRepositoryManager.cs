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
        IHizliUrunRepository HizliUrun { get;}
        IIslemRepository Islem { get;}
        IIslemOzetRepository IslemOzet { get;}
        IKullaniciRepository Kullanici { get;}
        ISabitRepository Sabit { get;}
        ISatisRepository Satis { get;}
        IStokHareketRepository StokHareket { get;}
        ITeraziRepository Terazi { get;}
        IUrun Urun { get;}
        IUrunGrupRepository UrunGrup { get;}
        Task SaveAsync();
    }
}
