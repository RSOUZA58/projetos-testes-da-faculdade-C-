namespace mostrando_animais_com_patas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(GetBtnPatas());
        }

        private void cboAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // limpar os intens adicionados no combobox
            cboAnimais.Items.Clear();

            //adicionar os itens no combobox
            //por meio de metodo Add()

            cboAnimais.Items.Add("Cachorro.jpg");
            cboAnimais.Items.Add("Cavalo.jpg");
            cboAnimais.Items.Add("Gato.jpg");
            cboAnimais.Items.Add("Centopeia.jpg");
            cboAnimais.Items.Add("Cobra.jpg");
            cboAnimais.Items.Add("Passaro.jpg");


        }

        private PictureBox GetPctAnimais()
        {
            return pctAnimais;
        }

        private void btnPatas_Click(object sender, EventArgs e, PictureBox pctAnimais)
        {
            // declarar a variavel
            string strAnimal;

            //variavel recebe o texto do item do combobox selecionado 
            strAnimal = cboAnimais.Text;

            //instruções de seleção
            switch (strAnimal)
            {
                //agrupando varios casos na mesma seção


                case "Cachorro.jpg":
                    pctAnimais.Load("cachorro.jpg");
                    break;

                case "Cavalo":
                    pctAnimais.Load("cavalo.jpg");



                    MessageBox.Show("este animal tem quatro patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Centopeia":
                    pctAnimais.Load("centopeia.jpg");
                    MessageBox.Show("este animal tem 100 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                
                case "Cobra":
                    pctAnimais.Load("cobra.jpg");
                    MessageBox.Show("este animal nao tem patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Passaro":
                    pctAnimais.Load("passaro.jpg");
                    MessageBox.Show("etse animal tem 2 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;


                default:
                    MessageBox.Show("selecione um animal", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;


            }
        }

        private void pctAnimais_Click(object sender, EventArgs e)
        {

        }

        private void pctAnimais_Click_1(object sender, EventArgs e)
        {

        }
    }
}
