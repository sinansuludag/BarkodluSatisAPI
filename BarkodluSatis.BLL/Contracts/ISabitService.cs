using BarkodluSatis.DLL.BarkodDBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface ISabitService
    {
        Task <IEnumerable<Sabit>> GetAllSabitAsync(); 
        Task<Sabit> GetOneSabitAsync(int id);
        Task<Sabit> AddOneSabitAsync(Sabit sabit);
        Task<Sabit> UpdateOneSabitAsync(int id, Sabit sabit);
        Task DeleteOneSabitAsync(int id);
       
    }
}
