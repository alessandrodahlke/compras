using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Compras.Clientes.API.Services;
using Compras.Core.Utils;
using Compras.MessageBus;

namespace Compras.Clientes.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                .AddHostedService<RegistroClienteIntegrationHandler>();
        }
    }
}