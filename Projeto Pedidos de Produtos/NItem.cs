﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Projeto_Pedidos_de_Produtos
{
    static class NItem
    {
        private static List<Item> Itens = new List<Item>();

        public static void Inserir(Item i)
        {
            Abrir();
            Itens.Add(i);
            Salvar();
        }
        public static List<Item> Listar()
        {
            Abrir();
            return Itens;
        }
        public static Item Listar(int id)
        {
            foreach (Item obj in Itens)
                if (obj.ID == id) return obj;
            return null;
        }
        public static Produto ProdutodoItem(Item i)
        {
            foreach (Item obj in Itens)
            {
                if (obj.IdProduto == i.ID)
                {
                    return NProduto.Listar(i.ID);
                }
            }
            return null;
        }
        public static Item ItensPedido(Pedido p)
        {
            foreach (Item obj in Itens)
            {
                if (obj.IdPedido == p.IdPedido)
                {
                    return obj;
                }
            }
            return null;
        }
        public static Pedido PedidodoItem(Item i)
        {
            foreach (Item obj in Itens)
            {
                if (obj.IdPedido == i.IdPedido)
                {
                    return NPedido.Listar(i.IdPedido);
                }
                
            }
            return null;
        }
        public static void Atualizar(Item i)
        {
            Abrir();
            Item obj = Listar(i.ID);
            if (obj != null)
            {
                obj.DescricaoItem = i.DescricaoItem;
            }
            Salvar();
        }
        public static void Excluir(Item i)
        {
            Abrir();
            Itens.Remove(Listar(i.ID));
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Item>));
                f = new StreamReader("./Itens.xml");
                Itens = (List<Item>)xml.Deserialize(f);
            }
            catch
            {
                Itens = new List<Item>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Item>));
            StreamWriter f = new StreamWriter("./Itens.xml", false);
            xml.Serialize(f, Itens);
            f.Close();
        }
        public static void VincularPedido(Item i, Pedido p)
        {
            i.IdPedido = p.IdPedido;
            Atualizar(i);
        }
        public static void VincularProduto(Item i, Produto pro)
        {
            i.IdProduto = pro.IdProduto;
            Atualizar(i);
        }
    }
}
