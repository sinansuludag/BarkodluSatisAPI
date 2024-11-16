using BarkodluSatis.DLL.BarkodDBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface ITeraziService
    {
        Task<IEnumerable<Terazi>> GetAllTeraziAsync();
        Task<Terazi> GetOneTeraziAsync(int id);
        Task<Terazi> AddOneTeraziAsync(Terazi terazi);
        Task<Terazi> UpdateOneTeraziAsync(int id, Terazi terazi);   
        Task DeleteOneTeraziAsync(int id);
    }
}
