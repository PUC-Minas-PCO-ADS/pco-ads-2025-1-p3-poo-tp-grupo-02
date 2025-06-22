// Models/ContaResidencial.cs
namespace EnergiaApp.Models
{
    public class ContaResidencial : ContaBase
    {
        private const double Tarifa = 0.40;
        private const double Iluminacao = 9.25;
        private const double Imposto = 0.30;

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
