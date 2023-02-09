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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto_Pedidos_de_Produtos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FazerPedido_Click(object sender, RoutedEventArgs e)
        {
            PedidoWindow pedid = new PedidoWindow();
            pedid.ShowDialog();
        }

        private void LevarpraListar_Click(object sender, RoutedEventArgs e)
        {
            ListarGeralWindow listgeral = new ListarGeralWindow();
            listgeral.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExcluirWindow excl = new ExcluirWindow();
            excl.ShowDialog();
        }

        private void atualizar_Click(object sender, RoutedEventArgs e)
        {
            AtualizarGeralWindow atualizargeral = new AtualizarGeralWindow();
            atualizargeral.ShowDialog();
        }

        private void inserirproduto_Click(object sender, RoutedEventArgs e)
        {
            ProdutoWindow pro = new ProdutoWindow();
            pro.ShowDialog();
        }

        private void vincular_Click(object sender, RoutedEventArgs e)
        {
            VincularProdutoWindow vincular = new VincularProdutoWindow();
            vincular.ShowDialog();
        }
    }
}
