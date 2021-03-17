using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        double descontoINSS = 0;
        double descontoIRPF = 0;
        double salarioFamilia = 0;
        double salarioLiquido = 0;
        double salarioBruto = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if ((mskbxNome.Text == "") || (mskbxNome.Text.Length < 10))
            {
                MessageBox.Show("Nome Inválido");
            }
            else if (double.TryParse(mskbxSalBruto.Text, out salarioBruto))
            {
                descontoINSS = CalculoINSS(salarioBruto);
            }
            else
            {
                MessageBox.Show("Salário Bruto Inválido");
            }

            CalculoIRPF(salarioBruto);

            CalculoSalarioFamilia(salarioBruto);

            CalculoSalarioLiquido(descontoINSS, descontoIRPF, salarioFamilia, salarioBruto);

            MensagemParaUsuario();
        }

        private void CalculoIRPF(double salarioBruto)
        {
            if (salarioBruto <= 1257.12)
            {
                txtAliqIRPF.Text = "0.00";
                descontoIRPF = 0.00;
                txtDescIRPF.Text = descontoIRPF.ToString();
            }
            else if (salarioBruto <= 2512.08)
            {
                txtAliqIRPF.Text = "15.00%";
                descontoIRPF = 0.15 * salarioBruto;
                txtDescIRPF.Text = descontoIRPF.ToString();
            }
            else
            {
                txtAliqIRPF.Text = "27.5%";
                descontoIRPF = 0.275 * salarioBruto;
                txtDescIRPF.Text = descontoIRPF.ToString();
            }
        }

        private double CalculoSalarioFamilia(double salarioBruto)
        {
            if (salarioBruto <= 435.52)
            {
                salarioFamilia = 22.33 * Convert.ToInt32(nudNumFilhos.Value);
                txtSalFamilia.Text = salarioFamilia.ToString();
            }
            else if (salarioBruto <= 654.61)
            {
                salarioFamilia = 15.74 * Convert.ToInt32(nudNumFilhos.Value);
                txtSalFamilia.Text = salarioFamilia.ToString();
            }
            else
            {
                salarioFamilia = 0.00;
                txtSalFamilia.Text = salarioFamilia.ToString();
            }

            return salarioFamilia;
        }

        private double CalculoSalarioLiquido(double descontoINSS, double descontoIRPF, double salarioFamilia, double salarioBruto)
        {
            salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;
            txtSalLiquido.Text = salarioLiquido.ToString();
            return salarioLiquido;
        }

        private void MensagemParaUsuario()
        {
            lblMensagem.Text = "Os descontos do salário ";

            if (rbtnFeminino.Checked)
            {
                lblMensagem.Text = lblMensagem.Text + "da Sra " + mskbxNome.Text;
            }
            else
            {
                lblMensagem.Text = lblMensagem.Text + "do Sr " + mskbxNome.Text;
            }

            lblMensagem.Text = lblMensagem.Text + " que é ";

            if (rbtnCasado.Checked)
            {
                lblMensagem.Text = lblMensagem.Text + "Casado(a) ";
            }
            else
            {
                lblMensagem.Text = lblMensagem.Text + "Solteiro(a) ";
            }

            if (nudNumFilhos.Value != 0)
            {
                lblMensagem.Text = lblMensagem.Text + "e possui " + nudNumFilhos.Value + " filho(s) são: ";
            }
            else
            {
                lblMensagem.Text = lblMensagem.Text + "são: ";
            }
        }

        private double CalculoINSS(double salarioBruto)
        {
            {
                if (salarioBruto <= 800.47)
                {
                    txtAliqINSS.Text = "7.65%";
                    descontoINSS = 0.0765 * salarioBruto;
                    txtDescINSS.Text = descontoINSS.ToString();
                }
                else if (salarioBruto <= 1050)
                {
                    txtAliqINSS.Text = "8.65%";
                    descontoINSS = 0.0865 * salarioBruto;
                    txtDescINSS.Text = descontoINSS.ToString();
                }
                else if (salarioBruto <= 1400.77)
                {
                    txtAliqINSS.Text = "9.00%";
                    descontoINSS = 0.09 * salarioBruto;
                    txtDescINSS.Text = descontoINSS.ToString();
                }
                else if (salarioBruto <= 2801.56)
                {
                    txtAliqINSS.Text = "11.00%";
                    descontoINSS = 0.11 * salarioBruto;
                    txtDescINSS.Text = descontoINSS.ToString();
                }
                else
                {
                    txtAliqINSS.Text = "R$308,17";
                    descontoINSS = 308.17;
                    txtDescINSS.Text = descontoINSS.ToString();
                }
            }
            return descontoINSS;
        }
    }
}
