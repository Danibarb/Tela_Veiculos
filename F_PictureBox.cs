using System;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.NomeCanal;
            label2.Text = Properties.Resources.EnderecoCanal;
        }

        private void btn_logo1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.veiculos_curso;
        }

        private void btn_logo2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.logo2;
        }
    }
}
