using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projeto_Pedidos_de_Produtos
{
    /// <summary>
    /// Lógica interna para ItemEProdutoWindow.xaml
    /// </summary>
    public partial class ItemEProdutoWindow : Window
    {
        public ItemEProdutoWindow()
        {
            InitializeComponent();
        }

        private void cadastraritem_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(iditem.Text);
            int idprod = int.Parse(idproduto.Text);
            string desc = descricao.Text;
            string nomeprod = nomeproduto.Text;
            string forn = fornecedor.Text;
            double preco = double.Parse(pre.Text);

            Item i = new Item()
            {
                ID = id,
                DescricaoItem = desc
            };
            Produto pro = new Produto()
            {
                IdProduto = idprod,
                NomeProduto = nomeprod,
                Fornecedor = forn,
                Preco = preco
            };

            NItem.Inserir(i);
            NProduto.Inserir(pro);

            listaitem.ItemsSource = null;
            listaitem.ItemsSource = NItem.Listar();

            listaprodutos.ItemsSource = null;
            listaprodutos.ItemsSource = NProduto.Listar();
            //NItem.Vincular(i, pro, p);

        }

        private void voltarmenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.ShowDialog();
        }
    }
}
