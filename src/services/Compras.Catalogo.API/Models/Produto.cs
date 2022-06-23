using System;
using Compras.Core.DomainObjects;

namespace Compras.Catalogo.API.Models
{
    public class Produto : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal CustoCompra { get; private set; }
        public decimal MargemLucro { get; private set; }

        public decimal PrecoVenda
        {
            get
            {
                var precoVenda = CustoCompra + (CustoCompra * MargemLucro / 100);

                return precoVenda;
            }
        }

        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Imagem { get; set; }
    }
}