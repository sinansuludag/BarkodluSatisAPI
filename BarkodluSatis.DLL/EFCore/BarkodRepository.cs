using BarkodluSatis.BLL.EFCore;
using BarkodluSatis.DLL.BarkodDBObjects;
using BarkodluSatis.DLL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.DLL.EFCore
{
    public class BarkodRepository : RepositoryBase<Barkod>,IBarkodRepository
    {
        public BarkodRepository(BarkodContextDB context) : base(context)
        {

        }
    }
}
