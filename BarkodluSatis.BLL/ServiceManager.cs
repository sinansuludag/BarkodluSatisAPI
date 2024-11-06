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
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _barkodService = new Lazy<IBarkodService>(()=>new BarkodService(repositoryManager));
            _hizliUrunService = new Lazy<IHizliUrunService>(()=>new HizliUrunService(repositoryManager));
            _islemService = new Lazy<IIslemService>(()=>new IslemService(repositoryManager));
        }

        public IBarkodService BarkodService => _barkodService.Value;

        public IHizliUrunService HizliUrunService =>_hizliUrunService.Value;

        public IIslemService IslemService => _islemService.Value;
    }
}
