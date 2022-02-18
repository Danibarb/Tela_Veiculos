using System;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void F_NumericUpDown_Load(object sender, EventArgs e)
        {

        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            if((decimal.Parse(txt_valor.Text)>= numUpDown.Minimum) & (Decimal.Parse(txt_valor.Text)<= numUpDown.Maximum)){
                numUpDown.Value = Decimal.Parse(txt_valor.Text);
            }
        }
    }
}
