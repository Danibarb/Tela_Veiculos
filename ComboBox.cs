using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbx_transportes.Text);
        }

        private void btn_LimparComboBox_Click(object sender, EventArgs e)
        {
            cbx_transportes.Items.Clear();
        }

        private void btn_ResetarComboBox_Click(object sender, EventArgs e)
        {
            //Limpando a lista
            cbx_transportes.Items.Clear();

            //Criando uma lista de transportes para serem resetados
            List<string> comboboxlist = new List<string>();
            comboboxlist.Add("Carro");
            comboboxlist.Add("Avião");
            comboboxlist.Add("Navio");
            comboboxlist.Add("Onibus");
            comboboxlist.Add("Trem");

            //Povoando o combobox com a lista criada acima
            cbx_transportes.Items.AddRange(comboboxlist.ToArray());

        }

        private void cbx_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pegando o transporte selecionado no ComboBox para ser apresentado no txtBox
            txt_Transporte.Text = cbx_transportes.Text;
        }

        private void btn_NovoTransporte_Click(object sender, EventArgs e)
        {
            //Verificando se o campo esttá em branco
            if(txt_Transporte.Text !="")
            {
                // Conferindo se o veiculo a ser inserido já existe
                if (cbx_transportes.FindString(txt_Transporte.Text)<0)
                    cbx_transportes.Items.Add(txt_Transporte.Text);
                else MessageBox.Show("Esse Veículo já existe.");
            }

        }
    }
}
