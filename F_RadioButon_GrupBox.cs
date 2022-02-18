using System;
using System.Linq;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class F_RadioButon_GrupBox : Form
    {
        public F_RadioButon_GrupBox()
        {
            InitializeComponent();
        }

        private void btn_selecionado_Click(object sender, EventArgs e)
        {
            //Verificando radio selecionado através de metodos do próprio RadioButton
            string txtbox = " ";
            string txtbox2 = " ";
            txtbox = groupB_transportes.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            txtbox2 = groupB_quantidade.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            txt_selecionado.Text = txtbox + "= " + txtbox2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificando o radio selecionado atraves de foreach
            string txtbox = " ";
            string txtbox2 = " ";

            foreach(RadioButton selec in groupB_transportes.Controls)
            {
                if (selec.Checked)
                {
                    txtbox = selec.Text;
                }
            }
            foreach (RadioButton selec2 in groupB_quantidade.Controls)
            {
                if (selec2.Checked)
                {
                    txtbox2 = selec2.Text;
                }
            }
            txt_selecionado.Text = txtbox + "= " + txtbox2;
        }
    }
}
