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
    public class SatisService : ISatisService
    {
        private readonly IRepositoryManager _repositoryManager;

        public SatisService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Satis> AddOneSatisAsync(Satis satis)
        {
            if (satis is null)
                throw new ArgumentNullException(nameof(satis)); 

            await _repositoryManager.Satis.AddAsync(satis);
            await _repositoryManager.SaveAsync();
            return satis;
        }

        public async Task DeleteOneSatisAsync(int id)
        {
            var satis=await _repositoryManager.Satis.GetByIdAsync(id);
            if (satis is null)
                throw new Exception($"Satis with id:{id} could not found.");
            await _repositoryManager.Satis.DeleteAsync(satis);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<Satis>> GetAllSatisAsync()
        {
            return await _repositoryManager.Satis.GetAllAsync();
        }

        public async Task<Satis> GetOneSatisAsync(int id)
        {
            return await _repositoryManager.Satis.GetByIdAsync(id);
        }

        public async Task<Satis> UpdateOneSatisAsync(int id, Satis satis)
        {
            var entity = await _repositoryManager.Satis.GetByIdAsync(id);
            if(satis is null)
                throw new ArgumentNullException(nameof(satis));

            if (entity is null)
                throw new Exception($"Satis with id:{id} could not found.");

            entity.IslemNo = satis.IslemNo;
            entity.UrunAd= satis.UrunAd;
            entity.Barkod= satis.Barkod;
            entity.UrunGrup= satis.UrunGrup;
            entity.Birim= satis.Birim;
            entity.AlisFiyat= satis.AlisFiyat;
            entity.SatisFiyat = satis.SatisFiyat;
            entity.Miktar= satis.Miktar;
            entity.Toplam= satis.Toplam;
            entity.KdvTutari= satis.KdvTutari;
            entity.OdemeSekli= satis.OdemeSekli;
            entity.Iade= satis.Iade;
            entity.Tarih= satis.Tarih;
            entity.Kullanici= satis.Kullanici;

            await _repositoryManager.Satis.UpdateAsync(entity);
            await _repositoryManager.SaveAsync();
            return entity;
        }
    }
}
