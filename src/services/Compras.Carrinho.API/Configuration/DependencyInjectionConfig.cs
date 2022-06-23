using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Compras.Carrinho.API.Data;
using Compras.WebAPI.Core.Usuario;

namespace Compras.Carrinho.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();
            services.AddScoped<CarrinhoContext>();
        }
    }
}