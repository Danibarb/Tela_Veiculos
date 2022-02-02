using System;
using System.Windows.Forms;

namespace Tela_Veiculos
{
    public partial class Form_DateTimerPicker : Form
    {
        public Form_DateTimerPicker()
        {
            InitializeComponent();
        }

        private void btn_ObterData_Click(object sender, EventArgs e)
        {
            //Pegando a data completa do Date Time Picker e preenchendo no txt_DataCompleta
            txt_DataCompleta.Text = dtp_Data.Text;

            //Pegando apenas o Valor Dia do Date Time
            txt_Dia.Text = dtp_Data.Value.Day.ToString();

            //Pegando apenas o mês do Date Time
            txt_Mes.Text = dtp_Data.Value.Month.ToString();

            //Pegando apenas o Ano do Date Time
            txt_Ano.Text = dtp_Data.Value.Year.ToString();

        }

        private void btn_SetarData_Click(object sender, EventArgs e)
        {
            //Variaveis para armazenar a data digitada nos textsBox
            int dia, mes, ano;

            //Recebendo e convertendo os dados digitados nos campos Dia Mes e Ano, em inteiro
            dia = Int32.Parse(txt_Dia.Text);
            mes = Int32.Parse(txt_Mes.Text);
            ano = Int32.Parse(txt_Ano.Text);

            //Convertendo a data em tipo DateTime
            DateTime dt = new DateTime(ano, mes, dia);

            //DateTimerPicker, recebendo a data digitada nos campos de data para setar.
            dtp_Data.Value = dt;

        }

        private void btn_DataAtual_Click(object sender, EventArgs e)
        {
            //Pegando a data atual e setando no DateTimePicker
            dtp_Data.Value = DateTime.Today;

            //Pegando a data atual e setando no campo txt_DataCompleta
            txt_DataCompleta.Text = DateTime.Now.ToString();
        }
    }
}
