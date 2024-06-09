namespace dias_da_semana
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

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDiaSemana.ResetText();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int dia;

            dia = Convert.ToInt32(txtDia.Text);

            switch (dia)
            {
                case 1:
                    lblDiaSemana.Text = "Domingo";
                    break;

                case 2:
                    lblDiaSemana.Text = "Segunda-feira";
                    break;
                case 3:
                    lblDiaSemana.Text = "Terça-feira";
                    break;
                case 4:
                    lblDiaSemana.Text = "Quarta-feira";
                    break;
                case 5:
                    lblDiaSemana.Text = "Quinta-feira";
                    break;
                case 6:
                    lblDiaSemana.Text = "Sexta-feira";
                    break;
                case 7:
                    lblDiaSemana.Text = "Sábado-feira";
                    break;
                default:
                    lblDiaSemana.Text = "Dia inválido";
                    break;

            }


        }

        private void lblDiaSemana_Click(object sender, EventArgs e)
        {

        }
    }
}
