using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Compras.Catalogo.API.Models;

namespace Compras.Catalogo.API.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(50);

            builder.Property(p => p.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(200);

            builder.Property(p => p.CustoCompra)
                    .HasColumnType("decimal(15,2)");

            builder.Property(p => p.MargemLucro)
                    .HasColumnType("decimal(15,2)");

            builder.ToTable("Produtos");
        }
    }
}