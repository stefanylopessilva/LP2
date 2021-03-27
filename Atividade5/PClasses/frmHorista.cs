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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumeroHoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(msktxtData.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);

            MessageBox.Show("Nome: " + objHorista.NomeEmpregado + "\n" +
                            "Matrícula: " + objHorista.Matricula + "\n" +
                            "Tempo de Trabalho (dias): " + objHorista.TempoTrabalho().ToString() + "\n" +
                            "Salário: " + objHorista.SalarioBruto().ToString("N2"));

        }
    }
}
