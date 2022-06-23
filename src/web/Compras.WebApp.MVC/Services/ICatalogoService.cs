using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Compras.WebApp.MVC.Models;

namespace Compras.WebApp.MVC.Services
{
    public interface ICatalogoService
    {
        Task<IEnumerable<ProdutoViewModel>> ObterTodos();
        Task<ProdutoViewModel> ObterPorId(Guid id);
    }
}