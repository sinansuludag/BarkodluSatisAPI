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
    public class IslemService : IIslemService
    {
        private readonly IRepositoryManager _repositoryManager;

        public IslemService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Islem> AddOneIslemAsync(Islem entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            await _repositoryManager.Islem.AddAsync(entity);
            await _repositoryManager.SaveAsync();
            return entity;
        }

        public async Task DeleteOneIslemAsync(int id)
        {
            var entity= await _repositoryManager.Islem.GetByIdAsync(id);
            if (entity is null)
                throw new Exception($"Islem with id:{id} could not found.");

            await _repositoryManager.Islem.DeleteAsync(entity);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<Islem>> GetAllIslemAsync()
        {
            return await _repositoryManager.Islem.GetAllAsync();
        }

        public async Task<Islem> GetOneIslemByIdAsync(int id)
        {
            return await _repositoryManager.Islem.GetByIdAsync(id);
        }

        public async Task<Islem> UpdateOneIslemAsync(int id, Islem entity)
        {
           var islem=await _repositoryManager.Islem.GetByIdAsync(id);
            if (islem is null)
                throw new Exception($"Islem with id:{id} could not found.");
            if(entity is null)
                throw new ArgumentNullException((nameof(entity)));

            islem.IslemNo=entity.IslemNo;
            await _repositoryManager.Islem.UpdateAsync(islem);
            await _repositoryManager.SaveAsync();   
            return islem;

        }
    }
}
