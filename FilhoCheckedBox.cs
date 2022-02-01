using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class FilhoCheckedBox : Form
    {
        //Criando uma variavel public do tipo FormCheckedBox para armanezar o retorno da application 
        public CheckedBox filhoCheckedBox;
        public FilhoCheckedBox()
        {
            InitializeComponent();
            // Abrindo o form filho com os mesmos checkeds marcados no form pai.

            filhoCheckedBox = Application.OpenForms["CheckedBox"] as CheckedBox;

            cbox_aviao.Checked = filhoCheckedBox.cbox_aviao.Checked;
            cbox_carro.Checked = filhoCheckedBox.cbox_carro.Checked;
            cbox_navio.Checked = filhoCheckedBox.cbox_navio.Checked;
            cbox_onibus.Checked = filhoCheckedBox.cbox_onibus.Checked;
        }

        private void cbox_carro_CheckedChanged(object sender, System.EventArgs e)
        {
            filhoCheckedBox.cbox_carro.Checked = cbox_carro.Checked;
        }

        private void cbox_aviao_CheckedChanged(object sender, System.EventArgs e)
        {
            filhoCheckedBox.cbox_aviao.Checked = cbox_aviao.Checked;
        }

        private void cbox_navio_CheckedChanged(object sender, System.EventArgs e)
        {
            filhoCheckedBox.cbox_navio.Checked = cbox_navio.Checked;
        }

        private void cbox_onibus_CheckedChanged(object sender, System.EventArgs e)
        {
            filhoCheckedBox.cbox_onibus.Checked = cbox_onibus.Checked;
        }
    }
}
