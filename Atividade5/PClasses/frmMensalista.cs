using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnMensalista_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEnt.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);

            MessageBox.Show("Matrícula            : " + objMensalista.Matricula + "\n" +
                            "Nome                 : " + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada         : " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salário Bruto        : " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo Empresa (dias) : " + objMensalista.TempoTrabalho());
        }

        private void btnMensalistaPar_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtMatricula.Text), txtNome.Text, Convert.ToDateTime(txtDataEnt.Text), Convert.ToDouble(txtSalarioMensal.Text));

            MessageBox.Show("Matrícula            : " + objMensalista.Matricula + "\n" +
                            "Nome                 : " + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada         : " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salário Bruto        : " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo Empresa (dias) : " + objMensalista.TempoTrabalho());
        }
    }
}
