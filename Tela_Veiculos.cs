using System;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class Tela_Veiculos : Form
    {
        public Tela_Veiculos(string v)
        {
            InitializeComponent();
            txt_listaVeiculos.Text = v;
        }

        private void listVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NovaTelaVeiculos_Load(object sender, EventArgs e)
        {

        }

        private void txtNovaListaVeiculos_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbox_transportes.Text);
        }*/
    }
}
