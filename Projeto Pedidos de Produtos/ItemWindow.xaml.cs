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
    /// Lógica interna para ItemWindow.xaml
    /// </summary>
    public partial class ItemWindow : Window
    {
        public ItemWindow()
        {
            InitializeComponent();
        }

        private void cadastraritem_Click(object sender, RoutedEventArgs e)
        {
            int Iditem = int.Parse(iditem.Text);
            int idprod = int.Parse(idproduto.Text);
            string desc = descricao.Text;
            string nomeprod = nomeproduto.Text;
            string forn = fornecedor.Text;
            double preco = double.Parse(pre.Text);

            Item i = new Item()
            {
                ID = Iditem,
                DescricaoItem = desc
            };
            Produto pro = new Produto()
            {
                IdProduto = idprod,
                NomeProduto = nomeprod,
                Fornecedor = forn,
                Preco = preco
            };

            NItem.Inserir(i);
            NProduto.Inserir(pro);

            //NItem.Vincular(i, pro, p);

        }

        private void voltarmenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.ShowDialog();
        }
    }
}
