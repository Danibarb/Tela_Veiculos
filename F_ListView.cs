using System;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txt_id.Clear();
            txt_produto.Clear();
            txt_quantidade.Clear();
            txt_preco.Clear();
            txt_id.Focus();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            //Verificando campos não preenchidos
            if((txt_id.Text == "")||(txt_produto.Text =="") || (txt_quantidade.Text =="") || (txt_preco.Text == ""))
            {
                MessageBox.Show("Todos os campos Precisam ser preenchidos. Reveja os campos.");
                txt_id.Focus();
                return;
            }
            //Criando Array para receber os dados dos Produtos do ListView
            string[] listaProdutos = new string[4];
            listaProdutos[0] = txt_id.Text;
            listaProdutos[1] = txt_produto.Text;
            listaProdutos[2] = txt_quantidade.Text;
            listaProdutos[3] = txt_preco.Text;

            //Criando o ListViewItem Lista, recebendo os dados do Array ListaProdutos
            ListViewItem linha = new ListViewItem(listaProdutos);
            listV_Produtos.Items.Add(linha);

            Limpar();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            //Removendo o Item selecionado
            listV_Produtos.Items.RemoveAt(listV_Produtos.SelectedIndices[0]);
        }
    }
}
