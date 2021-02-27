using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1
{
    public partial class Form1 : Form
    {
        double numero1, numero2, numero3, resultado;

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out numero1) &&
                double.TryParse(txtNumero2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                txtNumero3.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números Inválidos!");
            }
        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out numero1) &&
                double.TryParse(txtNumero2.Text, out numero2))
            {
                resultado = numero1 - numero2;
                txtNumero3.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números Inválidos!");
            }
        }

        private void ButtonMult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out numero1) &&
                double.TryParse(txtNumero2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                txtNumero3.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números Inválidos!");
            }
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out numero1) &&
                double.TryParse(txtNumero2.Text, out numero2))
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero!");
                }
                else
                {
                    resultado = numero1 + numero2;
                    txtNumero3.Text = resultado.ToString();
                }
            }
            else
            {
                MessageBox.Show("Números Inválidos!");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();

            txtNumero1.Focus();
        }
    }
}
