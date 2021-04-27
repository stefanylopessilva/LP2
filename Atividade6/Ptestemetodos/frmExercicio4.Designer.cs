
namespace Ptestemetodos
{
    partial class frmExercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtfTexto = new System.Windows.Forms.RichTextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnNumerico = new System.Windows.Forms.Button();
            this.btnPosicao = new System.Windows.Forms.Button();
            this.btnAlfabetico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtfTexto
            // 
            this.rtfTexto.Location = new System.Drawing.Point(25, 106);
            this.rtfTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtfTexto.Name = "rtfTexto";
            this.rtfTexto.Size = new System.Drawing.Size(488, 190);
            this.rtfTexto.TabIndex = 0;
            this.rtfTexto.Text = "";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(21, 45);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(267, 20);
            this.lblCampo.TabIndex = 1;
            this.lblCampo.Text = "Escreva seu texto no campo abaixo: ";
            // 
            // btnNumerico
            // 
            this.btnNumerico.Location = new System.Drawing.Point(25, 348);
            this.btnNumerico.Name = "btnNumerico";
            this.btnNumerico.Size = new System.Drawing.Size(153, 69);
            this.btnNumerico.TabIndex = 2;
            this.btnNumerico.Text = "Quantidade de Caracteres Numéricos";
            this.btnNumerico.UseVisualStyleBackColor = true;
            this.btnNumerico.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnPosicao
            // 
            this.btnPosicao.Location = new System.Drawing.Point(193, 348);
            this.btnPosicao.Name = "btnPosicao";
            this.btnPosicao.Size = new System.Drawing.Size(153, 69);
            this.btnPosicao.TabIndex = 3;
            this.btnPosicao.Text = "Posição do 1º Caractere em branco";
            this.btnPosicao.UseVisualStyleBackColor = true;
            this.btnPosicao.Click += new System.EventHandler(this.btnPosicao_Click);
            // 
            // btnAlfabetico
            // 
            this.btnAlfabetico.Location = new System.Drawing.Point(360, 348);
            this.btnAlfabetico.Name = "btnAlfabetico";
            this.btnAlfabetico.Size = new System.Drawing.Size(153, 69);
            this.btnAlfabetico.TabIndex = 4;
            this.btnAlfabetico.Text = "Quantidade de Caracteres Alfabéticos";
            this.btnAlfabetico.UseVisualStyleBackColor = true;
            this.btnAlfabetico.Click += new System.EventHandler(this.btnAlfabetico_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 473);
            this.Controls.Add(this.btnAlfabetico);
            this.Controls.Add(this.btnPosicao);
            this.Controls.Add(this.btnNumerico);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.rtfTexto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfTexto;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnNumerico;
        private System.Windows.Forms.Button btnPosicao;
        private System.Windows.Forms.Button btnAlfabetico;
    }
}