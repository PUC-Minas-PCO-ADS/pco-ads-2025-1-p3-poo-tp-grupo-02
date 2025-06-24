namespace FormsEnergia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipoPessoa = new System.Windows.Forms.ComboBox();
            this.comboTipoConta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstalacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLeituraAnterior = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLeituraAtual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConsultaId = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lstContas = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(210, 143);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(210, 194);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insira o CPF/CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insira o tipo de pessoa (Física ou Jurídica):";
            // 
            // comboTipoPessoa
            // 
            this.comboTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoPessoa.FormattingEnabled = true;
            this.comboTipoPessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.comboTipoPessoa.Location = new System.Drawing.Point(210, 245);
            this.comboTipoPessoa.Name = "comboTipoPessoa";
            this.comboTipoPessoa.Size = new System.Drawing.Size(121, 21);
            this.comboTipoPessoa.TabIndex = 5;
            // 
            // comboTipoConta
            // 
            this.comboTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoConta.FormattingEnabled = true;
            this.comboTipoConta.Items.AddRange(new object[] {
            "Residencial",
            "Comercial"});
            this.comboTipoConta.Location = new System.Drawing.Point(210, 299);
            this.comboTipoConta.Name = "comboTipoConta";
            this.comboTipoConta.Size = new System.Drawing.Size(121, 21);
            this.comboTipoConta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Insira o tipo de conta (Residencial ou Comercial):";
            // 
            // txtInstalacao
            // 
            this.txtInstalacao.Location = new System.Drawing.Point(210, 353);
            this.txtInstalacao.Name = "txtInstalacao";
            this.txtInstalacao.Size = new System.Drawing.Size(100, 20);
            this.txtInstalacao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Insira o número de instalação:";
            // 
            // txtLeituraAnterior
            // 
            this.txtLeituraAnterior.Location = new System.Drawing.Point(210, 409);
            this.txtLeituraAnterior.Name = "txtLeituraAnterior";
            this.txtLeituraAnterior.Size = new System.Drawing.Size(100, 20);
            this.txtLeituraAnterior.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Insira o valor da leitura anterior (em kW/h):";
            // 
            // txtLeituraAtual
            // 
            this.txtLeituraAtual.Location = new System.Drawing.Point(210, 463);
            this.txtLeituraAtual.Name = "txtLeituraAtual";
            this.txtLeituraAtual.Size = new System.Drawing.Size(100, 20);
            this.txtLeituraAtual.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Insira o valor da leitura atual (em kW/h):";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(217, 501);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 23);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label8.Location = new System.Drawing.Point(186, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cadastrar clientes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(697, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Consultar clientes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(716, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Insira o CPF/CNPJ para consulta:";
            // 
            // txtConsultaId
            // 
            this.txtConsultaId.Location = new System.Drawing.Point(744, 142);
            this.txtConsultaId.Name = "txtConsultaId";
            this.txtConsultaId.Size = new System.Drawing.Size(113, 20);
            this.txtConsultaId.TabIndex = 18;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(755, 177);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(89, 23);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lstContas
            // 
            this.lstContas.FormattingEnabled = true;
            this.lstContas.Location = new System.Drawing.Point(691, 229);
            this.lstContas.Name = "lstContas";
            this.lstContas.Size = new System.Drawing.Size(232, 121);
            this.lstContas.TabIndex = 20;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(755, 356);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 23);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 637);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lstContas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsultaId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtLeituraAtual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLeituraAnterior);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInstalacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboTipoConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTipoPessoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTipoPessoa;
        private System.Windows.Forms.ComboBox comboTipoConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInstalacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLeituraAnterior;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLeituraAtual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConsultaId;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ListBox lstContas;
        private System.Windows.Forms.Button btnLimpar;
    }
}

