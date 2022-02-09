using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();

            //Construtor de Multiplos Links
            multiplosLinks.Links.Add(0,6,"www.google.com.br");
            multiplosLinks.Links.Add(9,7,"http://youtube.com/cfbcursos");
            multiplosLinks.Links.Add(19,5,"www.globo.com");
        }

        private void linkL_Youtube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abrir a URL do Youtube
            System.Diagnostics.Process.Start("http://youtube.com/cfbcursos");
        }

        private void linkL_Excel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abrir o Excel
            System.Diagnostics.Process.Start("excel.exe");
        }

        private void linkL_Calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abrir a Calculadora
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Chamando o Link clicado e convertendo em String
            System.Diagnostics.Process.Start(txt_Nome + e.Link.LinkData.ToString());
        }
    }
}
