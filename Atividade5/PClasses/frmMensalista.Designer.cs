
namespace PClasses
{
    partial class frmMensalista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.lblDataEnt = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.txtDataEnt = new System.Windows.Forms.TextBox();
            this.btnMensalista = new System.Windows.Forms.Button();
            this.btnMensalistaPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(42, 41);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(73, 20);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(42, 84);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Location = new System.Drawing.Point(42, 137);
            this.lblSalarioMensal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(113, 20);
            this.lblSalarioMensal.TabIndex = 2;
            this.lblSalarioMensal.Text = "Salário Mensal";
            // 
            // lblDataEnt
            // 
            this.lblDataEnt.AutoSize = true;
            this.lblDataEnt.Location = new System.Drawing.Point(42, 188);
            this.lblDataEnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEnt.Name = "lblDataEnt";
            this.lblDataEnt.Size = new System.Drawing.Size(195, 20);
            this.lblDataEnt.TabIndex = 3;
            this.lblDataEnt.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(306, 30);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(220, 26);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(306, 78);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 26);
            this.txtNome.TabIndex = 5;
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(306, 131);
            this.txtSalarioMensal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(220, 26);
            this.txtSalarioMensal.TabIndex = 6;
            // 
            // txtDataEnt
            // 
            this.txtDataEnt.Location = new System.Drawing.Point(306, 182);
            this.txtDataEnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataEnt.Name = "txtDataEnt";
            this.txtDataEnt.Size = new System.Drawing.Size(220, 26);
            this.txtDataEnt.TabIndex = 7;
            // 
            // btnMensalista
            // 
            this.btnMensalista.Location = new System.Drawing.Point(46, 282);
            this.btnMensalista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMensalista.Name = "btnMensalista";
            this.btnMensalista.Size = new System.Drawing.Size(220, 100);
            this.btnMensalista.TabIndex = 8;
            this.btnMensalista.Text = "Instanciar Mensalista";
            this.btnMensalista.UseVisualStyleBackColor = true;
            this.btnMensalista.Click += new System.EventHandler(this.btnMensalista_Click);
            // 
            // btnMensalistaPar
            // 
            this.btnMensalistaPar.Location = new System.Drawing.Point(306, 282);
            this.btnMensalistaPar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMensalistaPar.Name = "btnMensalistaPar";
            this.btnMensalistaPar.Size = new System.Drawing.Size(220, 100);
            this.btnMensalistaPar.TabIndex = 9;
            this.btnMensalistaPar.Text = "Instanciar Mensalista passando Parâmetros";
            this.btnMensalistaPar.UseVisualStyleBackColor = true;
            this.btnMensalistaPar.Click += new System.EventHandler(this.btnMensalistaPar_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 419);
            this.Controls.Add(this.btnMensalistaPar);
            this.Controls.Add(this.btnMensalista);
            this.Controls.Add(this.txtDataEnt);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEnt);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.Label lblDataEnt;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.TextBox txtDataEnt;
        private System.Windows.Forms.Button btnMensalista;
        private System.Windows.Forms.Button btnMensalistaPar;
    }
}