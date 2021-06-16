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
    public partial class frmVacina : Form
    {
        private BindingSource bsVacina = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsVacina = new DataSet();
        private DataSet dsCidade = new DataSet();
        private DataSet dsEnfermeiro = new DataSet();

        public frmVacina()
        {
            InitializeComponent();
        }

        private void frmVacina_Load(object sender, EventArgs e)
        {
            try
            {
                Vacina Vac = new Vacina();
                dsVacina.Tables.Add(Vac.Listar());
                bsVacina.DataSource = dsVacina.Tables["VACINA"];
                bnVacina.BindingSource = bsVacina;
                dgVacina.DataSource = bsVacina;

                txtIdVacina.DataBindings.Add("Text", bsVacina, "id_vacina");
                txtNomeVacina.DataBindings.Add("Text", bsVacina, "nome_vacina");
                txtDataNascVacina.DataBindings.Add("Text", bsVacina, "datanasc_vacina");
                txtEnderecoVacina.DataBindings.Add("Text", bsVacina, "end_vacina");
                mskCpfVacina.DataBindings.Add("Text", bsVacina, "cpf_vacina");
                mskRgVacina.DataBindings.Add("Text", bsVacina, "rg_vacina");
                txtDataVacina.DataBindings.Add("Text", bsVacina, "data_vacina");
                cbxTipoVacina.DataBindings.Add("SelectedItem", bsVacina, "tipo_vacina");
                cbxComorbidade.DataBindings.Add("SelectedItem", bsVacina, "comorbidade_vacina");
                cbxPrioriVacina.DataBindings.Add("SelectedItem", bsVacina, "grupopriori_vacina");

                Cidade Cid = new Cidade(); 
                dsCidade.Tables.Add(Cid.Listar()); 
                cbxCidadeIdCidade.DataSource = dsCidade.Tables["Cidade"];
                cbxCidadeIdCidade.DisplayMember = "nome_cidade";
                cbxCidadeIdCidade.ValueMember = "id_cidade";
                cbxCidadeIdCidade.DataBindings.Add("SelectedValue", bsVacina, "cidade_id_cidade");

                Enfermeiro Enf = new Enfermeiro(); 
                dsEnfermeiro.Tables.Add(Enf.Listar()); 
                cbxEnfermeiro.DataSource = dsEnfermeiro.Tables["Enfermeiro"];
                cbxEnfermeiro.DisplayMember = "nome_enfermeiro";
                cbxEnfermeiro.ValueMember = "id_enfermeiro";
                cbxEnfermeiro.DataBindings.Add("SelectedValue", bsVacina, "enfermeiro_id_enfermeiro");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }
            bsVacina.AddNew();

            txtNomeVacina.Enabled = true;
            txtDataNascVacina.Enabled = true;
            txtEnderecoVacina.Enabled = true;
            cbxCidadeIdCidade.Enabled = true;
            mskCpfVacina.Enabled = true;
            mskRgVacina.Enabled = true;
            txtDataVacina.Enabled = true;
            cbxTipoVacina.Enabled = true;
            cbxComorbidade.Enabled = true;
            cbxPrioriVacina.Enabled = true;
            cbxEnfermeiro.Enabled = true;
            cbxCidadeIdCidade.SelectedIndex = 0;
            cbxEnfermeiro.SelectedIndex = 0;
            cbxTipoVacina.SelectedIndex = 0;
            cbxComorbidade.SelectedIndex = 0;
            cbxPrioriVacina.SelectedIndex = 0;

            btnIncluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime data;

            // validar os dados
            if (txtNomeVacina.Text == "")
                MessageBox.Show("Nome inválido!");
            else
            if (!DateTime.TryParse(txtDataNascVacina.Value.ToString(), out data))
                MessageBox.Show("Data inválida!");
            else
            if (mskCpfVacina.Text == "")
                MessageBox.Show("CPF inválido!");
            else
            if (mskRgVacina.Text == "")
                MessageBox.Show("RG inválido!");
            else
            if (!DateTime.TryParse(txtDataVacina.Value.ToString(), out data))
                MessageBox.Show("Data inválida!");
            else
            {
                Vacina RegVac = new Vacina();

                RegVac.NomeVacina = txtNomeVacina.Text;
                RegVac.EndVacina = txtEnderecoVacina.Text;
                RegVac.DataNascVacina = txtDataNascVacina.Value;
                RegVac.CidadeIdVacina = Convert.ToInt32(cbxCidadeIdCidade.SelectedValue.ToString());
                RegVac.CpfVacina = mskCpfVacina.Text;
                RegVac.RgVacina = mskRgVacina.Text;
                RegVac.DataVacina = txtDataVacina.Value;
                RegVac.TipoVacina = Convert.ToChar(cbxTipoVacina.SelectedItem.ToString());
                RegVac.GrupoPrioriVacina = Convert.ToChar(cbxPrioriVacina.SelectedItem.ToString());
                RegVac.ComorbidadeVacina = Convert.ToChar(cbxComorbidade.SelectedItem.ToString());
                RegVac.EnfermeiroIdEnfermeiro = Convert.ToInt32(cbxEnfermeiro.SelectedValue.ToString());

                if (bInclusao)
                {
                    if (RegVac.Salvar() > 0)
                    {
                        MessageBox.Show("Vacina adicionada com sucesso!");

                        txtNomeVacina.Enabled = false;
                        txtDataNascVacina.Enabled = false;
                        txtEnderecoVacina.Enabled = false;
                        cbxCidadeIdCidade.Enabled = false;
                        mskCpfVacina.Enabled = false;
                        mskRgVacina.Enabled = false;
                        txtDataVacina.Enabled = false;
                        cbxTipoVacina.Enabled = false;
                        cbxComorbidade.Enabled = false;
                        cbxPrioriVacina.Enabled = false;
                        cbxEnfermeiro.Enabled = false;

                        btnIncluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsVacina.Tables.Clear();
                        dsVacina.Tables.Add(RegVac.Listar());
                        bsVacina.DataSource = dsVacina.Tables["Vacina"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Vacina!"); 
                    }
                }
                else
                {
                    RegVac.IdVacina = Convert.ToInt32(txtIdVacina.Text);

                    if (RegVac.Alterar() > 0)
                    {
                        MessageBox.Show("Vacina alterada com sucesso!");

                        txtNomeVacina.Enabled = false;
                        txtDataNascVacina.Enabled = false;
                        txtEnderecoVacina.Enabled = false;
                        cbxCidadeIdCidade.Enabled = false;
                        mskCpfVacina.Enabled = false;
                        mskRgVacina.Enabled = false;
                        txtDataVacina.Enabled = false;
                        cbxTipoVacina.Enabled = false;
                        cbxComorbidade.Enabled = false;
                        cbxPrioriVacina.Enabled = false;
                        cbxEnfermeiro.Enabled = false;

                        btnIncluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        // recarrega o grid
                        dsVacina.Tables.Clear();
                        dsVacina.Tables.Add(RegVac.Listar());
                        bsVacina.DataSource = dsVacina.Tables["Vacina"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar Vacina!");
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }

            txtNomeVacina.Enabled = true;
            txtDataNascVacina.Enabled = true;
            txtEnderecoVacina.Enabled = true;
            cbxCidadeIdCidade.Enabled = true;
            mskCpfVacina.Enabled = true;
            mskRgVacina.Enabled = true;
            txtDataVacina.Enabled = true;
            cbxTipoVacina.Enabled = true;
            cbxComorbidade.Enabled = true;
            cbxPrioriVacina.Enabled = true;
            cbxEnfermeiro.Enabled = true;
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }

            if (MessageBox.Show("Confirma exclusão?", "Sim or Não", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Vacina RegVac = new Vacina();
                RegVac.IdVacina = Convert.ToInt32(txtIdVacina.Text);

                if (RegVac.Excluir() > 0)
                {
                    MessageBox.Show("Vacina excluída com sucesso!");

                    // recarrega o grid
                    dsVacina.Tables.Clear();
                    dsVacina.Tables.Add(RegVac.Listar());
                    bsVacina.DataSource = dsVacina.Tables["Vacina"];
                }

                else
                    MessageBox.Show("Erro ao excluir vacina!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bsVacina.CancelEdit();

            txtNomeVacina.Enabled = false;
            txtDataNascVacina.Enabled = false;
            txtEnderecoVacina.Enabled = false;
            cbxCidadeIdCidade.Enabled = false;
            mskCpfVacina.Enabled = false;
            mskRgVacina.Enabled = false;
            txtDataVacina.Enabled = false;
            cbxTipoVacina.Enabled = false;
            cbxComorbidade.Enabled = false;
            cbxPrioriVacina.Enabled = false;
            cbxEnfermeiro.Enabled = false;

            btnIncluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;

            bInclusao = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
