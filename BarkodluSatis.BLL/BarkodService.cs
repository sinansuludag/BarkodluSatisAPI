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

        public async Task<Barkod> AddOneBarkodAsync(Barkod barkod)
        {
            if(barkod is null)
                throw new ArgumentNullException(nameof(barkod));

            await _repositoryManager.Barkod.AddAsync(barkod);
           await _repositoryManager.SaveAsync();
            return barkod; 
        }

        public async Task DeleteOneBarkodAsync(int id)
        {
            var entity=await _repositoryManager.Barkod.GetByIdAsync(id);
            if (entity is null)
                throw new Exception($"Barkod with id:{id} could not found.");
            await _repositoryManager.Barkod.DeleteAsync(entity);
            await _repositoryManager.SaveAsync();

        }

        public async Task<IEnumerable<Barkod>> GetAllBarkodAsync()
        {
            return await _repositoryManager.Barkod.GetAllAsync();
        }

        public async Task<Barkod> GetOneBarkodByIdAsync(int id)
        {
            return await _repositoryManager.Barkod.GetByIdAsync(id);
        }

        public async Task<Barkod> UpdateOneBarkodAsync(int id, Barkod barkod)
        {
            var entity =await _repositoryManager.Barkod.GetByIdAsync(id);
            if (entity is null)
                throw new Exception($"Barkod with id:{id} could not found.");

            if (barkod is null)
                throw new ArgumentNullException(nameof(Barkod));

            entity.BarkodNo = barkod.BarkodNo;

            await _repositoryManager.Barkod.UpdateAsync(entity);
            await _repositoryManager.SaveAsync();
            return entity;
        }
    }
}
