using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnSalarioBruto_Click(object sender, EventArgs e)
        {
            double A, gratific, salarioBruto;
            int producao;

            double.TryParse(mskSalario.Text, out A);
            double.TryParse(mskGratificacao.Text, out gratific);
            Int32.TryParse(txtProducao.Text, out producao);

            if (producao > 100 && producao < 120)
            {
                salarioBruto = A + A * (0.05 * 1) + gratific;
            }
            else if (producao > 120 && producao < 150)
            {
                salarioBruto = A + A * (0.05 * 1 + 0.1 * 1) + gratific;
            }
            else if (producao >= 150)
            {
                salarioBruto = A + A * (0.05 * 1 + 0.1 * 1 + 0.1 * 1) + gratific;
            }
            else
            {
                salarioBruto = A;
            }

            /*if (salarioBruto > 7000 && producao >= 150 && gratific > 0)
            {
                salarioBruto = salarioBruto;
            }
            else
            {
                salarioBruto = 7000;
            }*/

            MessageBox.Show("Valor do Salário Bruto: " + salarioBruto.ToString("C"));
        }
    }
}
