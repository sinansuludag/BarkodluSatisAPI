using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface IServiceManager
    {
        IBarkodService BarkodService { get; }   
    }
}
