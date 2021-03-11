
namespace Atividade2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbtnFem = new System.Windows.Forms.RadioButton();
            this.RbtnMasc = new System.Windows.Forms.RadioButton();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.txtPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso Atual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMensagem);
            this.groupBox1.Location = new System.Drawing.Point(14, 286);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(421, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mensagem:";
            // 
            // RbtnFem
            // 
            this.RbtnFem.AutoSize = true;
            this.RbtnFem.Location = new System.Drawing.Point(120, 118);
            this.RbtnFem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbtnFem.Name = "RbtnFem";
            this.RbtnFem.Size = new System.Drawing.Size(92, 24);
            this.RbtnFem.TabIndex = 4;
            this.RbtnFem.TabStop = true;
            this.RbtnFem.Text = "Feminino";
            this.RbtnFem.UseVisualStyleBackColor = true;
            // 
            // RbtnMasc
            // 
            this.RbtnMasc.AutoSize = true;
            this.RbtnMasc.Location = new System.Drawing.Point(120, 151);
            this.RbtnMasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbtnMasc.Name = "RbtnMasc";
            this.RbtnMasc.Size = new System.Drawing.Size(98, 24);
            this.RbtnMasc.TabIndex = 5;
            this.RbtnMasc.TabStop = true;
            this.RbtnMasc.Text = "Masculino";
            this.RbtnMasc.UseVisualStyleBackColor = true;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(120, 17);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAltura.Mask = "9.99";
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(202, 26);
            this.txtAltura.TabIndex = 6;
            // 
            // txtPesoAtual
            // 
            this.txtPesoAtual.Location = new System.Drawing.Point(120, 73);
            this.txtPesoAtual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesoAtual.Mask = "999.99";
            this.txtPesoAtual.Name = "txtPesoAtual";
            this.txtPesoAtual.Size = new System.Drawing.Size(202, 26);
            this.txtPesoAtual.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(17, 208);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(131, 58);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(317, 208);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 58);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "SAIR";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(55, 44);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(13, 20);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = ".";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(165, 208);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 58);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "LIMPAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 413);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtPesoAtual);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.RbtnMasc);
            this.Controls.Add(this.RbtnFem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbtnFem;
        private System.Windows.Forms.RadioButton RbtnMasc;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.MaskedTextBox txtPesoAtual;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnClear;
    }
}

