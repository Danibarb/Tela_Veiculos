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

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_linklabel = new F_LinkLabel();
            f_linklabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.ShowDialog();
        }

        private void Menu_Veículos_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Veículos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() =="toolStripMenuItem_fechar")
            {
                this.Close();
            }
            else if(e.ClickedItem.Name.ToString() == "toolStripMenuItem_restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(e.ClickedItem.Name.ToString() == "toolStripMenuItem_mensagem")
            {
                MessageBox.Show("Mansagem do Notification Icon");
            }
        }

        private void numericUpdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown f_NumericUpDown = new F_NumericUpDown();
            f_NumericUpDown.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox f_PictureBox = new F_PictureBox();
            f_PictureBox.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar f_ProgressBar = new F_ProgressBar();
            f_ProgressBar.ShowDialog();
        }

        private void radioButtonAndGroupBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_RadioButon_GrupBox f_RadioButon_GrupBox = new F_RadioButon_GrupBox();
            f_RadioButon_GrupBox.ShowDialog();
        }
    }
}
