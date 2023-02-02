using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Projeto_Pedidos_de_Produtos
{
    class NProduto
    {
        private static List<Produto> Produtos = new List<Produto>();

        public static void Inserir(Produto pro)
        {
            Abrir();
            Produtos.Add(pro);
            Salvar();
        }
        public static List<Produto> Listar()
        {
            Abrir();
            return Produtos;
        }
        public static Produto Listar(int id)
        {
            foreach (Produto obj in Produtos)
                if (obj.IdProduto == id) return obj;
            return null;
        }
        public static void Atualizar(Produto pro)
        {
            Abrir();
            Produto obj = Listar(pro.IdProduto);
            if (obj != null)
            {
                obj.NomeProduto = pro.NomeProduto;
                obj.Fornecedor = pro.Fornecedor;
                obj.Preco = pro.Preco;
            }
            Salvar();
        }
        public static void Excluir(Produto pro)
        {
            Abrir();
            Produtos.Remove(Listar(pro.IdProduto));
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Produto>));
                f = new StreamReader("./Produtos.xml");
                Produtos = (List<Produto>)xml.Deserialize(f);
            }
            catch
            {
                Produtos = new List<Produto>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Produto>));
            StreamWriter f = new StreamWriter("./Produtos.xml", false);
            xml.Serialize(f, Produtos);
            f.Close();
        }
    }
}
