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
    public class HizliUrunService : IHizliUrunService
    {
        private readonly IRepositoryManager _repositoryManager;

        public HizliUrunService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<HizliUrun> AddOneHizliUrunAsync(HizliUrun hizliUrun)
        {
            if (hizliUrun is null)
                throw new ArgumentNullException(nameof(hizliUrun));

            await _repositoryManager.HizliUrun.AddAsync(hizliUrun);
            await _repositoryManager.SaveAsync();
            return hizliUrun;
        }

        public async Task DeleteOneHizliUrunAsync(int id)
        {
            var entity = await _repositoryManager.HizliUrun.GetByIdAsync(id);
            if (entity is null)
                throw new Exception($"HizliUrun with id:{id} could not found.");
            await _repositoryManager.HizliUrun.DeleteAsync(entity);
            await _repositoryManager.SaveAsync();
            
        }

        public async Task<IEnumerable<HizliUrun>> GetAllHizliUrunAsync()
        {
            return await _repositoryManager.HizliUrun.GetAllAsync();
        }


        public async Task<HizliUrun> GetOneHizliUrunByIdAsync(int id)
        {
            return await _repositoryManager.HizliUrun.GetByIdAsync(id);
        }

        public async Task<HizliUrun> UpdateOneHizliUrunAsync(int id, HizliUrun hizliUrun)
        {
            var entity = await _repositoryManager.HizliUrun.GetByIdAsync(id);
            if (entity is null)
                throw new Exception($"HizliUrun with id:{id} could not found.");

            if (hizliUrun is null)
                throw new ArgumentNullException(nameof(hizliUrun));

            entity.Barkod = hizliUrun.Barkod;
            entity.UrunAd= hizliUrun.UrunAd;
            entity.Fiyat = hizliUrun.Fiyat;

            await _repositoryManager.HizliUrun.UpdateAsync(entity);
            await _repositoryManager.SaveAsync();
            return entity;
           
        }
    }
}
