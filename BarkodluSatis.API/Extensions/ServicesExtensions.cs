using BarkodluSatis.BLL;
using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.Contracts;
using BarkodluSatis.DLL.EFCore;

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
    }
}
