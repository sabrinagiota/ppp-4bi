using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Pedidos_de_Produtos
{
    public class Item
    {
        public int ID { get; set; }
        public string DescricaoItem { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public override string ToString()
        {
            return $"{ID} - {IdProduto} - {IdPedido} - {DescricaoItem}";
        }
    }
}
