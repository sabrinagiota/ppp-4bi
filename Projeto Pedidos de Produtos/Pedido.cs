using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto_Pedidos_de_Produtos
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public double Total { get; set; }

        public string DataCriacao { get; set; }
        public string DataEnvio { get; set; }
        public string NomeUsuario { get; set; }
        public string StatusPedido { get; set; }

        public override string ToString()
        {
            return $"{IdPedido} - {DataCriacao} - {DataEnvio} - {NomeUsuario} - {StatusPedido} - {Total}";
        }
    }
}
