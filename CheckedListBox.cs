using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class CheckedListBox : Form
    {
        public CheckedListBox()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_mostraSelecionados_Click(object sender, EventArgs e)
        {
            //Pegar os itens selecionados atraves de foreach
            string txt = "";
            foreach(string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }
            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            //Limpar a lista antes de adiconar novamente

            clb_transportes.Items.Clear();
            
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            //Limpar a lista antes de adiconar novamente

            clb_transportes.Items.Clear();

            //Adicionando novamente a lista de trasnportes

            List<string> transportes = new List<string>();
            transportes.Add("Carro");
            transportes.Add("Onibus");
            transportes.Add("Avião");
            transportes.Add("Navio");
            transportes.Add("Trem");

            clb_transportes.Items.AddRange(transportes.ToArray());
        }

        private void btn_desmarcarItens_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();

            List<string> transportes = new List<string>();
            transportes.Add("Carro");
            transportes.Add("Onibus");
            transportes.Add("Avião");
            transportes.Add("Navio");
            transportes.Add("Trem");

            clb_transportes.Items.AddRange(transportes.ToArray());
        }

        private void btn_adicionarNovoTransporte_Click(object sender, EventArgs e)
        {
            if (txt_AdicionarNovoTransporte.Text != "")
            {
                clb_transportes.Items.Add(txt_AdicionarNovoTransporte.Text);
                txt_AdicionarNovoTransporte.Clear();
                txt_AdicionarNovoTransporte.Focus();
            }
            else if (txt_AdicionarNovoTransporte.Text == "")
            {
                MessageBox.Show("Digite um Veículo para a inclusao.");
                txt_AdicionarNovoTransporte.Focus();
            }
            
        }
    }
}
