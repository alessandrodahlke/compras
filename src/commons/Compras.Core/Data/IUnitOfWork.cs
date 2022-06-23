using System.Threading.Tasks;

namespace Compras.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}