namespace mostrar_patas_2
{
    public partial class from1 : Form
    {
        public from1()
        {
            InitializeComponent();
        }

        private void from1_Load(object sender, EventArgs e)
        {
            //limpar os itens adicionados no combobox
            cboAnimais.Items.Clear();

            //adicionar os itens no combobox
            //por meio do metodo add

            cboAnimais.Items.Add("Cavalo");
            cboAnimais.Items.Add("Cachorro");
            cboAnimais.Items.Add("Cobra");
            cboAnimais.Items.Add("Centopeia");
            cboAnimais.Items.Add("Pássaro");
        }

        private void btnPatas_Click(object sender, EventArgs e)
        {
            //declara variável
            String strAnimal;

            //variável recebe o texto do item do ComboBox Selecionado
            strAnimal = cboAnimais.Text;

            //instrução de seleção
            switch (strAnimal)
            {
                case "Cachorro":

                    //carrega o arquivo que está na pasta Debug
                    pctAnimais.Load("cachorro.jpg");
                    break;
                case "Cavalo":
                    pctAnimais.Load("cavalo.jpg");
                    MessageBox.Show("Este aminal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Centopeia":
                    pctAnimais.Load("centopeia.jpg");
                    MessageBox.Show("Este aminal tem 100 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cobra":
                    pctAnimais.Load("cobra.jpg");
                    MessageBox.Show("Este aminal não tem patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                
                case "Pássaro":
                    pctAnimais.Load("passaro.jpg");
                    MessageBox.Show("Este aminal tem 2 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    //limpa o PictureBox
                    pctAnimais.ResetText();
                    MessageBox.Show("Selecione um Animal", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
