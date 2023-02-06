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
    /// Lógica interna para ListarGeralWindow.xaml
    /// </summary>
    public partial class ListarGeralWindow : Window
    {
        public ListarGeralWindow()
        {
            InitializeComponent();
        }

        int id = 0;

        private void ListarButton_Click(object sender, RoutedEventArgs e)
        {
            listarpedido.ItemsSource = null;
            listarpedido.ItemsSource = NPedido.Listar();
        }

        private void voltarmenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow vol = new MainWindow();
            vol.ShowDialog();
        }

        private void listarpedido_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listarpedido.SelectedItem != null)
            {
                Pedido p = (Pedido)listarpedido.SelectedItem;
                id = p.IdPedido;
            }
        }

        private void Listaritens_Click(object sender, RoutedEventArgs e)
        {
            listarItens.ItemsSource = null;
            listarItens.ItemsSource = NItem.ListarPedido(id);

        }

        private void listarItens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listarItens.SelectedItem != null)
            {
                Item i = (Item)listarItens.SelectedItem;
                id = i.ID;
            }
        }

        private void listaproduto_Click(object sender, RoutedEventArgs e)
        {
            listarProdutos.ItemsSource = null;
            listarProdutos.ItemsSource = NItem.ListarProduto(id);
        }
    }
}
