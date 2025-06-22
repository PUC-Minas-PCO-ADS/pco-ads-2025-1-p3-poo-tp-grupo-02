public class Pessoa
{
    public string Nome { get; set; }
    public string ID { get; set; } // OBS.: Ou é CPF ou CNPJ
    public List<Conta> Contas { get; set;  }

    public Pessoa(string nome, string documento)
    {
        Nome = nome;
        ID = documento;
    }

    public void AdicionarConta(Conta conta)
    {
        Contas.Add(conta);
    }
}