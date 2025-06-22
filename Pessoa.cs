namespace pco_ads_2025_1_p3_poo_tp_grupo_02
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string ID { get; set; } // CPF ou CNPJ
        public List<Conta> Contas { get; set; } = new List<Conta>();

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

    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome, string cpf) : base(nome, cpf) { }
    }

    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, string cnpj) : base(nome, cnpj) { }
    }
}