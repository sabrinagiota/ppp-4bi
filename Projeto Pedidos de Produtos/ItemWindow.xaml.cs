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

        private void inseriritem_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(iditem.Text);
            string descri = descricao.Text;

            Item i = new Item()
            {
                ID = id,
                DescricaoItem = descri,
            };
            if (id != 0 && descri == "")
            {
                NItem.Inserir(i);
                MessageBox.Show("Item Criado.");
                
            }
            else 
                MessageBox.Show("Falta Preencher algo!"); 

        }
    }
}
