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
    public class StokHareketService : IStokHareketService
    {
        private readonly IRepositoryManager _repositoryManager;

        public StokHareketService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<StokHareket> AddOneStokHareketAsync(StokHareket stokHareket)
        {
            if (stokHareket is null) 
                 throw new ArgumentNullException(nameof(stokHareket));

            await _repositoryManager.StokHareket.AddAsync(stokHareket);
            await _repositoryManager.SaveAsync();
            return stokHareket;

        }

        public async Task DeleteOneStokHareketAsync(int id)
        {
            var stokHareket=await _repositoryManager.StokHareket.GetByIdAsync(id);
            if (stokHareket is null)
                throw new Exception($"StokHareket with id:{id} could not found.");
            await _repositoryManager.StokHareket.DeleteAsync(stokHareket);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<StokHareket>> GetAllStokHareketAsync()
        {
           return await _repositoryManager.StokHareket.GetAllAsync();
        }

        public async Task<StokHareket> GetOneStokHareketAsync(int id)
        {
            return await _repositoryManager.StokHareket.GetByIdAsync(id);
        }

        public async Task<StokHareket> UpdateOneStokHareketAsync(int id, StokHareket stokHareket)
        {
            var entity = await _repositoryManager.StokHareket.GetByIdAsync(id);
            if (stokHareket is null)
                throw new ArgumentNullException(nameof(stokHareket));

            if (entity is null)
                throw new Exception($"StokHareket with id:{id} could not found.");

            entity.Barkod=stokHareket.Barkod;
            entity.UrunAd=stokHareket.UrunAd;
            entity.Birim=stokHareket.Birim;
            entity.Miktar=stokHareket.Miktar;
            entity.UrunGrup=stokHareket.UrunGrup;
            entity.Kullanici=stokHareket.Kullanici;
            entity.Tarih=stokHareket.Tarih;

            await _repositoryManager.StokHareket.UpdateAsync(entity);
            await _repositoryManager.SaveAsync();
            return entity;
        }
    }
}
