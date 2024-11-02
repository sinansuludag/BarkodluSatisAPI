using BarkodluSatis.BLL.EFCore;
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

        public RepositoryManager(BarkodContextDB context)
        {
            _context = context;
            _barkodRepository = new Lazy<IBarkodRepository>(()=>new BarkodRepository(_context));
        }

        public IBarkodRepository Barkod => _barkodRepository.Value;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
