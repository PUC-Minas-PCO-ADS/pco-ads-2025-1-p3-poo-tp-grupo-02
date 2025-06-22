public abstract class Conta
{
    public string NumInstalacao { get; set; }
    public double LeituraAnterior { get; set; }
    public double LeituraAtual { get; set; }

    public double Consumo => LeituraAtual - LeituraAnterior;
    public const double ContribuicaoIluminacao = 9.25;

    protected abstract double Tarifa { get; }
    protected abstract double Imposto { get; }

    public double CalcularValorSemImposto()
    {
        return Consumo * Tarifa + ContribuicaoIluminacao;
    }

    public double CalcularValorTotal()
    {
        return CalcularValorSemImposto() * (1 + Imposto);
    }
}

public class ContaResidencial : Conta
{
    protected override double Tarifa => 0.40;
    protected override double Imposto => 0.30;
}

public class ContaComercial : Conta
{
    protected override double Tarifa => 0.35;
    protected override double Imposto => 0.18;
}