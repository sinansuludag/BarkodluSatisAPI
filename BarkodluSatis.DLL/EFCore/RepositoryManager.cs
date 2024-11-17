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
        private readonly Lazy<IKullaniciRepository> _kullaniciRepository;
        private readonly Lazy<ISabitRepository> _sabitRepository;
        private readonly Lazy<ISatisRepository> _satisRepository;
        private readonly Lazy<IStokHareketRepository> _stokHareketRepository;
        private readonly Lazy<ITeraziRepository> _teraziRepository;
        private readonly Lazy<IUrun> _urunRepository;

        public RepositoryManager(BarkodContextDB context)
        {
            _context = context;
            _barkodRepository = new Lazy<IBarkodRepository>(()=>new BarkodRepository(_context));
            _hizliUrunRepository = new Lazy<IHizliUrunRepository>(()=>new HizliUrunRepository(_context));
            _islemRepository = new Lazy<IIslemRepository>(()=>new IslemRepository(_context));
            _islemOzetRepository = new Lazy<IIslemOzetRepository>(()=> new IslemOzetRepository(_context));
            _kullaniciRepository = new Lazy<IKullaniciRepository>(()=>new KullaniciRepository(_context));
            _sabitRepository=new Lazy<ISabitRepository>(()=>new SabitRepository(_context));
            _satisRepository=new Lazy<ISatisRepository>(()=>new SatisRepository(_context));
            _stokHareketRepository = new Lazy<IStokHareketRepository>(()=> new StokHareketRepository(_context));
            _teraziRepository=new Lazy<ITeraziRepository>(()=>new TeraziRepository(_context));
            _urunRepository=new Lazy<IUrun>(()=>new UrunRepository(_context));
        }

        public IBarkodRepository Barkod => _barkodRepository.Value;

        public IHizliUrunRepository HizliUrun => _hizliUrunRepository.Value;

        public IIslemRepository Islem => _islemRepository.Value;

        public IIslemOzetRepository IslemOzet => _islemOzetRepository.Value;

        public IKullaniciRepository Kullanici => _kullaniciRepository.Value;

        public ISabitRepository Sabit => _sabitRepository.Value;

        public ISatisRepository Satis => _satisRepository.Value;

        public IStokHareketRepository StokHareket => _stokHareketRepository.Value;

        public ITeraziRepository Terazi => _teraziRepository.Value;

        public IUrun Urun => _urunRepository.Value;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
