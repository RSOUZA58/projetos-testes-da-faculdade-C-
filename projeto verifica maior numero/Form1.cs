namespace projeto_verifica_maior_numero

{
    public partial class Form1 : Form
    {
        //declarando e implementa��o da fun��o
        int verificarMaior(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }


        }
        //declara��o e implementa��o  do procedimento para limpar os controles
        //o tipo de retorno e void,ou seja,nao tem retorno

        void Limparcontroles()
        {
            //limpar o conteudo dos controles

            txtA.Clear();
            txtB.Clear();
            txtMaior.Clear();
            txtA.Focus();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //declarando a vari�veis
            int a, b;

            //entrada de dados para as vari�veis

            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);

            //chamando a fun��o verificarMaior
            //e passando os argumentos para os par�metros num1,num2
            //txtbox txtMaior recebe o retorno da fun��o

            txtMaior.Text = verificarMaior(a, b).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //chama o procedimento limparcontroles

            Limparcontroles();
        }
    }

}
