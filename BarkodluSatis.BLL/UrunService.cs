
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
    public class UrunService : IUrunService
    {
        private readonly IRepositoryManager _repositoryManager;

        public UrunService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Urun> AddOneUrunAsync(Urun urun)
        {
            if (urun is null)
                throw new ArgumentNullException(nameof(urun));
            await _repositoryManager.Urun.AddAsync(urun);
            await _repositoryManager.SaveAsync();
            return urun;
        }

        public async Task DeleteOneUrunAsync(int id)
        {
            var urun=await _repositoryManager.Urun.GetByIdAsync(id);
            if (urun is null)
                throw new Exception($"Urun with id:{id} could not found.");
            await _repositoryManager.Urun.DeleteAsync(urun);
            await _repositoryManager.SaveAsync();
        }

        public Task<IEnumerable<Urun>> GetAllUrunAsync()
        {
            return _repositoryManager.Urun.GetAllAsync();
        }

        public Task<Urun> GetOneUrunAsync(int id)
        {
            return _repositoryManager.Urun.GetByIdAsync(id);
        }

        public async Task<Urun> UpdateOneUrunAsync(int id, Urun urun)
        {
            var entity = await _repositoryManager.Urun.GetByIdAsync(id);
            if(urun is null)
                throw new ArgumentNullException(nameof(urun));
            if (entity is null)
                throw new Exception($"Urun with id:{id} could not found.");

            entity.Barkod = urun.Barkod;
            entity.UrunAd=urun.UrunAd;
            entity.Aciklama = urun.Aciklama;
            entity.UrunGrup=urun.UrunGrup;
            entity.AlisFiyati = urun.AlisFiyati;
            entity.SatisFiyati=urun.SatisFiyati;
            entity.KdvOrani = urun.KdvOrani;
            entity.KdvTutari = urun.KdvTutari;
            entity.Birim=urun.Birim;
            entity.Miktar=urun.Miktar;
            entity.Tarih=urun.Tarih;
            entity.Kullanici=urun.Kullanici;

            await _repositoryManager.Urun.UpdateAsync(entity);
            await _repositoryManager.SaveAsync();
            return entity;
        }
    }
}
