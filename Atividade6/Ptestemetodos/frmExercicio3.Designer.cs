﻿
namespace Ptestemetodos
{
    partial class frmExercicio3
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnRemover1 = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(28, 61);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(28, 112);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(182, 55);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(304, 26);
            this.txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(182, 109);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(304, 26);
            this.txtPalavra2.TabIndex = 3;
            // 
            // btnRemover1
            // 
            this.btnRemover1.Location = new System.Drawing.Point(32, 217);
            this.btnRemover1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemover1.Name = "btnRemover1";
            this.btnRemover1.Size = new System.Drawing.Size(148, 86);
            this.btnRemover1.TabIndex = 4;
            this.btnRemover1.Text = "Remove 1º do 2º";
            this.btnRemover1.UseVisualStyleBackColor = true;
            this.btnRemover1.Click += new System.EventHandler(this.btnRemover1_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(185, 217);
            this.btnRemove2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(148, 86);
            this.btnRemove2.TabIndex = 5;
            this.btnRemove2.Text = "Remove 1º do 2º (replace)";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverte.Location = new System.Drawing.Point(338, 217);
            this.btnInverte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(148, 86);
            this.btnInverte.TabIndex = 6;
            this.btnInverte.Text = "Inverte 1º";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 390);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnRemover1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnRemover1;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.Button btnInverte;
    }
}