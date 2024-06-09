namespace projeto_parâmetro_por_valor_e_por_referência
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //implementação da sub-rotinas

        void porValor(double varA, double varB)
        {
            //alterar o valor das variáveis locais que são passada por valor 
            //não altera os valores das variáveis originais (declaradas no botão por valor)
            //essa alterações são válidas somente dentro deste escopo

            varA = varA * 2;
            varB = varB * 5;
        }
        void porReferencia(ref double varA, ref double varB)
        {
            varA = varA * 2;
            varB = varB * 5;

        }
        void LimparControles()
        {
            //limpa os textos dos controles
            txtResA.Clear();
            txtResB.Clear();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            //declaração das variáveis original
            double varA, varB;

            //entrada de dados
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            //chama o procedimento por valor passando os parâmetro por valor,
            //ou seja,e passada um copia das variáveis
            porValor(varA, varB);

            // chamando o procedimento para limpar os controles
            LimparControles();

            //saida de dados para verificar que não houve alteação no valor da variável original
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            //declaração das variáveis originais
            double varA, varB;

            //entrada de dados

            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            //chamando o procedimento porReferencia passando os parâmetros por referência
            porReferencia(ref varA, ref varB);

            //chama o procedimento para limpar os controles
            LimparControles();

            //saida de dados para verificar a alteração no valor da variável original
            //os valores das variáveis foram alterados no procedimento
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();




        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            LimparControles();
        }
    }
}
