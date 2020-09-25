using Microsoft.Extensions.DependencyInjection;

namespace DeryaBilisim.Services.Sigortalig.Integration.Standart
{
    public static class SigortaligServiceExtensions
    {
        public static void AddSigortaligService(this IServiceCollection services, string endpoint, string token)
        {
            services.AddSingleton<SigortaligService>(x => new SigortaligService(endpoint, token));
        }
    }
}
