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
    /// Lógica interna para ProdutoWindow.xaml
    /// </summary>
    public partial class ProdutoWindow : Window
    {
        public ProdutoWindow()
        {
            InitializeComponent();
        }

        private void inserirproduto_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(idproduto.Text);
            double prec = double.Parse(pre.Text);
            string nome = nomeproduto.Text;
            string forn = fornecedor.Text;

            Produto pro = new Produto()
            {
                IdProduto = id,
                Fornecedor = forn,
                NomeProduto = nome,
                Preco = prec
            };

            NProduto.Inserir(pro);

            MessageBox.Show("Produto Cadastrado no sistema.");
        }
    }
}
