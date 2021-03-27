
namespace PClasses
{
    partial class frmHorista
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
            this.lblMatriculaHorista = new System.Windows.Forms.Label();
            this.lblNomeHorista = new System.Windows.Forms.Label();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.lblNumeroHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDiasFalta = new System.Windows.Forms.Label();
            this.btnInstHorista = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumeroHoras = new System.Windows.Forms.TextBox();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.msktxtData = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblMatriculaHorista
            // 
            this.lblMatriculaHorista.AutoSize = true;
            this.lblMatriculaHorista.Location = new System.Drawing.Point(41, 35);
            this.lblMatriculaHorista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatriculaHorista.Name = "lblMatriculaHorista";
            this.lblMatriculaHorista.Size = new System.Drawing.Size(73, 20);
            this.lblMatriculaHorista.TabIndex = 0;
            this.lblMatriculaHorista.Text = "Matrícula";
            // 
            // lblNomeHorista
            // 
            this.lblNomeHorista.AutoSize = true;
            this.lblNomeHorista.Location = new System.Drawing.Point(41, 74);
            this.lblNomeHorista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeHorista.Name = "lblNomeHorista";
            this.lblNomeHorista.Size = new System.Drawing.Size(51, 20);
            this.lblNomeHorista.TabIndex = 1;
            this.lblNomeHorista.Text = "Nome";
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Location = new System.Drawing.Point(41, 116);
            this.lblSalarioHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(124, 20);
            this.lblSalarioHora.TabIndex = 2;
            this.lblSalarioHora.Text = "Salário por Hora";
            // 
            // lblNumeroHora
            // 
            this.lblNumeroHora.AutoSize = true;
            this.lblNumeroHora.Location = new System.Drawing.Point(41, 159);
            this.lblNumeroHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroHora.Name = "lblNumeroHora";
            this.lblNumeroHora.Size = new System.Drawing.Size(134, 20);
            this.lblNumeroHora.TabIndex = 3;
            this.lblNumeroHora.Text = "Número de Horas";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(41, 201);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(217, 20);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data de Entrada na Empresa";
            // 
            // lblDiasFalta
            // 
            this.lblDiasFalta.AutoSize = true;
            this.lblDiasFalta.Location = new System.Drawing.Point(41, 242);
            this.lblDiasFalta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasFalta.Name = "lblDiasFalta";
            this.lblDiasFalta.Size = new System.Drawing.Size(111, 20);
            this.lblDiasFalta.TabIndex = 5;
            this.lblDiasFalta.Text = "Dias de Faltas";
            // 
            // btnInstHorista
            // 
            this.btnInstHorista.Location = new System.Drawing.Point(172, 305);
            this.btnInstHorista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInstHorista.Name = "btnInstHorista";
            this.btnInstHorista.Size = new System.Drawing.Size(220, 65);
            this.btnInstHorista.TabIndex = 6;
            this.btnInstHorista.Text = "Instanciar Horista";
            this.btnInstHorista.UseVisualStyleBackColor = true;
            this.btnInstHorista.Click += new System.EventHandler(this.btnInstHorista_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(276, 29);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(233, 26);
            this.txtMatricula.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(276, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(233, 26);
            this.txtNome.TabIndex = 8;
            // 
            // txtNumeroHoras
            // 
            this.txtNumeroHoras.Location = new System.Drawing.Point(276, 153);
            this.txtNumeroHoras.Name = "txtNumeroHoras";
            this.txtNumeroHoras.Size = new System.Drawing.Size(233, 26);
            this.txtNumeroHoras.TabIndex = 9;
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(276, 236);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(233, 26);
            this.txtDiasFalta.TabIndex = 10;
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.Location = new System.Drawing.Point(276, 110);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(233, 26);
            this.txtSalarioHora.TabIndex = 11;
            // 
            // msktxtData
            // 
            this.msktxtData.Location = new System.Drawing.Point(276, 195);
            this.msktxtData.Name = "msktxtData";
            this.msktxtData.Size = new System.Drawing.Size(233, 26);
            this.msktxtData.TabIndex = 12;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 405);
            this.Controls.Add(this.msktxtData);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.txtNumeroHoras);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnInstHorista);
            this.Controls.Add(this.lblDiasFalta);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNumeroHora);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.lblNomeHorista);
            this.Controls.Add(this.lblMatriculaHorista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatriculaHorista;
        private System.Windows.Forms.Label lblNomeHorista;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.Label lblNumeroHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDiasFalta;
        private System.Windows.Forms.Button btnInstHorista;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumeroHoras;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.MaskedTextBox msktxtData;
    }
}