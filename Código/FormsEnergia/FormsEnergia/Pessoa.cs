using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsEnergia
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string ID { get; set; } // tem que ser ou CPF ou CNPJ
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
