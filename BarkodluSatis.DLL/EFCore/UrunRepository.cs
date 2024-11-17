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
    public class UrunRepository : RepositoryBase<Urun>, IUrun
    {
        public UrunRepository(BarkodContextDB context) : base(context)
        {
        }
    }
}
