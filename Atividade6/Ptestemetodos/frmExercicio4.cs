using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumerico_Click(object sender, EventArgs e)
        {
            int qtdCaractere = rtfTexto.Text.Length;
            int qtdNumerico = 0;

            for (int i = 0; i < qtdCaractere; i++)
            {
                char[] caractere = rtfTexto.Text.ToCharArray();

                if (Char.IsNumber(caractere[i]))
                {
                    qtdNumerico++;
                }
            }

            MessageBox.Show("Existem " + qtdNumerico + " número(s) no texto.");
        }

        private void btnPosicao_Click(object sender, EventArgs e)
        {
            int posicao = 0, i = 0;

            while (!Char.IsWhiteSpace(rtfTexto.Text, i))
            {
                posicao++;
                i++;
            }

            MessageBox.Show("O primeiro espaço em branco está na posição " + posicao);
        }

        private void btnAlfabetico_Click(object sender, EventArgs e)
        {
            char[] texto = rtfTexto.Text.ToCharArray();
            int qtdAlfabetico = 0;

            foreach (char item in texto)
            {
                if (Char.IsLetter(item))
                {
                    qtdAlfabetico++;
                }
            }

            MessageBox.Show("Existem " + qtdAlfabetico + " letra(s) no texto.");
        }
    }
}
