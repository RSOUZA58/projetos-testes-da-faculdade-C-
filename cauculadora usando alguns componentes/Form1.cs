using Microsoft.Win32.SafeHandles;

namespace cauculadora_usando_alguns_componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textTotal.Clear();  //limpar o text do textbox
            textX.Clear();      //limpar o text do textbox
            textY.Clear();      //limpar o text do textbox
            textX.Focus();      //colocar o foco do cursor no txtX
            rdbSomar.Checked = true;    //deixar selecionado o radiobutton somar


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando uma vari�vel
            double x, y, total;

            //entrada de dados 
            //valida��o de dados

            // verificar se o que foi digitado em txtX e numero. tamb�m faz valida��o se o textX esta vazio.
            if (double.TryParse(textX.Text, out x) == false)
            {
                // adicionar o bot�o ok e o icone de imforma��o no messagebox
                MessageBox.Show("informe umn valor v�lido", "calcular", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textX.Clear(); //limpar o text do textbox
                textX.Focus(); //colocar o foco do cursor no textbox
                return; //sai da sub-rotina, nao executa o codico que esta abaixo
            }
            //verificar  se o que foi digitado em textY e numero.tamb�m faz valida��o se o textY estar vazio.
            if (double.TryParse(textY.Text, out y) == false)
            {
               MessageBox.Show("informe um valor v�lido","calculardora",MessageBoxButtons.OK, MessageBoxIcon.Information);
                textY.Clear();//limpar o text do textbox
                textY.Focus();//colocar o foco do cursor no textbox
                return;//sai da sub-rotina, nao executa o codico que esta abaixo
            }

            //processamento
            //testar na estrutura codicional qual radiobutton esta selecionado

            if (rdbSomar.Checked == true)
            {
                total = x + y;

            }

            else if (rdbSubtrair.Checked)
            { 
                total = x - y;
            }

            else if(rdbMultiplicar.Checked)
            {
                total = x * y;  
             
            }
            else
            {
                //verificar se esta sendo realizado a divis�o por zero
                if(y == 0)
                {
                    textTotal.Text = "divis�o por zero";
                    return;//sair da sub-rotina, n�o executa o codigo que esta abaixo
                }

                total = x / y;  
            }

            // apresentar a saida de dados covertendo para string

            textTotal.Text = total.ToString();  
        }

    }
}
