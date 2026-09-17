

namespace PetsCity
{
    class negocio
    {
        public string NomePet { get; set; }
        public double PrecoServico { get; set; }
        public int Quantidade { get; set; }
        public int IdadeAnimal { get; set; }

        public double CalcularDesconto()
        {
            double valorTotal = PrecoServico * Quantidade;

            if (Quantidade >= 10)
            {
                return valorTotal * 010;
            }

            return 0;
        }
        public double CalcularValorFinal()
        {
            double valorTotalBruto = PrecoServico * Quantidade;
            double desconto = CalcularDesconto();
            return valorTotalBruto - desconto;

        }

        public double CalcularParcela()
        {
            return CalcularValorFinal() / 3;
        }
        public bool ValidarBrinde()
        {
            return (IdadeAnimal >= 18 && Quantidade >= 5) || (CalcularValorFinal() > 100);
        }
    }
}
