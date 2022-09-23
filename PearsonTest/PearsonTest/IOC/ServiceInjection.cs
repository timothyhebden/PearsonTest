using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PearsonTest.Logic.Interfaces.Services;
using PearsonTest.Logic.Services;

namespace PearsonTest.IOC
{
    public static class ServiceInjection
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPalindromesService, PalindromesService>();
            services.AddScoped<ICoinChangeService, CoinChangeService>();
        }
    }
}
