

namespace PetsCity
{
    class negocio
    {
        //ATRIBUTOS(COMPONENTES)
        public string NomePet { get; set; }
        public double PrecoServico { get; set; }
        public int Quantidade { get; set; }
        public int IdadeAnimal { get; set; }

        //MÉTODOS
        public double CalcularDesconto()
        {
            double valorTotal = PrecoServico * Quantidade;

            if (Quantidade >= 10)
            {
                return valorTotal * 010;
            }

            return 0;
        }

        //MÉTODO PARA CALCULAR O VALOR FINAL
        public double CalcularValorFinal()
        {
            double valorTotalBruto = PrecoServico * Quantidade;
            double desconto = CalcularDesconto();
            return valorTotalBruto - desconto;

        }

        //MÉTODO PARA CALCULAR O PARCELAMENTO EM 3X SEM JUROS
        public double CalcularParcela()
        {
            return CalcularValorFinal() / 3;
        }

        //MÉTODO PARA VALIDAR SE O CLIENTE A UM BRINDE ESPECIAL
        public bool ValidarBrinde()
        {
            return (IdadeAnimal >= 18 && Quantidade >= 5) || (CalcularValorFinal() > 100);
        }
    }
}
