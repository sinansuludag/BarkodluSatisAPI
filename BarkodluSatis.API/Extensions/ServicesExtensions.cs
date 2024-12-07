using BarkodluSatis.BLL;
using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.BLL.EFCore;
using BarkodluSatis.DLL.BarkodDBObjects;
using BarkodluSatis.DLL.Contracts;
using BarkodluSatis.DLL.EFCore;
using Microsoft.AspNetCore.Identity;

namespace BarkodluSatis.API.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }

        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager,ServiceManager>();
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, IdentityRole>(opt =>
            {
                opt.Password.RequireDigit = true;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireUppercase = true;
                opt.Password.RequiredLength = 6;
                opt.User.RequireUniqueEmail = true;

            }
            ).AddEntityFrameworkStores<BarkodContextDB>()
            .AddDefaultTokenProviders();
            ;
        }
    }
}
