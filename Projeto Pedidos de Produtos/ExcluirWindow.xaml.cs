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
    /// Lógica interna para ExcluirWindow.xaml
    /// </summary>
    public partial class ExcluirWindow : Window
    {
        public ExcluirWindow()
        {
            InitializeComponent();
        }

        private void ExPedido_Click(object sender, RoutedEventArgs e)
        {
            int excluirpedido = int.Parse(IdExcluir.Text);

            Pedido p = new Pedido()
            {
                IdPedido = excluirpedido
            };

            NPedido.Excluir(p);
            MessageBox.Show("Pedido excluido com sucesso!");
        }

        private void ExItem_Click(object sender, RoutedEventArgs e)
        {
            int excluirItem = int.Parse(IdExcluir.Text);

            Item i = new Item()
            {
                ID = excluirItem
            };

            NItem.Excluir(i);
            MessageBox.Show("Item excluido com sucesso!");
        }

        private void ExProduto_Click(object sender, RoutedEventArgs e)
        {
            int excluirproduto = int.Parse(IdExcluir.Text);

            Produto pro = new Produto()
            {
                IdProduto = excluirproduto
            };

            NProduto.Excluir(pro);
            MessageBox.Show("Produto excluido com sucesso!");
        }
    }
}
