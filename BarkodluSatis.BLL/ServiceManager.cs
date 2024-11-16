using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.Contracts;
using BarkodluSatis.DLL.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IBarkodService> _barkodService;
        private readonly Lazy<IHizliUrunService> _hizliUrunService;
        private readonly Lazy<IIslemService> _islemService;
        private readonly Lazy<IIslemOzetService> _islemOzetService;
        private readonly Lazy<IKullaniciService> _kullaniciService;
        private readonly Lazy<ISabitService> _sabitService;
        private readonly Lazy<ISatisService> _satisService;
        private readonly Lazy<IStokHareketService> _stokHareketService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _barkodService = new Lazy<IBarkodService>(()=>new BarkodService(repositoryManager));
            _hizliUrunService = new Lazy<IHizliUrunService>(()=>new HizliUrunService(repositoryManager));
            _islemService = new Lazy<IIslemService>(()=>new IslemService(repositoryManager));
            _islemOzetService = new Lazy<IIslemOzetService>(() => new IslemOzetService(repositoryManager));
            _kullaniciService = new Lazy<IKullaniciService>(()=>new KullaniciService(repositoryManager));
            _sabitService=new Lazy<ISabitService>(()=>new SabitService(repositoryManager));
            _satisService=new Lazy<ISatisService>(()=>new SatisService(repositoryManager));
            _stokHareketService = new Lazy<IStokHareketService>(()=>new StokHareketService(repositoryManager));
        }

        public IBarkodService BarkodService => _barkodService.Value;

        public IHizliUrunService HizliUrunService =>_hizliUrunService.Value;

        public IIslemService IslemService => _islemService.Value;

        public IIslemOzetService IslemOzetService => _islemOzetService.Value;

        public IKullaniciService KullaniciService => _kullaniciService.Value;

        public ISabitService SabitService => _sabitService.Value;

        public ISatisService SatisService => _satisService.Value;

        public IStokHareketService StokHareketService => _stokHareketService.Value;
    }
}
