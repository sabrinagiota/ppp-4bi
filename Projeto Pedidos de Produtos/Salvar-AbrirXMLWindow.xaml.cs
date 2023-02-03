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
    /// Lógica interna para Salvar_AbrirXMLWindow.xaml
    /// </summary>
    public partial class Salvar_AbrirXMLWindow : Window
    {
        public Salvar_AbrirXMLWindow()
        {
            InitializeComponent();
        }

        private void Salvarpedido_Click(object sender, RoutedEventArgs e)
        {
            NPedido.Salvar();
        }

        private void SalvarItem_Click(object sender, RoutedEventArgs e)
        {
            NItem.Salvar();
        }

        private void SalvarProduto_Click(object sender, RoutedEventArgs e)
        {
            NProduto.Salvar();
        }

        private void AbrirPedido_Click(object sender, RoutedEventArgs e)
        {
            NPedido.Abrir();
        }

        private void AbrirItem_Click(object sender, RoutedEventArgs e)
        {
            NItem.Abrir();
        }

        private void AbrirProduto_Click(object sender, RoutedEventArgs e)
        {
            NProduto.Abrir();
        }
    }
}
