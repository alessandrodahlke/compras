using Compras.Carrinho.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compras.Carrinho.API.Data.Mappings
{
    public class CarrinhoClienteMapping : IEntityTypeConfiguration<CarrinhoCliente>
    {
        public void Configure(EntityTypeBuilder<CarrinhoCliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.Itens)
                .WithOne(i => i.CarrinhoCliente)
                .HasForeignKey(c => c.CarrinhoId);

            builder.ToTable("CarrinhoCliente");
        }
    }
}
