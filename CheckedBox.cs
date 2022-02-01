using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class CheckedBox : Form
    {
        //Criando lista para receber os veiculos marcados
        List<CheckBox> transportes = new List<CheckBox>();

        public CheckedBox()
        {
            InitializeComponent();

            //Adicionado os trasnportes à lista criada acima
            
            transportes.Add(cbox_aviao);
            transportes.Add(cbox_carro);
            transportes.Add(cbox_onibus);
            transportes.Add(cbox_navio);
        }

        private void btn_trasportesMarcados_Click(object sender, EventArgs e)
        {
            //Mostrando qual checkBox está marcado, através de IF

            string txt = "";
            // Percorrendo a lista
            foreach(CheckBox t in transportes)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }
            MessageBox.Show(txt);
        }

        private void btn_forFilho_Click(object sender, EventArgs e)
        {
            //Instanciando a classe FilhoCheckedBox

            FilhoCheckedBox filhoCheckedBox = new FilhoCheckedBox();

            //Abrindo o form filho
            filhoCheckedBox.ShowDialog();
        }
    }
}
