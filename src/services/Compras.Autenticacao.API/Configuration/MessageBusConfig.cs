using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Compras.Core.Utils;
using Compras.MessageBus;

namespace Compras.Identidade.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"));
        }
    }
}