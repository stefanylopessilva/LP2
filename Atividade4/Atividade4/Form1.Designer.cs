
namespace Atividade4
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxNome = new System.Windows.Forms.MaskedTextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gbxMensagem = new System.Windows.Forms.GroupBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblAliqINSS = new System.Windows.Forms.Label();
            this.lblAliqIRPF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.txtAliqINSS = new System.Windows.Forms.TextBox();
            this.txtAliqIRPF = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.txtDescINSS = new System.Windows.Forms.TextBox();
            this.txtDescIRPF = new System.Windows.Forms.TextBox();
            this.nudNumFilhos = new System.Windows.Forms.NumericUpDown();
            this.gbxSexo.SuspendLayout();
            this.gbxEstadoCivil.SuspendLayout();
            this.gbxMensagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumFilhos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 46);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(137, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(19, 92);
            this.lblSalBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(85, 16);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salário Bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(19, 141);
            this.lblNumFilhos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(109, 16);
            this.lblNumFilhos.TabIndex = 2;
            this.lblNumFilhos.Text = "Número de filhos";
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Location = new System.Drawing.Point(163, 88);
            this.mskbxSalBruto.Margin = new System.Windows.Forms.Padding(4);
            this.mskbxSalBruto.Mask = "99,999.99";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(160, 22);
            this.mskbxSalBruto.TabIndex = 1;
            // 
            // mskbxNome
            // 
            this.mskbxNome.Location = new System.Drawing.Point(163, 43);
            this.mskbxNome.Margin = new System.Windows.Forms.Padding(4);
            this.mskbxNome.Name = "mskbxNome";
            this.mskbxNome.Size = new System.Drawing.Size(160, 22);
            this.mskbxNome.TabIndex = 0;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Location = new System.Drawing.Point(347, 36);
            this.gbxSexo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSexo.Size = new System.Drawing.Size(128, 123);
            this.gbxSexo.TabIndex = 3;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(18, 76);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(87, 20);
            this.rbtnMasculino.TabIndex = 4;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Checked = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(18, 33);
            this.rbtnFeminino.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(81, 20);
            this.rbtnFeminino.TabIndex = 3;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rbtnSolteiro);
            this.gbxEstadoCivil.Controls.Add(this.rbtnCasado);
            this.gbxEstadoCivil.Location = new System.Drawing.Point(497, 36);
            this.gbxEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEstadoCivil.Size = new System.Drawing.Size(126, 123);
            this.gbxEstadoCivil.TabIndex = 4;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil";
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Location = new System.Drawing.Point(18, 76);
            this.rbtnSolteiro.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(91, 20);
            this.rbtnSolteiro.TabIndex = 6;
            this.rbtnSolteiro.Text = "Solteiro (a)";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Checked = true;
            this.rbtnCasado.Location = new System.Drawing.Point(18, 33);
            this.rbtnCasado.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(93, 20);
            this.rbtnCasado.TabIndex = 5;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado (a)";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(636, 68);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(122, 63);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Verificar Desconto";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // gbxMensagem
            // 
            this.gbxMensagem.Controls.Add(this.lblMensagem);
            this.gbxMensagem.Location = new System.Drawing.Point(22, 181);
            this.gbxMensagem.Margin = new System.Windows.Forms.Padding(4);
            this.gbxMensagem.Name = "gbxMensagem";
            this.gbxMensagem.Padding = new System.Windows.Forms.Padding(4);
            this.gbxMensagem.Size = new System.Drawing.Size(736, 63);
            this.gbxMensagem.TabIndex = 6;
            this.gbxMensagem.TabStop = false;
            this.gbxMensagem.Text = "Mensagem";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(13, 28);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(11, 16);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = ".";
            // 
            // lblAliqINSS
            // 
            this.lblAliqINSS.AutoSize = true;
            this.lblAliqINSS.Location = new System.Drawing.Point(19, 286);
            this.lblAliqINSS.Name = "lblAliqINSS";
            this.lblAliqINSS.Size = new System.Drawing.Size(91, 16);
            this.lblAliqINSS.TabIndex = 10;
            this.lblAliqINSS.Text = "Alíquota INSS";
            // 
            // lblAliqIRPF
            // 
            this.lblAliqIRPF.AutoSize = true;
            this.lblAliqIRPF.Location = new System.Drawing.Point(19, 327);
            this.lblAliqIRPF.Name = "lblAliqIRPF";
            this.lblAliqIRPF.Size = new System.Drawing.Size(90, 16);
            this.lblAliqIRPF.TabIndex = 11;
            this.lblAliqIRPF.Text = "Alíquota IRPF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(274, 283);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(98, 16);
            this.lblSalFamilia.TabIndex = 12;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Location = new System.Drawing.Point(274, 328);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(98, 16);
            this.lblSalLiquido.TabIndex = 13;
            this.lblSalLiquido.Text = "Salário Líquido";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(523, 286);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(100, 16);
            this.lblDescINSS.TabIndex = 14;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(523, 327);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(99, 16);
            this.lblDescIRPF.TabIndex = 15;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // txtAliqINSS
            // 
            this.txtAliqINSS.Enabled = false;
            this.txtAliqINSS.Location = new System.Drawing.Point(122, 280);
            this.txtAliqINSS.Name = "txtAliqINSS";
            this.txtAliqINSS.Size = new System.Drawing.Size(130, 22);
            this.txtAliqINSS.TabIndex = 7;
            // 
            // txtAliqIRPF
            // 
            this.txtAliqIRPF.Enabled = false;
            this.txtAliqIRPF.Location = new System.Drawing.Point(122, 327);
            this.txtAliqIRPF.Name = "txtAliqIRPF";
            this.txtAliqIRPF.Size = new System.Drawing.Size(130, 22);
            this.txtAliqIRPF.TabIndex = 8;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Location = new System.Drawing.Point(377, 283);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(130, 22);
            this.txtSalFamilia.TabIndex = 9;
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Enabled = false;
            this.txtSalLiquido.Location = new System.Drawing.Point(377, 325);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(130, 22);
            this.txtSalLiquido.TabIndex = 10;
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Enabled = false;
            this.txtDescINSS.Location = new System.Drawing.Point(628, 283);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.Size = new System.Drawing.Size(130, 22);
            this.txtDescINSS.TabIndex = 11;
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Enabled = false;
            this.txtDescIRPF.Location = new System.Drawing.Point(628, 324);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.Size = new System.Drawing.Size(130, 22);
            this.txtDescIRPF.TabIndex = 12;
            // 
            // nudNumFilhos
            // 
            this.nudNumFilhos.Location = new System.Drawing.Point(163, 135);
            this.nudNumFilhos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumFilhos.Name = "nudNumFilhos";
            this.nudNumFilhos.Size = new System.Drawing.Size(160, 22);
            this.nudNumFilhos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 378);
            this.Controls.Add(this.nudNumFilhos);
            this.Controls.Add(this.txtDescIRPF);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtAliqIRPF);
            this.Controls.Add(this.txtAliqINSS);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblAliqIRPF);
            this.Controls.Add(this.lblAliqINSS);
            this.Controls.Add(this.gbxMensagem);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.mskbxNome);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.gbxMensagem.ResumeLayout(false);
            this.gbxMensagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumFilhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.MaskedTextBox mskbxNome;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox gbxMensagem;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblAliqINSS;
        private System.Windows.Forms.Label lblAliqIRPF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.TextBox txtAliqINSS;
        private System.Windows.Forms.TextBox txtAliqIRPF;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.TextBox txtDescINSS;
        private System.Windows.Forms.TextBox txtDescIRPF;
        private System.Windows.Forms.NumericUpDown nudNumFilhos;
    }
}

