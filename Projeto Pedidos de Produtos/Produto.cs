using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pedidos_de_Produtos
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Fornecedor { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return $"{IdProduto} - {NomeProduto} - {Fornecedor} - {Preco}";
        }
    }
}
