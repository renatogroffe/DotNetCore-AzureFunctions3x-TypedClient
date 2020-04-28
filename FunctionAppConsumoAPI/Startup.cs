using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using FunctionAppConsumoAPI.Clients;

[assembly: FunctionsStartup(typeof(FunctionAppConsumoAPI.Startup))]
namespace FunctionAppConsumoAPI
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient<APIContagemClient>();
        }
    }
}