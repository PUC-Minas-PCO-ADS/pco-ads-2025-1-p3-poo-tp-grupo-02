// Models/ContaBase.cs
using System;

namespace EnergiaApp.Models
{
    public abstract class ContaBase : IConta
    {
        public string NumeroInstalacao { get; set; }
        public double LeituraAnterior { get; set; }
        public double LeituraAtual { get; set; }

        public double CalcularConsumo()
        {
            double consumo = LeituraAtual - LeituraAnterior;
            return consumo > 0 ? consumo : 0;
        }

        public abstract double CalcularValorComImpostos();
        public abstract double CalcularValorSemImpostos();

        public virtual string GetResumoConta()
        {
            return $"Instalação: {NumeroInstalacao}, Consumo: {CalcularConsumo()} kWh";
        }
    }
}
