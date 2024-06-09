namespace interface_de_soma
{
    public partial class frmSoma : Form
    {
        public object TextResultado { get; private set; }

        public frmSoma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*declaração de variaveis*/

            int a, b, soma;

            /*entrada de dados*/

            a = Int32.Parse(textA.Text);
            b = Int32.Parse(textB.Text);

            /*processamento*/

            soma = a + b;

            /*saida de dados*/

            textResultado.Text = soma.ToString();



        }

        private void resultadolbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmSoma_Load(object sender, EventArgs e)
        {

        }

        private void btnReais_Click(object sender, EventArgs e)
        {
            /*declarando a variaveis*/

            double a, b, soma;

            /*entrada de dados*/

            a = Convert.ToDouble(textA.Text);
            b = double.Parse(textB.Text);

            /*processamento*/

            soma = a + b;

            /*saida de dados*/

            textResultado.Text = soma.ToString();

        }

        private void textA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
