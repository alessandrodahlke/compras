using System.Linq;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Compras.Carrinho.API.Model;

namespace Compras.Carrinho.API.Data
{
    public sealed class CarrinhoContext : DbContext
    {
        public CarrinhoContext(DbContextOptions<CarrinhoContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<CarrinhoItem> CarrinhoItens { get; set; }
        public DbSet<CarrinhoCliente> CarrinhoCliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarrinhoContext).Assembly);
        }
    }
}