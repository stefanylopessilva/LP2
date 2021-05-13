
namespace Atividade7
{
    partial class frmExercicio1
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
            this.btnPares = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.rftTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPares
            // 
            this.btnPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPares.Location = new System.Drawing.Point(329, 320);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(120, 79);
            this.btnPares.TabIndex = 9;
            this.btnPares.Text = "Quantidade de pares de Letras";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetraR.Location = new System.Drawing.Point(167, 320);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(120, 79);
            this.btnLetraR.TabIndex = 8;
            this.btnLetraR.Text = "Quantidade de Letra \"R\"";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspacoBranco.Location = new System.Drawing.Point(17, 320);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(120, 79);
            this.btnEspacoBranco.TabIndex = 7;
            this.btnEspacoBranco.Text = "Quantidade de espaços em Branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.btnEspacoBranco_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(20, 20);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(230, 20);
            this.lblTexto.TabIndex = 6;
            this.lblTexto.Text = "Digite o texto no campo abaixo:";
            // 
            // rftTexto
            // 
            this.rftTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rftTexto.Location = new System.Drawing.Point(17, 57);
            this.rftTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rftTexto.Name = "rftTexto";
            this.rftTexto.Size = new System.Drawing.Size(432, 235);
            this.rftTexto.TabIndex = 5;
            this.rftTexto.Text = "";
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 422);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.rftTexto);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnEspacoBranco;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.RichTextBox rftTexto;
    }
}