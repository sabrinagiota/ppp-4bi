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
    /// Lógica interna para AtualizarGeralWindow.xaml
    /// </summary>
    public partial class AtualizarGeralWindow : Window
    {
        public AtualizarGeralWindow()
        {
            InitializeComponent();
        }

        private void attpedido_Click(object sender, RoutedEventArgs e)
        {
            int idpedido = int.Parse(idpedidotext.Text);
            string nomeusuario = nomeusuariotext.Text;
            string datacriacao = datacriacaotext.Text;
            string dataenvio = dataenviotext.Text;
            string status = combostatus.Text;

            Pedido p = new Pedido();
            p.IdPedido = idpedido;
            p.NomeUsuario = nomeusuario;
            p.DataCriacao = datacriacao;
            p.DataEnvio = dataenvio;
            p.StatusPedido = status;

            NPedido.Atualizar(p);

            MessageBox.Show("Pedido Atualizado com sucesso!");
        }

        private void attitem_Click(object sender, RoutedEventArgs e)
        {
            int iditem = int.Parse(iditemtext.Text);
            string descricao = descricaotext.Text;

            Item i = new Item();
            i.ID = iditem;
            i.DescricaoItem = descricao;

            NItem.Atualizar(i);
            MessageBox.Show("Item Atualizado com sucesso!");
        }

        private void attproduto_Click(object sender, RoutedEventArgs e)
        {
            int idproduto = int.Parse(idprodutotext.Text);
            string nomeproduto = nomeprodutotext.Text;
            string fornecedor = fornecedortext.Text;
            double preco = double.Parse(precotext.Text);

            Produto pro = new Produto();
            pro.IdProduto = idproduto;
            pro.NomeProduto = nomeproduto;
            pro.Fornecedor = fornecedor;
            pro.Preco = preco;

            NProduto.Atualizar(pro);
            MessageBox.Show("Produto Atualizado com sucesso!");
        }
    }
}
