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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";
            string saida = "";

            for (var i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número da posição:" + (i + 1).ToString(), "Entrada de Dados");

                if (auxiliar == "")
                    break;

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }
                else
                {
                    saida = vetor[i] + "\n" + saida;
                }

            }

            MessageBox.Show(saida);
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";
            string saida = "";

            for (var i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número da posição:" + (i + 1).ToString(), "Entrada de Dados");

                if (auxiliar == "")
                    break;

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }

            }

            Array.Reverse(vetor);

            for (int i = 0; i < vetor.Length; i++)
            {
                saida += vetor.GetValue(i) + "\n";
            }

            MessageBox.Show(saida);
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            string[] meuArray = new string[10] { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thaís" };
            string texto = "";
            var lista = meuArray.ToList();
            lista.RemoveAt(6);
            meuArray = lista.ToArray();

            for (int i = 0; i < meuArray.Length; i++)
            {
                texto += meuArray[i] + "\n";
            }

            MessageBox.Show(texto);
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            string[] alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" }; 
            int i, total = 0; 
            int tamanho = alunos.Length; 

            for (i = 0; i < tamanho - 1; i++) 
            { 
                total += alunos[i].Length; 
            }

            MessageBox.Show("O total é: " + total.ToString());
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            int[] matrizQuantidade = new int[10];
            double[] matrizPreco = new double[10];
            double soma = 0;
            string quantidade = "";
            string preco = "";

            for (var i = 0; i < 10; i++)
            {
                quantidade = Interaction.InputBox("Digite a quantidade do produto " + (i + 1).ToString(), "Entrada de Dados");
                preco = Interaction.InputBox("Digite o número o preço do produto " + (i + 1).ToString(), "Entrada de Dados");

                if (quantidade == "" || preco == "")
                    break;

                if (!int.TryParse(quantidade, out matrizQuantidade[i]) || !double.TryParse(preco, out matrizPreco[i]))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }

                soma += matrizQuantidade[i] * matrizPreco[i];
            }

            MessageBox.Show("Valor do faturamento mensal: " + soma.ToString("C"));
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            double[,] matrizNotas = new double[20, 3];
            double[] mediaAluno = new double[20];
            string nota = "", saida = "";
            double somaNota = 0;


            for (var i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    nota = Interaction.InputBox("Digite a " + (j + 1).ToString() + "º nota do Aluno " + (i + 1).ToString(), "Entrada de Dados");

                    if (nota == "")
                        break;

                    if (!double.TryParse(nota, out matrizNotas[i, j]))
                    {
                        MessageBox.Show("Número inválido!");
                        i--;
                    }

                    somaNota += matrizNotas[i, j];
                }

                mediaAluno[i] = somaNota / 3;
                somaNota = 0;
            }

            for (int i = 0; i < mediaAluno.Length; i++)
            {
                saida += "Aluno "+ (i + 1) + ": média: " + mediaAluno.GetValue(i) + "\n";
            }

            MessageBox.Show(saida);
        }

        private void btnExercicio7_Click(object sender, EventArgs e)
        {
            frmExercicio7 FrmExercicio7 = new frmExercicio7();
            FrmExercicio7.Show();
        }
    }
}
