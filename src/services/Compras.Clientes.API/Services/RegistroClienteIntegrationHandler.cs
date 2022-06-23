using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Compras.Clientes.API.Application.Commands;
using Compras.Core.Mediator;
using Compras.Core.Messages.Integration;
using Compras.MessageBus;

namespace Compras.Clientes.API.Services
{
    public class RegistroClienteIntegrationHandler : BackgroundService
    {
        private readonly IMessageBus _bus;
        private readonly IServiceProvider _serviceProvider;

        public RegistroClienteIntegrationHandler(
                            IServiceProvider serviceProvider, 
                            IMessageBus bus)
        {
            _serviceProvider = serviceProvider;
            _bus = bus;
        }

        private void AcionarRespondAsync()
        {
            _bus.RespondAsync<UsuarioRegistradoIntegrationEvent, ResponseMessage>(async request =>
                await RegistrarCliente(request));

            _bus.AdvancedBus.Connected += OnConnect;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            AcionarRespondAsync();
            return Task.CompletedTask;
        }

        private void OnConnect(object s, EventArgs e)
        {
            AcionarRespondAsync();
        }

        private async Task<ResponseMessage> RegistrarCliente(UsuarioRegistradoIntegrationEvent message)
        {
            var clienteCommand = new RegistrarClienteCommand(message.Id, message.Nome, message.Email, message.Cpf);
            ValidationResult sucesso;

            using (var scope = _serviceProvider.CreateScope())
            {
                var mediator = scope.ServiceProvider.GetRequiredService<IMediatorHandler>();
                sucesso = await mediator.EnviarComando(clienteCommand);
            }

            return new ResponseMessage(sucesso);
        }
    }
}