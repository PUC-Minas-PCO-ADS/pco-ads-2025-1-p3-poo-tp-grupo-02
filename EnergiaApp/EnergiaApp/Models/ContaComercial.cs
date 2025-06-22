// Models/ContaComercial.cs
namespace EnergiaApp.Models
{
    public class ContaComercial : ContaBase
    {
        private const double Tarifa = 0.35;
        private const double Iluminacao = 9.25;
        private const double Imposto = 0.18;

        public override double CalcularValorSemImpostos()
        {
            return CalcularConsumo() * Tarifa + Iluminacao;
        }

        public override double CalcularValorComImpostos()
        {
            return CalcularValorSemImpostos() * (1 + Imposto);
        }
    }
}
