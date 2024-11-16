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
    public class TeraziService : ITeraziService
    {
        private readonly  IRepositoryManager _repositoryManager;

        public TeraziService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Terazi> AddOneTeraziAsync(Terazi terazi)
        {
            if (terazi is null)
                throw new ArgumentNullException(nameof(terazi));
            await _repositoryManager.Terazi.AddAsync(terazi);
            await _repositoryManager.SaveAsync();
            return terazi;
        }

        public async Task DeleteOneTeraziAsync(int id)
        {
            var terazi=await _repositoryManager.Terazi.GetByIdAsync(id);
            if (terazi is null)
                throw new Exception($"Terazi with id:{id} could not found.");
            await _repositoryManager.Terazi.DeleteAsync(terazi);
            await _repositoryManager.SaveAsync();   
        }

        public Task<IEnumerable<Terazi>> GetAllTeraziAsync()
        {
            return _repositoryManager.Terazi.GetAllAsync();
        }

        public Task<Terazi> GetOneTeraziAsync(int id)
        {
            return _repositoryManager.Terazi.GetByIdAsync(id);
        }

        public async Task<Terazi> UpdateOneTeraziAsync(int id, Terazi terazi)
        {
            var entity = await _repositoryManager.Terazi.GetByIdAsync(id);
            if(terazi is null)
                throw new ArgumentNullException(nameof(terazi));

            if (entity is null)
                throw new Exception($"Terazi with id:{id} could not found.");

            entity.TeraziOnEk=terazi.TeraziOnEk;
            await _repositoryManager.Terazi.UpdateAsync(entity);
            await _repositoryManager.SaveAsync();
            return entity;
        }
    }
}
