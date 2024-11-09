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
    public class KullaniciService : IKullaniciService
    {
        private readonly IRepositoryManager _repositoryManager;

        public KullaniciService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Kullanici> AddOneKullaniciAsync(Kullanici kullanici)
        {
          if (kullanici is null) 
                    throw new ArgumentNullException(nameof(kullanici));

                await _repositoryManager.Kullanici.AddAsync(kullanici);
                await _repositoryManager.SaveAsync();
                return kullanici;
        }

        public async Task DeleteOneKullaniciAsync(int id)
        {
            var entity = await _repositoryManager.Kullanici.GetByIdAsync(id);
            if (entity is null)
                throw new Exception($"Kullanici with id:{id} could not found.");

            await _repositoryManager.Kullanici.DeleteAsync(entity);
            await _repositoryManager.SaveAsync();   
        }

        public async Task<IEnumerable<Kullanici>> GetAllKullaniciAsync()
        {
            return await _repositoryManager.Kullanici.GetAllAsync();
        }

        public async Task<Kullanici> GetOneKullaniciAsync(int id)
        {
            return await _repositoryManager.Kullanici.GetByIdAsync(id);
        }

        public async Task<Kullanici> UpdateOneKullaniciAsync(int id, Kullanici kullanici)
        {
            var entities = await _repositoryManager.Kullanici.GetByIdAsync(id);
            if (kullanici is null)
                throw new ArgumentNullException(nameof(kullanici));

            if (entities is null)
                throw new Exception($"Kullanici with id:{id} could not found.");

            entities.AdSoyad = kullanici.AdSoyad;
            entities.Telefon = kullanici.Telefon;
            entities.Eposta = kullanici.Eposta;
            entities.KullaniciAd=kullanici.KullaniciAd;
            entities.Sifre=kullanici.Sifre;
            entities.Satis=kullanici.Satis;
            entities.Rapor=kullanici.Rapor; 
            entities.Stok=kullanici.Stok;
            entities.UrunGiris=kullanici.UrunGiris;
            entities.Ayarlar=kullanici.Ayarlar;
            entities.FiyatGuncelle=kullanici.FiyatGuncelle;
            entities.Yedekleme=kullanici.Yedekleme;

            await _repositoryManager.Kullanici.UpdateAsync(entities);
            await _repositoryManager.SaveAsync();
            return entities;
        }
    }
}
