using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        double altura, pesoAtual, pesoIdeal;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPesoAtual.Clear();
            lblMensagem.Text = string.Empty;

            txtAltura.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtAltura.Text, out altura) &&
                double.TryParse(txtPesoAtual.Text, out pesoAtual))
                {
                    if (RbtnFem.Checked)
                    {
                        pesoIdeal = Math.Round((62.1 * altura) - 44.7, 2);
                    }

                    else if (RbtnMasc.Checked)
                    {
                        pesoIdeal = Math.Round((72.7 * altura) - 58, 2);
                    }

                    CalculaPesoIdeal(pesoAtual, pesoIdeal);
                }

                else
                {
                    MessageBox.Show("Valores Inválidos!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void CalculaPesoIdeal(double pesoAtual, double pesoIdeal)
        {
            if (pesoAtual == pesoIdeal)
            {
                lblMensagem.Text = "Você está com o peso ideal";
            }
            else if (pesoAtual > pesoIdeal)
            {
                lblMensagem.Text = "Regime Obrigatório Já";
            }
            else
            {
                lblMensagem.Text = "Coma bastante massas e doces";
            }
        }
    }
}
