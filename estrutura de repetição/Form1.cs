namespace estrutura_de_repetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            //limpar o listbox
            lstNumeros.Items.Clear();

            //declarando variavel controladora do laço
            int i;

            for (i = 0; i <= 100; i++)
            {
                //acrescentando o valor da variavel i no listbox
                lstNumeros.Items.Add(i);
            }


        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            //limpando o listbox
            lstNumeros.Items.Clear();

            int i = 1;

            while (i <= 100)
            {
                lstNumeros.Items.Add(i);

                i++;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();

            int i = 1;

            do
            {
                //acrescenta o valor da variavel i no lisbox
                lstNumeros.Items.Add(i);

                i++;

            } while (i <= 100);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
        }
    }
}
