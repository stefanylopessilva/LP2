using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PVacina0030482023025
{
    public partial class frmPrincipal : Form
    {

        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

       private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=pc-stefany\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True;Pooling=False");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros " + ex.Message);
            }
        } 

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobreBox objFrmSobre = new frmSobreBox();
            objFrmSobre.MdiParent = this;
            objFrmSobre.WindowState = FormWindowState.Maximized;
            objFrmSobre.Show();
        }

        private void cadastroVacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVacina ObjVacina = new frmVacina();
            ObjVacina.MdiParent = this;
            ObjVacina.WindowState = FormWindowState.Maximized;
            ObjVacina.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
