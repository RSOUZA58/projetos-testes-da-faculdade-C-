namespace somar_pares__estrutura_de_repetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSoma_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando variaveis

            int i, num, soma = 0;

            //entrada de dados - atribuir a num o valor do txtnum

            num = Convert.ToInt32(txtNum.Text);

            //iniciando o laço em 1;
            //testa a condição de parada : i <= num
            //incrementa a variavel i++

            for (i = 1; i <= num; i++)
            {
                //verificar se i e par

                if (i % 2 == 0)
                {
                    //faz o somatoria dos numeros pares


                    soma = soma + i;


                }
            }
            //apresentar o total da soma dos pares no txtSoma

            txtSoma.Text = soma.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpa os textbox

            txtSoma.Clear();
            txtNum.Clear();
            //colocar o foco no txtNum
            txtNum.Focus();

        }
    }
}
