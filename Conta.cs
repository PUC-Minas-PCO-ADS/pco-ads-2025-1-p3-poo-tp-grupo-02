using Newtonsoft.Json;
using System.IO.Pipelines;

[JsonObject]
public abstract class Conta
{
    public string NumInstalacao { get; set; }
    public double LeituraAnterior { get; set; }
    public double LeituraAtual { get; set; }

    public const double ContribuicaoIluminacao = 9.25;

    protected abstract double Tarifa { get; }
    protected abstract double Imposto { get; }

    public double CalcularValorSemImposto()
    {
        double consumo = LeituraAtual - LeituraAnterior;
        return consumo * Tarifa + ContribuicaoIluminacao;
    }

    public double CalcularValorTotal()
    {
        double valorImposto = CalcularValorSemImposto() * Imposto;
        return CalcularValorSemImposto() + valorImposto;
    }
}

[JsonObject]
public class ContaResidencial : Conta
{
    protected override double Tarifa => 0.40;
    protected override double Imposto => 0.30;
}

[JsonObject]
public class ContaComercial : Conta
{
    protected override double Tarifa => 0.35;
    protected override double Imposto => 0.18;
}
