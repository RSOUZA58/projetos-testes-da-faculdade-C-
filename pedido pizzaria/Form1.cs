using System.Diagnostics;

namespace pedido_pizzaria
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSabores.Items.Clear();


            //preenchendo o combobox com sabores das pizzas

            cboSabores.Items.Add("Mussarela");
            cboSabores.Items.Add("Palmito");
            cboSabores.Items.Add("Atum");
            cboSabores.Items.Add("Calabresa");

            //selecionado o item da lista que tem o índice = 0, o primeiro da lista
            cboSabores.SelectedIndex = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbComBorda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //selecionado o item que tem o índice = 0,o mprimeiro da lista.
            cboSabores.SelectedIndex = 0;

            //colocando o curso no combobox

            cboSabores.Focus();

            //deixar os checks sem seleção.

            chkAzeitona.Checked = false;
            chkCebola.Checked = false;

            //deixar o radiobutton rdbsemborda selecionado

            rdbSemBorda.Checked = true;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //declaração das variáveis
            string strSabor;

            //variável para concatenar os textos
            string strPedido = null;

            //variável recebe o Texto do ComboBox
            strSabor = cboSabores.Text;

            //verififca se tem algum item do CombBox selecionado por meio da propriedade Text
            //Se o texto for Nulo ou Vazio emite mensagem ao usuário e coloca o foco do cursor no cboSabor

            if (string.IsNullOrEmpty(cboSabores.Text))
            {
                MessageBox.Show("Selecione um sabor de pizza!", "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSabores.Focus();
                return;
            }

            //estrutura switch para os sabores das pizzas.
            // a variávelo strPedido recebe o texto de strSabor 
            switch (strSabor)
            {
                case "Mussarela":
                    strPedido = "Mussarela";
                    break;
                case "Palmito":
                    strPedido = "Palmito";
                    break;
                case "Atum":
                    strPedido = "Atum";
                    break;
                case "Calabresa":
                    strPedido = "Calabresa";
                    break;
            }

            //neste caso podemos ter os dois selecionados, um ou nenhum.
            //concatena o texto de strPedido com a String definida 
            //verifica se CheckBox está selecionado
            if (chkAzeitona.Checked)
            {
                //concatena o texto de strPedido com a String definida 
                strPedido = strPedido + " com Azeitonas";
            }
            if (chkCebola.Checked)
            {
                strPedido = strPedido + " com Cebola";
            }

            //verifica se RadioButton selecionado
            if (rdbComBorda.Checked)
            {
                //concatena o texto de strPedido com a String definida
                strPedido = strPedido + " com borda recheada";
            }
            else
            {
                strPedido = strPedido + " sem borda";
            }

            // emite mensagem da formação do pedido
            MessageBox.Show(strPedido, "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void backgroundWorker1_DoWork_1(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}