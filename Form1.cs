namespace Comissão_do_vendedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total;
        int qtd;
        double preco;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtvendedor.Text) || string.IsNullOrEmpty(txtpeca.Text) || string.IsNullOrEmpty(txtpreco.Text) || string.IsNullOrEmpty(txtqtd.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblresultadofinal.Text = "";
            txtvendedor.Focus();
            qtd = Convert.ToInt32(txtqtd.Text);
            preco = Convert.ToDouble(txtpreco.Text);
            total = qtd * preco;
            double comissao = total * 0.05;

            lblresultadofinal.Text =
            "Nome do vendedor: " + txtvendedor.Text + "\n" +
            "--------------------------" + "\n" +
            "Código da peça: " + txtpeca.Text + "\n" +
            "Preço: " + txtpreco.Text + "\n" +
            "Quantidade vendida: " + txtqtd.Text + "\n" +
            "O total é: R$ " + total.ToString("F2") + "\n" +
            "A comissão do vendedor é: 5% e R$ " + comissao.ToString("F2");
            txtpeca.Text = "";
            txtpreco.Text = "";
            txtqtd.Text = "";
            txtvendedor.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
