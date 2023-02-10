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
                Item i = (Item)listaitens.SelectedItem;
                {
                    NItem.VincularProduto(i, pro);

                    NItem.VincularPedido(i, p);

                    MessageBox.Show("Produto Vinculado");
                }
            }
            else
            {
                MessageBox.Show("É preciso selecionar um Pedido, um Item e um Produto");
            }

        }

        private void Listarclick_Click(object sender, RoutedEventArgs e)
        {
            ListaddePedidos.ItemsSource = null;
            listaitens.ItemsSource = null;
            ListadeProdutos.ItemsSource = null;

            ListaddePedidos.ItemsSource = NPedido.Listar();
            ListadeProdutos.ItemsSource = NProduto.Listar();
            listaitens.ItemsSource = NItem.Listar();
        }

        private void ContinuarVinculandoItem_Click(object sender, RoutedEventArgs e)
        {
            ItemWindow it = new ItemWindow();
            it.ShowDialog();
        }

        private void VoltaraoMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.ShowDialog();
        }
    }
}
