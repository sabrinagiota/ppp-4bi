using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto_Pedidos_de_Produtos
{
    static class NPedido
    {
        private static List<Pedido> Pedidos = new List<Pedido>();

        public static void Inserir(Pedido p)
        {
            Abrir();
            Pedidos.Add(p);
            Salvar();
        }
        public static List<Pedido> Listar()
        {
            Abrir();
            return Pedidos;
        }
        public static Pedido Listar(int id)
        {
            foreach (Pedido obj in Pedidos)
                if (obj.IdPedido == id) return obj;
            return null;
        }
        public static void Atualizar(Pedido p)
        {
            Abrir();
            Pedido obj = Listar(p.IdPedido);
            if (obj != null)
            {
                obj.DataCriacao = p.DataCriacao;
                obj.DataEnvio = p.DataEnvio;
                obj.NomeUsuario = p.NomeUsuario;
                obj.StatusPedido = p.StatusPedido;
                obj.Total = p.Total;
            }
            Salvar();
        }
        public static void Excluir(Pedido p)
        {
            Abrir();
            Pedidos.Remove(Listar(p.IdPedido));
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Pedido>));
                f = new StreamReader("./Pedidos.xml");
                Pedidos = (List<Pedido>)xml.Deserialize(f);
            }
            catch
            {
                Pedidos = new List<Pedido>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Pedido>));
            StreamWriter f = new StreamWriter("./Pedidos.xml", false);
            xml.Serialize(f, Pedidos);
            f.Close();
        }
    }
}
