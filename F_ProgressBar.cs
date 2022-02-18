using System;
using System.Threading;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            if ((int.Parse(txt_valorBar.Text) >= progressBar1.Minimum) & (int.Parse(txt_valorBar.Text) <= progressBar1.Maximum))
                progressBar1.Value = int.Parse(txt_valorBar.Text);
        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(txt_valorBar.Text);

            for(int i = 0; i<= int.Parse(txt_valorBar.Text); i++)
            {
                lbl_countBar.Text = i.ToString();
                progressBar1.Value = i;

                //lbl_countBar.Text = i.ToString();
                //Incluindo um tempo para a execução do ProgressBar
                //Thread.Sleep(200);
            }

        }
    }
}
