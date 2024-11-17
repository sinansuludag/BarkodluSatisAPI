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
    public class UrunGrupService : IUrunGrupService
    {
        private readonly IRepositoryManager _repositoryManager;

        public UrunGrupService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<UrunGrup> AddOneUrunGrupAsync(UrunGrup grup)
        {
            if(grup is null)
                throw new ArgumentNullException(nameof(grup));  
            await _repositoryManager.UrunGrup.AddAsync(grup);
            await _repositoryManager.SaveAsync();
            return grup;
        }

        public async Task DeleteOneUrunGrupAsync(int id)
        {
            var urunGrup=await _repositoryManager.UrunGrup.GetByIdAsync(id);
            if (urunGrup is null)
                throw new Exception($"UrunGrup with id:{id} could not found.");
            await _repositoryManager.UrunGrup.DeleteAsync(urunGrup);
            await _repositoryManager.SaveAsync();
        }

        public Task<IEnumerable<UrunGrup>> GetAllUrunGrupAsync()
        {
            return _repositoryManager.UrunGrup.GetAllAsync();
        }

        public Task<UrunGrup> GetOneUrunGrupAsync(int id)
        {
            return _repositoryManager.UrunGrup.GetByIdAsync(id);
        }

        public async Task<UrunGrup> UpdateOneUrunGrupAsync(int id, UrunGrup grup)
        {
            var entity = await _repositoryManager.UrunGrup.GetByIdAsync(id);
            if (grup is null)
                throw new ArgumentNullException(nameof(grup));
            if(entity is null) 
                throw new Exception($"UrunGrup with id:{id} could not found.");

            entity.UrunGrupAd=grup.UrunGrupAd;

            await _repositoryManager.UrunGrup.UpdateAsync(entity);
            await _repositoryManager.SaveAsync();
            return entity;

        }
    }
}
