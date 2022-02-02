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

        private void bt_novaTela_Click(object sender, EventArgs e)
        {
            Tela_Veiculos novaTelaVeiculos = new Tela_Veiculos(txt_listaVeiculos.Text);

            //Abrindo nova tela
            novaTelaVeiculos.ShowDialog();

        }

        private void checkedBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckedBox checkedBox = new CheckedBox();
            checkedBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckedListBox checkedListBox = new CheckedListBox();
            checkedListBox.ShowDialog();
        }

        private void ComboBox_Click(object sender, EventArgs e)
        {
            ComboBox combobox = new ComboBox();
            combobox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DateTimerPicker dateTime = new Form_DateTimerPicker();
            dateTime.ShowDialog();
        }
    }
}
