using System;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void btnMasks_Click(object sender, EventArgs e)
        {
           
            string masks = maskTxt_senha.Text;

            MessageBox.Show(masks);
        }

        private void maskTxt_senha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void cbox_visualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_visualizarSenha.Checked)
            {
                maskTxt_senha.PasswordChar = (char)MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                maskTxt_senha.PasswordChar = (char)MaskFormat.IncludeLiterals;
            }
        }
    }
}
