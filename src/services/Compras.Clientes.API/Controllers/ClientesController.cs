using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Compras.Clientes.API.Application.Commands;
using Compras.Core.Mediator;
using Compras.WebAPI.Core.Controllers;

namespace Compras.Clientes.API.Controllers
{
    public class ClientesController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;

        public ClientesController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var resultado = await _mediatorHandler.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(), "Alessandro", "a@a.com", "30314299076"));

            return CustomResponse(resultado);
        }
    }
}