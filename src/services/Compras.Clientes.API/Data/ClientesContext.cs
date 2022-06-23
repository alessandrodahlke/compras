using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Compras.Clientes.API.Models;
using Compras.Core.Data;
using Compras.Core.DomainObjects;
using Compras.Core.Mediator;
using Compras.Core.Messages;

namespace Compras.Clientes.API.Data
{
    public sealed class ClientesContext : DbContext, IUnitOfWork
    {
        public ClientesContext(DbContextOptions<ClientesContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClientesContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}