using Compras.Clientes.API.Application.Commands;
using Compras.Clientes.API.Data;
using Compras.Clientes.API.Data.Repository;
using Compras.Clientes.API.Models;
using Compras.Core.Mediator;
using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Compras.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();
        }
    }
}