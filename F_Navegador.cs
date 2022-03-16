using System;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class F_Navegador : Form
    {
        string home = null;
        public F_Navegador()
        {
            InitializeComponent();
        }

        public void navegar()
        {
            if (txt_url.Text != "")
            {
                webBrowser1.Navigate(txt_url.Text);
            }
            else
            {
                MessageBox.Show("Digite um endereço válido.");
                txt_url.Focus();
            }
        }

        private void txt_url_TextChanged(object sender, EventArgs e)
        {
            navegar();
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
            navegar();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if(home == null)
            {
                webBrowser1.GoHome();
            }
            else
            {
                webBrowser1.Navigate(home);
            }
            
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            btn_proximo.Enabled = webBrowser1.CanGoForward;
        }

        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            btn_voltar.Enabled = webBrowser1.CanGoBack;
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_perquisar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void btn_definirhome_Click(object sender, EventArgs e)
        {
            home = txt_url.Text;
        }

        private void txt_url_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                navegar();
            }
        }
    }
}
