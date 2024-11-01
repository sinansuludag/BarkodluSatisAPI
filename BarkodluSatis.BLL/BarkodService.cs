using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using BarkodluSatis.DLL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL
{
    public class BarkodService : IBarkodService
    {
        private readonly IRepositoryManager _repositoryManager;

        public BarkodService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public Barkod AddOneBarkod(Barkod barkod)
        {
            if(barkod is null)
                throw new ArgumentNullException(nameof(barkod));

           _repositoryManager.Barkod.Add(barkod);
            _repositoryManager.Save();
            return barkod; 
        }

        public void DeleteOneBarkod(int id)
        {
            var entity=_repositoryManager.Barkod.GetById(id);
            if (entity is null)
                throw new Exception($"Barkod with id:{id} could not found.");
            _repositoryManager.Barkod.Delete(entity);
            _repositoryManager.Save();

        }

        public IEnumerable<Barkod> GetAllBarkods()
        {
            return _repositoryManager.Barkod.GetAll();
        }

        public Barkod GetOneBarkodById(int id)
        {
            return _repositoryManager.Barkod.GetById(id);
        }

        public void UpdateOneBarkod(int id, Barkod barkod)
        {
            var entity = _repositoryManager.Barkod.GetById(id);
            if (entity is null)
                throw new Exception($"Barkod with id:{id} could not found.");

            if (barkod is null)
                throw new ArgumentNullException(nameof(Barkod));

            entity.BarkodNo = barkod.BarkodNo;

            _repositoryManager.Barkod.Update(entity);
            _repositoryManager.Save();
        }
    }
}
