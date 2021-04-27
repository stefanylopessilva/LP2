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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemover1_Click(object sender, EventArgs e)
        {
            if ((txtPalavra1.Text == "") || (txtPalavra1.Text == ""))

                MessageBox.Show("Dados nao podem ser vazios");

            else
            {
                int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

                while (posicao >= 0)
                {
                    txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                        txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                        txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                    posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
                }
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            if ((txtPalavra1.Text == "") || (txtPalavra1.Text == ""))
            {
                MessageBox.Show("Dados nao podem ser vazios");
            }

            else
            {
                txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
            }
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            char[] texto = txtPalavra1.Text.ToCharArray();

            Array.Reverse(texto);

            foreach (char c in texto)
            {
                txtPalavra2.Text += c;
            }
        }
    }
}
