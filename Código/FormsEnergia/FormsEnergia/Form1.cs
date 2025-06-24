using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEnergia
{
    public partial class Form1 : Form
    {
        private List<Pessoa> pessoas;
        private string caminhoJson;
        public Form1()
        {
            InitializeComponent();

            lstContas.Visible = false;
            caminhoJson = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            "Downloads",
            "dados.json"
            );

            pessoas = ArquivoHelper.CarregarDados(caminhoJson);

            if (pessoas == null)
            {
                pessoas = new List<Pessoa>();
            }
                
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string id = txtId.Text;
            string tipoPessoa = comboTipoPessoa.SelectedItem?.ToString();
            string tipoConta = comboTipoConta.SelectedItem?.ToString();
            string numInstalacao = txtInstalacao.Text;

            if (!double.TryParse(txtLeituraAnterior.Text, out double leituraAnt) ||
                !double.TryParse(txtLeituraAtual.Text, out double leituraAtual))
            {
                MessageBox.Show("Leituras inválidas! Por favor tente novamente.");
                return;
            }

            Pessoa consumidor;
            if (tipoPessoa == "Física")
                consumidor = new PessoaFisica(nome, id);
            else if (tipoPessoa == "Jurídica")
                consumidor = new PessoaJuridica(nome, id);
            else
            {
                MessageBox.Show("Tipo de pessoa inválido! Por favor tente novamente.");
                return;
            }

            Conta conta;
            try
            {
                conta = ContaFactory.CriarConta(tipoConta);
            }
            catch
            {
                MessageBox.Show("Tipo de conta inválido! Por favor tente novamente.");
                return;
            }

            conta.NumInstalacao = numInstalacao;
            conta.LeituraAnterior = leituraAnt;
            conta.LeituraAtual = leituraAtual;

            // Aq a gnt ta verificando se a pessoa já existe pra evitar q o número de instalação seja repetido
            if (pessoas != null && pessoas.Count > 0)
            {
                Pessoa pessoaExistente = pessoas.FirstOrDefault(p => p.ID == id);

                if (pessoaExistente != null)
                {
                    if (pessoaExistente.Contas.Any(c => c.NumInstalacao == numInstalacao))
                    {
                        MessageBox.Show("Número de instalação já cadastrado para esse cliente. Por favor tente novamente.");
                        return;
                    }
                    pessoaExistente.AdicionarConta(conta);
                }
                else
                {
                    consumidor.AdicionarConta(conta);
                    pessoas.Add(consumidor);
                }
            }
            else
            {
                consumidor.AdicionarConta(conta);
                pessoas.Add(consumidor);
            }

            ArquivoHelper.SalvarDados(pessoas, caminhoJson);
            MessageBox.Show("Conta cadastrada com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtId.Clear();
            txtInstalacao.Clear();
            txtLeituraAnterior.Clear();
            txtLeituraAtual.Clear();
            comboTipoConta.SelectedIndex = -1;
            comboTipoPessoa.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstContas.Visible = true;
            lstContas.Items.Clear();

            string idConsulta = txtConsultaId.Text;

            var pessoa = pessoas.FirstOrDefault(p => p.ID == idConsulta);
            if (pessoa == null)
            {
                MessageBox.Show("Pessoa não encontrada.");
                return;
            }

            lstContas.Items.Clear();
            foreach (var conta in pessoa.Contas)
            {
                lstContas.Items.Add("-----------------------------------------------------------------------");
                lstContas.Items.Add($"Cliente, essas são suas informações:");
                lstContas.Items.Add($"Consumo no mês anterior: {conta.LeituraAnterior} kW/h");
                lstContas.Items.Add($"Valor da conta sem impostos: R$ {conta.CalcularValorSemImposto():F2}");
                lstContas.Items.Add($"Valor total da conta c/ impostos: R$ {conta.CalcularValorTotal():F2}");
                lstContas.Items.Add("-----------------------------------------------------------------------");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConsultaId.Clear();
            lstContas.Items.Clear();
            lstContas.ClearSelected();
        }
    }
}
