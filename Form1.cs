using System;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class CheckdListBox : Form
    {
        public CheckdListBox()
        {
            InitializeComponent();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            if(txt_veiculos.Text == "")
            {
                MessageBox.Show("Não há nenhum carro para ser adicionado. Favor inserir um veículo. ");
                txt_veiculos.Focus();
                return;
            }
            txt_listaVeiculos.Text += txt_veiculos.Text + ", ";
            txt_veiculos.Clear();
            txt_veiculos.Focus();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            txt_listaVeiculos.Clear();
        }
    }
}
