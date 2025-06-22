using System;
using System.Collections.Generic;
using EnergiaApp.Models;
using EnergiaApp.Services;

class Program
{
    static List<IConsumidor> consumidores = new List<IConsumidor>();
    static IArquivoService arquivoService = new ArquivoService();

    static void Main()
    {
        bool continuar = true;
        var caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),"Downloads","consumidores.json");
        Console.WriteLine($"Arquivo será salvo em: {caminhoArquivo}");


        while (continuar)
        {
            try
            {
                Console.WriteLine("\n1 - Cadastrar Consumidor");
                Console.WriteLine("2 - Consultar Contas");
                Console.WriteLine("3 - Salvar em arquivo");
                Console.WriteLine("4 - Carregar de arquivo");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarConsumidor();
                        break;
                    case "2":
                        ConsultarContas();
                        break;
                    case "3":
                        arquivoService.Salvar(consumidores, caminhoArquivo);
                        break;
                    case "4":
                        consumidores = arquivoService.Carregar(caminhoArquivo);
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro no programa: {ex.Message}");
            }
        }
    }

    static void CadastrarConsumidor()
    {
        Console.Write("CPF ou CNPJ: ");
        var id = Console.ReadLine();

        IConsumidor consumidor = id.Length == 11
            ? new ConsumidorPF(id)
            : new ConsumidorPJ(id);

        Console.Write("Quantas contas deseja cadastrar? ");
        int qtd = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtd; i++)
        {
            Console.Write("Número da instalação: ");
            string numero = Console.ReadLine()!;

            Console.Write("Leitura anterior: ");
            double ant = double.Parse(Console.ReadLine()!);

            Console.Write("Leitura atual: ");
            double atual = double.Parse(Console.ReadLine()!);

            Console.Write("Tipo (R para Residencial / C para Comercial): ");
            string tipo = Console.ReadLine().ToUpper();

            IConta conta = tipo == "R"
                ? new ContaResidencial { NumeroInstalacao = numero, LeituraAnterior = ant, LeituraAtual = atual }
                : (IConta)new ContaComercial { NumeroInstalacao = numero, LeituraAnterior = ant, LeituraAtual = atual };

            consumidor.AdicionarConta(conta);
        }

        consumidores.Add(consumidor);
    }

    static void ConsultarContas()
    {
        Console.Write("Digite o CPF/CNPJ: ");
        var id = Console.ReadLine();

        var consumidor = consumidores.Find(c => c.Identificador == id);

        if (consumidor == null)
        {
            Console.WriteLine("Consumidor não encontrado.");
            return;
        }

        foreach (var conta in consumidor.ObterContas())
        {
            Console.WriteLine(conta.GetResumoConta());
            Console.WriteLine($"Valor com impostos: {conta.CalcularValorComImpostos():C}");
            Console.WriteLine($"Valor sem impostos: {conta.CalcularValorSemImpostos():C}");
        }
    }
}
