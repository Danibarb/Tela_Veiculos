using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class F_ListBox : Form
    {
        //Criando uma lista para inicializar o ListBox
        List<string> Carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();

            //Incluindo os elementos do ListBox Carros, dentro do construtor
            Carros.Add("Golf");
            Carros.Add("Subaru");
            Carros.Add("Camaro");

            //Inserindo a lista de Carros dentro do ListBox
            listB_Carros.DataSource = Carros;
        }

        private void F_ListBox_Load(object sender, EventArgs e)
        {

        }

        private void listB_Carros_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(txt_Carros.Text == "")
            {
                MessageBox.Show("Digite um automóvel para incluir na lista.");
                txt_Carros.Focus();
            }
            else
            {
                //adicionando o carro digitado na Lista Carros
                Carros.Add(txt_Carros.Text);
                txt_Carros.Clear();
                listB_Carros.DataSource = null;
                //Imprimindo o Carro digitado no TextBox dentro do ListBox
                listB_Carros.DataSource = Carros;
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            //Removendo o carro de acordo com seu indice na lista
            Carros.RemoveAt(listB_Carros.SelectedIndex);
            listB_Carros.DataSource = null;
            listB_Carros.DataSource = Carros;
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            //Obtendo o Carro selecionado no listBox, e incluindo-o no TextBox
            txt_Carros.Text = Carros[listB_Carros.SelectedIndex];
        }
    }
}
