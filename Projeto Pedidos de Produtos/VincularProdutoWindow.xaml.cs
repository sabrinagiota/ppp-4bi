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
    /// Lógica interna para VincularProdutoWindow.xaml
    /// </summary>
    public partial class VincularProdutoWindow : Window
    {
        public VincularProdutoWindow()
        {
            InitializeComponent();
        }

        private void vincular_Click(object sender, RoutedEventArgs e)
        {
            if (ListaddePedidos.SelectedItem != null && ListadeProdutos.SelectedItem != null)
            {
                Produto pro = (Produto)ListadeProdutos.SelectedItem;
                Pedido p = (Pedido)ListaddePedidos.SelectedItem;
                Item i = NItem.ItensPedido(p);
                NItem.VincularProduto(i, pro);
                NItem.VincularPedido(i, p);

                ItemWindow it = new ItemWindow();
                it.ShowDialog();

                Listarclick_Click(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um cliente e um banco");
            }

        }

        private void Listarclick_Click(object sender, RoutedEventArgs e)
        {
            ListaddePedidos.ItemsSource = null;
            ListaddePedidos.ItemsSource = NPedido.Listar();

            ListadeProdutos.ItemsSource = null;
            ListadeProdutos.ItemsSource = NProduto.Listar();
        }
    }
}
