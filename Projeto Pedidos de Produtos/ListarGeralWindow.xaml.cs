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


        private void ListarButton_Click(object sender, RoutedEventArgs e)
        {
            ListPedido.ItemsSource = null;
            ListPedido.ItemsSource = NPedido.Listar();

            ListProduto.ItemsSource = null;
            ListProduto.ItemsSource = NProduto.Listar();

            ListItem.ItemsSource = null;
            ListItem.ItemsSource = NItem.Listar();
        }
    }
}
