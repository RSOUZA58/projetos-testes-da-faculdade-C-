namespace uninove_teste
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnmenssagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello word, " + txtnome.Text);
        }
    }
}
