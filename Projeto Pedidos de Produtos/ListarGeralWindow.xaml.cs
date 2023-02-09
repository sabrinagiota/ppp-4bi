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
            listarpedido.ItemsSource = null;
            listarpedido.ItemsSource = NPedido.Listar();
        }

        private void voltarmenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow vol = new MainWindow();
            vol.ShowDialog();
        }

        private void Listaritens_Click(object sender, RoutedEventArgs e)
        {
            Pedido p = (Pedido)listarpedido.SelectedItem;
            if (p != null) {
                listarItens.ItemsSource = null;
                listarItens.ItemsSource = NItem.ItensPedido(p);
            }
            
        }
        private void listaproduto_Click(object sender, RoutedEventArgs e)
        {
            Item i = (Item)listarItens.SelectedItem;
            if(i != null)
            {
                listarProdutos.ItemsSource = null;
                listarProdutos.ItemsSource = NProduto.produtos(i); 
            }
        }

        private void listarpedido_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listarpedido.SelectedItem != null)
            {
                Pedido p = (Pedido)listarpedido.SelectedItem;
            }
        }

        private void ListarTotal_Click(object sender, RoutedEventArgs e)
        {
            if (listarpedido.SelectedItem != null)
            {
                Pedido p = (Pedido)listarpedido.SelectedItem;
                if (p != null) 
                {

                    listartotal.ItemsSource = null;
                    listartotal.ItemsSource = NPedido.Total(p).ToString(); 
                }
            }
            MessageBox.Show("selecione o Pedido que tenho algo vinculado!");
        }
    }
}
