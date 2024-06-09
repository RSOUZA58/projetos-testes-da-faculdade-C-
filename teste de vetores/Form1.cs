namespace teste_de_vetores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LstVetor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            lstMatriz.Items.Clear();

            //variáveis para acessar as posições dos índices da matriz
            // linha - representa linha
            // coluna - representa coluna

            int linha, coluna;

            //declara a variável numeros com 5 linhas e 4 colunas

            int[,] numeros = new int[5, 4];    //dimensão da matriz 5 x 4

            for (linha = 0; linha < 5; linha++)
            {
                for (coluna = 0; coluna < 4; coluna++)
                {
                    numeros[linha, coluna] = linha * coluna;  //atribui o valor de linha * coluna
                }
            }

            //exibindo os dados no ListBox

            for (linha = 0; linha < 5; linha++)
            {
                for (coluna = 0; coluna < 4; coluna++)
                {
                    lstMatriz.Items.Add("elemento = " + numeros[linha, coluna]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
