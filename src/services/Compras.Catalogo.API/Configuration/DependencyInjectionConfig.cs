using Microsoft.Extensions.DependencyInjection;
using Compras.Catalogo.API.Data;
using Compras.Catalogo.API.Data.Repository;
using Compras.Catalogo.API.Models;

namespace Compras.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}