using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade8
{
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] nomesPessoas = new string[5];
            int[] quantCaracter = new int[5];
            string[] nomeSemEspacoBranco = new string[5];

            for (var i = 0; i < nomesPessoas.Length; i++)
            {
                nomesPessoas[i] = Interaction.InputBox("Digite o nome completo:" + (i + 1).ToString(), "Entrada de Dados");

                if (nomesPessoas[i] == "")
                    break;

                nomeSemEspacoBranco[i] = nomesPessoas[i].Replace(" ", "");
                quantCaracter[i] = nomeSemEspacoBranco[i].Length;

                listBox1.Items.Add("O nome: " + nomesPessoas[i] + " tem " + quantCaracter[i] + " caracteres." + "\n");
            }
        }
    }
}
