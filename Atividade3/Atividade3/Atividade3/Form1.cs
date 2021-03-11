using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC;
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
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            lblTipoTriangulo.Text = string.Empty;

            txtLadoA.Focus();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtLadoA.Text, out ladoA) &&
                        double.TryParse(txtLadoB.Text, out ladoB) &&
                            double.TryParse(txtLadoC.Text, out ladoC) &&
                                VerificaSeETriangulo(ladoA, ladoB, ladoC))
                {
                    if (ladoA == ladoB && ladoA == ladoC)
                    {
                        lblTipoTriangulo.Text = "O triângulo é Equilátero";
                    }
                    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                    {
                        lblTipoTriangulo.Text = "O triângulo é Isóceles";
                    }
                    else
                    {
                        lblTipoTriangulo.Text = "O triângulo é Escaleno";
                    }
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

        private bool VerificaSeETriangulo(double ladoA, double ladoB, double ladoC)
        {
            if ((Math.Abs(ladoB - ladoC) < ladoA && ladoA < (ladoB + ladoC)) &&
                    (Math.Abs(ladoA - ladoC) < ladoB && ladoB < (ladoA + ladoC)) &&
                        (Math.Abs(ladoA - ladoB) < ladoC && ladoC < (ladoA + ladoB)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
