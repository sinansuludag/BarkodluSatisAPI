using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface IServiceManager
    {
        IBarkodService BarkodService { get; }  
        IHizliUrunService HizliUrunService { get; }
        IIslemService IslemService { get; }
        IIslemOzetService IslemOzetService { get; }
        IKullaniciService KullaniciService { get; }
        ISabitService SabitService { get; }
        ISatisService SatisService { get; }
        IStokHareketService StokHareketService { get; }
        ITeraziService TeraziService { get; }
        IUrunService UrunService { get; }
        IUrunGrupService UrunGrupService { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
