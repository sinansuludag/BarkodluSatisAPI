using BarkodluSatis.BLL.EFCore;
using BarkodluSatis.DLL.BarkodDBObjects;
using BarkodluSatis.DLL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.DLL.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly BarkodContextDB _context;
        private readonly Lazy<IBarkodRepository> _barkodRepository;
        private readonly Lazy<IHizliUrunRepository> _hizliUrunRepository;
        private readonly Lazy<IIslemRepository> _islemRepository;
        private readonly Lazy<IIslemOzetRepository> _islemOzetRepository;

        public RepositoryManager(BarkodContextDB context)
        {
            _context = context;
            _barkodRepository = new Lazy<IBarkodRepository>(()=>new BarkodRepository(_context));
            _hizliUrunRepository = new Lazy<IHizliUrunRepository>(()=>new HizliUrunRepository(_context));
            _islemRepository = new Lazy<IIslemRepository>(()=>new IslemRepository(_context));
            _islemOzetRepository = new Lazy<IIslemOzetRepository>(()=> new IslemOzetRepository(_context));
        }

        public IBarkodRepository Barkod => _barkodRepository.Value;

        public IHizliUrunRepository HizliUrun => _hizliUrunRepository.Value;

        public IIslemRepository Islem => _islemRepository.Value;

        public IIslemOzetRepository IslemOzet => _islemOzetRepository.Value;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
