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

namespace P0030482023025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] matrizVendas = new double[5, 4];
            double totalVendas = 0, totalVendasGeral = 0;
            string vendas = "";

            for (var i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    vendas = Interaction.InputBox("Digite as vendas do mês " + (i + 1).ToString() + " da " + (j + 1).ToString() + "º semana: ", "Entrada de Dados");

                    if (vendas == "")
                        break;

                    if (!double.TryParse(vendas, out matrizVendas[i, j]))
                    {
                        MessageBox.Show("Valor inválido!");
                        j--;
                    }

                    else
                    {
                        lstValores.Items.Add("Total do mês: " + (i + 1).ToString() + " Semana: " + (j + 1).ToString() + " " + matrizVendas[i, j].ToString("C"));
                    }

                    totalVendas += matrizVendas[i, j];
                }

                lstValores.Items.Add(">> Total do mês: " + totalVendas.ToString("C"));
                lstValores.Items.Add("---------------------------------------------------");
                totalVendasGeral += totalVendas;
                totalVendas = 0;
            }

            lstValores.Items.Add(">> Total Geral: " + totalVendasGeral.ToString("C"));
        }
    }
}
