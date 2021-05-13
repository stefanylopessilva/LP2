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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnNumeroH_Click(object sender, EventArgs e)
        {
            int numero;
            double numeroH = 0;
            numeroH.ToString("F2");

            Int32.TryParse(txtNumero.Text, out numero);

            if ((numero <= 0) || (txtNumero.Text == ""))
            {
                MessageBox.Show("Digite um valor válido maior que Zero");
            }

            for (double i = 1.0 ; i < numero; i++)
            {
                numeroH += (1 / i);
            }

            double numeroHFinal = numeroH + 1;

            MessageBox.Show("O valor do Número H é: " + numeroHFinal.ToString("F2"));

        }
    }
}
