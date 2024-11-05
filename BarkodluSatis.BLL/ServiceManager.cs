using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.Contracts;
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
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _barkodService = new Lazy<IBarkodService>(()=>new BarkodService(repositoryManager));
            _hizliUrunService = new Lazy<IHizliUrunService>(()=>new HizliUrunService(repositoryManager));
        }

        public IBarkodService BarkodService => _barkodService.Value;

        public IHizliUrunService HizliUrunService =>_hizliUrunService.Value;
    }
}
