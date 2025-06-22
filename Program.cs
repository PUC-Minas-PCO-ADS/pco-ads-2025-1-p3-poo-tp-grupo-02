using System;
using System.Collections.Generic;
using pco_ads_2025_1_p3_poo_tp_grupo_02;

namespace pco_ads_2025_1_p3_poo_tp_grupo_02
{
    class Program
    {
        // Corrigido: caminho usando @ para evitar erro de escape
        static List<Pessoa> pessoas = ArquivoHelper.CarregarDados(@"D:\workspace\poo\dados.json");

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("\n--- Sistema de Controle de Consumo de Energia ---");
                Console.WriteLine("1 - Cadastrar Consumidor e Conta");
                Console.WriteLine("2 - Consultar Conta por CPF/CNPJ");
                Console.WriteLine("3 - Testar Contas (Exemplo)");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida! Digite um número.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        Consultar();
                        break;
                    case 3:
                        Teste();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
        }

        static void Cadastrar()
        {
            try
            {
                Console.Write("\nNome do Consumidor: ");
                string nome = Console.ReadLine();

                Console.Write("CPF ou CNPJ: ");
                string id = Console.ReadLine();

                Console.Write("Tipo de Pessoa (F - Física / J - Jurídica): ");
                string tipoPessoa = Console.ReadLine().ToUpper();

                Pessoa consumidor;
                if (tipoPessoa == "F")
                    consumidor = new PessoaFisica(nome, id);
                else if (tipoPessoa == "J")
                    consumidor = new PessoaJuridica(nome, id);
                else
                {
                    Console.WriteLine("Tipo de pessoa inválido.");
                    return;
                }

                Console.Write("Tipo da Conta (Residencial / Comercial): ");
                string tipoConta = Console.ReadLine();

                Console.Write("Leitura Anterior (kWh): ");
                double leituraAnt = double.Parse(Console.ReadLine());

                Console.Write("Leitura Atual (kWh): ");
                double leituraAtual = double.Parse(Console.ReadLine());

                Conta conta = ContaFactory.CriarConta(tipoConta);
                conta.LeituraAnterior = leituraAnt;
                conta.LeituraAtual = leituraAtual;

                consumidor.AdicionarConta(conta);
                pessoas.Add(consumidor);

                ArquivoHelper.SalvarDados(pessoas, @"D:\workspace\poo\dados.json");

                Console.WriteLine("Conta cadastrada e salva com sucesso!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao cadastrar conta: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: formato inválido nos dados numéricos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }

        static void Consultar()
        {
            Console.Write("\nInforme o CPF ou CNPJ para consulta: ");
            string id = Console.ReadLine();

            foreach (var pessoa in pessoas)
            {
                if (pessoa.ID == id)
                {
                    Console.WriteLine($"\n--- Dados do Consumidor ---");
                    Console.WriteLine($"Nome: {pessoa.Nome}");

                    foreach (var conta in pessoa.Contas)
                    {
                        Console.WriteLine($"- Tipo: {conta.GetType().Name}");
                        Console.WriteLine($"  Consumo: {conta.Consumo} kWh");
                        Console.WriteLine($"  Valor sem Imposto: R$ {conta.CalcularValorSemImposto():F2}");
                        Console.WriteLine($"  Valor Total com Imposto: R$ {conta.CalcularValorTotal():F2}");
                    }
                    return;
                }
            }

            Console.WriteLine("Consumidor não encontrado.");
        }

        static void Teste()
        {
            PessoaFisica pf = new PessoaFisica("João Silva", "12345678909");
            Conta contaResidencial = ContaFactory.CriarConta("Residencial");
            contaResidencial.LeituraAnterior = 100;
            contaResidencial.LeituraAtual = 150;
            pf.AdicionarConta(contaResidencial);

            Console.WriteLine($"Valor Total Residencial: R$ {contaResidencial.CalcularValorTotal():F2}");

            PessoaJuridica pj = new PessoaJuridica("Empresa XYZ", "12345678000195");
            Conta contaComercial = ContaFactory.CriarConta("Comercial");
            contaComercial.LeituraAnterior = 200;
            contaComercial.LeituraAtual = 300;
            pj.AdicionarConta(contaComercial);

            Console.WriteLine($"Valor Total Comercial: R$ {contaComercial.CalcularValorTotal():F2}");
        }
    }
}
