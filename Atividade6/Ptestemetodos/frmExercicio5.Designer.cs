
namespace Ptestemetodos
{
    partial class frmExercicio5
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnSortear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(221, 68);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(204, 26);
            this.txtNumero1.TabIndex = 0;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(41, 68);
            this.lblNumero1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(140, 20);
            this.lblNumero1.TabIndex = 1;
            this.lblNumero1.Text = "Digite o 1º número";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(41, 137);
            this.lblNumero2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(140, 20);
            this.lblNumero2.TabIndex = 2;
            this.lblNumero2.Text = "Digite o 2º número";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(221, 131);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(204, 26);
            this.txtNumero2.TabIndex = 3;
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(165, 187);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(130, 68);
            this.btnSortear.TabIndex = 4;
            this.btnSortear.Text = "Sortear 1 número";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 278);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.txtNumero1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnSortear;
    }
}