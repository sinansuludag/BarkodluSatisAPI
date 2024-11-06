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
    public class IslemOzetService : IIslemOzetService
    {
        private readonly IRepositoryManager _repositoryManager;

        public IslemOzetService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<IslemOzet> AddOneIslemOzetAsync(IslemOzet islemOzet)
        {
            if (islemOzet is null) 
                throw new ArgumentNullException(nameof(islemOzet));

            await _repositoryManager.IslemOzet.AddAsync(islemOzet);
            await _repositoryManager.SaveAsync();
            return islemOzet;
        }

        public async Task DeleteOneIslemOzetAsync(int id)
        {
            var islemOzet = await _repositoryManager.IslemOzet.GetByIdAsync(id);
            if (islemOzet is null)
                throw new Exception($"IslemOzet with id:{id} could not found.");
            await _repositoryManager.IslemOzet.DeleteAsync(islemOzet);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<IslemOzet>> GetAllIslemOzetAsync()
        {
            return await _repositoryManager.IslemOzet.GetAllAsync();
        }

        public async Task<IslemOzet> GetOneIslemOzetAsync(int id)
        {
            return await _repositoryManager.IslemOzet.GetByIdAsync(id);
        }

        public async Task<IslemOzet> UpdateOneIslemOzetasync(int id, IslemOzet islemOzet)
        {
            var entity = await _repositoryManager.IslemOzet.GetByIdAsync(id);
            if (islemOzet is null)
                throw new ArgumentNullException(nameof(islemOzet));

            if (entity is null)
                throw new Exception($"IslemOzet with id:{id} could not found.");

            entity.IslemNo=islemOzet.IslemNo;
            entity.Iade=islemOzet.Iade;
            entity.OdemeSekli = islemOzet.OdemeSekli;
            entity.Nakit=islemOzet.Nakit;
            entity.Kart=islemOzet.Kart;
            entity.Gelir=islemOzet.Gelir;
            entity.Gider=islemOzet.Gider;
            entity.AlisFiyatToplam=islemOzet.AlisFiyatToplam;
            entity.Aciklama=islemOzet.Aciklama;
            entity.Tarih=islemOzet.Tarih;
            entity.Kullanici=islemOzet.Kullanici;

            await _repositoryManager.IslemOzet.UpdateAsync(entity);
            await _repositoryManager.SaveAsync();

            return entity;

        }
    }
}
