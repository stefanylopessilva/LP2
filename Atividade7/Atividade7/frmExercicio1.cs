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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspacoBranco_Click(object sender, EventArgs e)
        {
            char[] texto = rftTexto.Text.ToArray();
            int qtdEspacoBranco = 0, i = 0;

            foreach (char item in texto)
            {
                if (Char.IsWhiteSpace(rftTexto.Text, i))
                {
                    qtdEspacoBranco++;
                }
                i++;
            }

            MessageBox.Show("O número de espaços em branco na frase é: " + qtdEspacoBranco);
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            int tamanho = rftTexto.Text.Length;
            int qtdLetraR = 0;
            char[] texto = rftTexto.Text.ToArray();

            for (int i = 0; i < tamanho; i++)
            {
                if (texto[i] == char.Parse("R") || texto[i] == char.Parse("r"))
                {
                    qtdLetraR++;
                }
            }

            MessageBox.Show("O número de letras R na frase é: " + qtdLetraR);
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int tamanho = rftTexto.Text.Length;
            int qtdLetraRepetida = 0;
            int i = 0;
            char[] texto = rftTexto.Text.ToArray();

            while (i < tamanho - 1)
            {
                if (texto[i] == texto[i + 1])
                {
                    qtdLetraRepetida++;
                }

                i++;
            }

            MessageBox.Show("O número de pares de letras na frase é: " + qtdLetraRepetida);
        }
    }
}
