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
    public class SabitService : ISabitService
    {
        private readonly IRepositoryManager _repositoryManager;
        public SabitService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Sabit> AddOneSabitAsync(Sabit sabit)
        {
            if (sabit is null) 
                throw new ArgumentNullException(nameof(sabit));

            await _repositoryManager.Sabit.AddAsync(sabit);
            await _repositoryManager.SaveAsync();
            return sabit;
        }

        public async Task DeleteOneSabitAsync(int id)
        {
            var sabit=await _repositoryManager.Sabit.GetByIdAsync(id);
            if (sabit is null)
                throw new Exception($"Sabit with id:{id} could not found.");

            await _repositoryManager.Sabit.DeleteAsync(sabit);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<Sabit>> GetAllSabitAsync()
        {
            return await _repositoryManager.Sabit.GetAllAsync();
        }

        public async Task<Sabit> GetOneSabitAsync(int id)
        {
            return await _repositoryManager.Sabit.GetByIdAsync(id);
        }

        public async Task<Sabit> UpdateOneSabitAsync(int id, Sabit sabit)
        {
            var entity = await _repositoryManager.Sabit.GetByIdAsync(id);
            if(sabit is null) 
                throw new ArgumentNullException( nameof(sabit));
             if (entity is null) 
                throw new Exception($"Sabit with id:{id} could not found.");

             entity.KartKomisyon=sabit.KartKomisyon;
            entity.Yazici=sabit.Yazici;
            entity.AdSoyad=sabit.AdSoyad;
            entity.Unvan=sabit.Unvan;
            entity.Adres=sabit.Adres;
            entity.Telefon=sabit.Telefon;
            entity.Eposta=sabit.Eposta;

            await _repositoryManager.Sabit.UpdateAsync(entity);
            await _repositoryManager.SaveAsync();
            return entity;
        }
    }
}
