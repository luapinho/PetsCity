namespace PetsCity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                negocio Negocio = new negocio();

                Negocio.NomePet = txtNomePet.Text;
                Negocio.PrecoServico = Convert.ToDouble(txtPrecoServico.Text);
                Negocio.Quantidade = int.Parse(txtQuantidade.Text);
                Negocio.IdadeAnimal = int.Parse(txtIdadeAnimal.Text);

                double desconto = Negocio.CalcularDesconto();
                double valorFinal = Negocio.CalcularValorFinal();
                double parcela = Negocio.CalcularParcela();
                bool brindeAprovado = Negocio.ValidarBrinde();

                lblNome.Text = $"{Negocio.NomePet.ToUpper()}";
                lblDesconto.Text = $"R${desconto:N2}";
                lblValorFinal.Text = $"R${valorFinal:N2}";
                lblParcela.Text = $"3x de R${parcela:N2}";
                

                txtNomePet.Clear();
                txtPrecoServico.Clear();
                txtQuantidade.Clear ();
                txtIdadeAnimal.Clear ();

                if (brindeAprovado)
                {
                    lblStatus.Text = "PARABÉNS! Você ganhou um Brinde";
                    lblStatus.ForeColor = Color.Green;

                }

                else
                {
                    lblStatus.Text = "Compra padrão realizada com sucesso!";
                    lblStatus.ForeColor= Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Preencha os campos numéricos corretamente!",
                    "Erro de digitação", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
