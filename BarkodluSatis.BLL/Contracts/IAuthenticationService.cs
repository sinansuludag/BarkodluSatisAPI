using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.BLL.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(User user);
    }
}
