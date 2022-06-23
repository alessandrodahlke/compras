using System;

namespace Compras.WebApp.MVC.Models
{
    public class ProdutoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal CustoCompra { get; set; }
        public decimal MargemLucro { get; set; }

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