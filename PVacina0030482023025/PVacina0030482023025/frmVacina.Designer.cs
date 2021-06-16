
namespace PVacina0030482023025
{
    partial class frmVacina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacina));
            this.bnVacina = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.btnIncluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tbVacina = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgVacina = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxEnfermeiro = new System.Windows.Forms.ComboBox();
            this.cbxCidadeIdCidade = new System.Windows.Forms.ComboBox();
            this.cbxPrioriVacina = new System.Windows.Forms.ComboBox();
            this.cbxComorbidade = new System.Windows.Forms.ComboBox();
            this.cbxTipoVacina = new System.Windows.Forms.ComboBox();
            this.txtDataVacina = new System.Windows.Forms.DateTimePicker();
            this.mskRgVacina = new System.Windows.Forms.MaskedTextBox();
            this.mskCpfVacina = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoVacina = new System.Windows.Forms.TextBox();
            this.lblEnfermeiroVacina = new System.Windows.Forms.Label();
            this.lblPrioriVacina = new System.Windows.Forms.Label();
            this.lblComorbidadeVacina = new System.Windows.Forms.Label();
            this.lblTipoVacina = new System.Windows.Forms.Label();
            this.lblDataVacinacao = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEnderecoVacina = new System.Windows.Forms.Label();
            this.txtNomeVacina = new System.Windows.Forms.TextBox();
            this.txtIdVacina = new System.Windows.Forms.TextBox();
            this.txtDataNascVacina = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascVacina = new System.Windows.Forms.Label();
            this.lblNomeVacina = new System.Windows.Forms.Label();
            this.lblIdVacina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnVacina)).BeginInit();
            this.bnVacina.SuspendLayout();
            this.tbVacina.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVacina)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnVacina
            // 
            this.bnVacina.AddNewItem = null;
            this.bnVacina.CountItem = this.bindingNavigatorCountItem;
            this.bnVacina.DeleteItem = null;
            this.bnVacina.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.btnIncluir,
            this.btnSalvar,
            this.btnAlterar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnSair});
            this.bnVacina.Location = new System.Drawing.Point(0, 0);
            this.bnVacina.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnVacina.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnVacina.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnVacina.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnVacina.Name = "bnVacina";
            this.bnVacina.PositionItem = this.bindingNavigatorPositionItem;
            this.bnVacina.Size = new System.Drawing.Size(1111, 25);
            this.bnVacina.TabIndex = 0;
            this.bnVacina.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // btnIncluir
            // 
            this.btnIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(23, 22);
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbVacina
            // 
            this.tbVacina.Controls.Add(this.tabPage1);
            this.tbVacina.Controls.Add(this.tabPage2);
            this.tbVacina.Location = new System.Drawing.Point(12, 45);
            this.tbVacina.Name = "tbVacina";
            this.tbVacina.SelectedIndex = 0;
            this.tbVacina.Size = new System.Drawing.Size(778, 319);
            this.tbVacina.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgVacina);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgVacina
            // 
            this.dgVacina.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVacina.Location = new System.Drawing.Point(6, 6);
            this.dgVacina.Name = "dgVacina";
            this.dgVacina.Size = new System.Drawing.Size(758, 281);
            this.dgVacina.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Moccasin;
            this.tabPage2.Controls.Add(this.cbxEnfermeiro);
            this.tabPage2.Controls.Add(this.cbxCidadeIdCidade);
            this.tabPage2.Controls.Add(this.cbxPrioriVacina);
            this.tabPage2.Controls.Add(this.cbxComorbidade);
            this.tabPage2.Controls.Add(this.cbxTipoVacina);
            this.tabPage2.Controls.Add(this.txtDataVacina);
            this.tabPage2.Controls.Add(this.mskRgVacina);
            this.tabPage2.Controls.Add(this.mskCpfVacina);
            this.tabPage2.Controls.Add(this.txtEnderecoVacina);
            this.tabPage2.Controls.Add(this.lblEnfermeiroVacina);
            this.tabPage2.Controls.Add(this.lblPrioriVacina);
            this.tabPage2.Controls.Add(this.lblComorbidadeVacina);
            this.tabPage2.Controls.Add(this.lblTipoVacina);
            this.tabPage2.Controls.Add(this.lblDataVacinacao);
            this.tabPage2.Controls.Add(this.lblRg);
            this.tabPage2.Controls.Add(this.lblCpf);
            this.tabPage2.Controls.Add(this.lblCidade);
            this.tabPage2.Controls.Add(this.lblEnderecoVacina);
            this.tabPage2.Controls.Add(this.txtNomeVacina);
            this.tabPage2.Controls.Add(this.txtIdVacina);
            this.tabPage2.Controls.Add(this.txtDataNascVacina);
            this.tabPage2.Controls.Add(this.lblDataNascVacina);
            this.tabPage2.Controls.Add(this.lblNomeVacina);
            this.tabPage2.Controls.Add(this.lblIdVacina);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhes";
            // 
            // cbxEnfermeiro
            // 
            this.cbxEnfermeiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnfermeiro.Enabled = false;
            this.cbxEnfermeiro.FormattingEnabled = true;
            this.cbxEnfermeiro.Location = new System.Drawing.Point(576, 177);
            this.cbxEnfermeiro.Name = "cbxEnfermeiro";
            this.cbxEnfermeiro.Size = new System.Drawing.Size(148, 21);
            this.cbxEnfermeiro.TabIndex = 25;
            // 
            // cbxCidadeIdCidade
            // 
            this.cbxCidadeIdCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidadeIdCidade.Enabled = false;
            this.cbxCidadeIdCidade.FormattingEnabled = true;
            this.cbxCidadeIdCidade.Location = new System.Drawing.Point(130, 141);
            this.cbxCidadeIdCidade.Name = "cbxCidadeIdCidade";
            this.cbxCidadeIdCidade.Size = new System.Drawing.Size(163, 21);
            this.cbxCidadeIdCidade.TabIndex = 24;
            // 
            // cbxPrioriVacina
            // 
            this.cbxPrioriVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrioriVacina.Enabled = false;
            this.cbxPrioriVacina.FormattingEnabled = true;
            this.cbxPrioriVacina.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxPrioriVacina.Location = new System.Drawing.Point(576, 143);
            this.cbxPrioriVacina.Name = "cbxPrioriVacina";
            this.cbxPrioriVacina.Size = new System.Drawing.Size(148, 21);
            this.cbxPrioriVacina.TabIndex = 22;
            // 
            // cbxComorbidade
            // 
            this.cbxComorbidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComorbidade.Enabled = false;
            this.cbxComorbidade.FormattingEnabled = true;
            this.cbxComorbidade.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxComorbidade.Location = new System.Drawing.Point(576, 108);
            this.cbxComorbidade.Name = "cbxComorbidade";
            this.cbxComorbidade.Size = new System.Drawing.Size(148, 21);
            this.cbxComorbidade.TabIndex = 21;
            // 
            // cbxTipoVacina
            // 
            this.cbxTipoVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVacina.Enabled = false;
            this.cbxTipoVacina.FormattingEnabled = true;
            this.cbxTipoVacina.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxTipoVacina.Location = new System.Drawing.Point(576, 78);
            this.cbxTipoVacina.Name = "cbxTipoVacina";
            this.cbxTipoVacina.Size = new System.Drawing.Size(148, 21);
            this.cbxTipoVacina.TabIndex = 20;
            // 
            // txtDataVacina
            // 
            this.txtDataVacina.Enabled = false;
            this.txtDataVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataVacina.Location = new System.Drawing.Point(576, 49);
            this.txtDataVacina.Name = "txtDataVacina";
            this.txtDataVacina.Size = new System.Drawing.Size(148, 20);
            this.txtDataVacina.TabIndex = 19;
            // 
            // mskRgVacina
            // 
            this.mskRgVacina.Enabled = false;
            this.mskRgVacina.Location = new System.Drawing.Point(576, 17);
            this.mskRgVacina.Mask = "999999999";
            this.mskRgVacina.Name = "mskRgVacina";
            this.mskRgVacina.Size = new System.Drawing.Size(148, 20);
            this.mskRgVacina.TabIndex = 18;
            // 
            // mskCpfVacina
            // 
            this.mskCpfVacina.Enabled = false;
            this.mskCpfVacina.Location = new System.Drawing.Point(130, 174);
            this.mskCpfVacina.Mask = "99999999999";
            this.mskCpfVacina.Name = "mskCpfVacina";
            this.mskCpfVacina.Size = new System.Drawing.Size(163, 20);
            this.mskCpfVacina.TabIndex = 17;
            // 
            // txtEnderecoVacina
            // 
            this.txtEnderecoVacina.Enabled = false;
            this.txtEnderecoVacina.Location = new System.Drawing.Point(130, 106);
            this.txtEnderecoVacina.Name = "txtEnderecoVacina";
            this.txtEnderecoVacina.Size = new System.Drawing.Size(163, 20);
            this.txtEnderecoVacina.TabIndex = 15;
            // 
            // lblEnfermeiroVacina
            // 
            this.lblEnfermeiroVacina.AutoSize = true;
            this.lblEnfermeiroVacina.Location = new System.Drawing.Point(309, 177);
            this.lblEnfermeiroVacina.Name = "lblEnfermeiroVacina";
            this.lblEnfermeiroVacina.Size = new System.Drawing.Size(57, 13);
            this.lblEnfermeiroVacina.TabIndex = 14;
            this.lblEnfermeiroVacina.Text = "Enfermeiro";
            // 
            // lblPrioriVacina
            // 
            this.lblPrioriVacina.AutoSize = true;
            this.lblPrioriVacina.Location = new System.Drawing.Point(309, 146);
            this.lblPrioriVacina.Name = "lblPrioriVacina";
            this.lblPrioriVacina.Size = new System.Drawing.Size(82, 13);
            this.lblPrioriVacina.TabIndex = 13;
            this.lblPrioriVacina.Text = "Grupo Prioritário";
            // 
            // lblComorbidadeVacina
            // 
            this.lblComorbidadeVacina.AutoSize = true;
            this.lblComorbidadeVacina.Location = new System.Drawing.Point(309, 117);
            this.lblComorbidadeVacina.Name = "lblComorbidadeVacina";
            this.lblComorbidadeVacina.Size = new System.Drawing.Size(103, 13);
            this.lblComorbidadeVacina.TabIndex = 12;
            this.lblComorbidadeVacina.Text = "Possui Comorbidade";
            // 
            // lblTipoVacina
            // 
            this.lblTipoVacina.AutoSize = true;
            this.lblTipoVacina.Location = new System.Drawing.Point(309, 85);
            this.lblTipoVacina.Name = "lblTipoVacina";
            this.lblTipoVacina.Size = new System.Drawing.Size(252, 13);
            this.lblTipoVacina.TabIndex = 11;
            this.lblTipoVacina.Text = "Tipo Vacina (1- Coronavac 2- Astrazeneca 3- Pfizer)";
            // 
            // lblDataVacinacao
            // 
            this.lblDataVacinacao.AutoSize = true;
            this.lblDataVacinacao.Location = new System.Drawing.Point(309, 56);
            this.lblDataVacinacao.Name = "lblDataVacinacao";
            this.lblDataVacinacao.Size = new System.Drawing.Size(84, 13);
            this.lblDataVacinacao.TabIndex = 10;
            this.lblDataVacinacao.Text = "Data Vacinação";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(309, 24);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 9;
            this.lblRg.Text = "RG";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(32, 177);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 8;
            this.lblCpf.Text = "CPF";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(32, 144);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 7;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEnderecoVacina
            // 
            this.lblEnderecoVacina.AutoSize = true;
            this.lblEnderecoVacina.Location = new System.Drawing.Point(32, 113);
            this.lblEnderecoVacina.Name = "lblEnderecoVacina";
            this.lblEnderecoVacina.Size = new System.Drawing.Size(53, 13);
            this.lblEnderecoVacina.TabIndex = 6;
            this.lblEnderecoVacina.Text = "Endereço";
            // 
            // txtNomeVacina
            // 
            this.txtNomeVacina.Enabled = false;
            this.txtNomeVacina.Location = new System.Drawing.Point(130, 45);
            this.txtNomeVacina.Name = "txtNomeVacina";
            this.txtNomeVacina.Size = new System.Drawing.Size(163, 20);
            this.txtNomeVacina.TabIndex = 5;
            // 
            // txtIdVacina
            // 
            this.txtIdVacina.Enabled = false;
            this.txtIdVacina.Location = new System.Drawing.Point(130, 21);
            this.txtIdVacina.Name = "txtIdVacina";
            this.txtIdVacina.Size = new System.Drawing.Size(163, 20);
            this.txtIdVacina.TabIndex = 4;
            // 
            // txtDataNascVacina
            // 
            this.txtDataNascVacina.CustomFormat = "";
            this.txtDataNascVacina.Enabled = false;
            this.txtDataNascVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataNascVacina.Location = new System.Drawing.Point(130, 77);
            this.txtDataNascVacina.Name = "txtDataNascVacina";
            this.txtDataNascVacina.Size = new System.Drawing.Size(163, 20);
            this.txtDataNascVacina.TabIndex = 3;
            // 
            // lblDataNascVacina
            // 
            this.lblDataNascVacina.AutoSize = true;
            this.lblDataNascVacina.Location = new System.Drawing.Point(32, 84);
            this.lblDataNascVacina.Name = "lblDataNascVacina";
            this.lblDataNascVacina.Size = new System.Drawing.Size(89, 13);
            this.lblDataNascVacina.TabIndex = 2;
            this.lblDataNascVacina.Text = "Data Nascimento";
            // 
            // lblNomeVacina
            // 
            this.lblNomeVacina.AutoSize = true;
            this.lblNomeVacina.Location = new System.Drawing.Point(32, 52);
            this.lblNomeVacina.Name = "lblNomeVacina";
            this.lblNomeVacina.Size = new System.Drawing.Size(38, 13);
            this.lblNomeVacina.TabIndex = 1;
            this.lblNomeVacina.Text = "Nome ";
            // 
            // lblIdVacina
            // 
            this.lblIdVacina.AutoSize = true;
            this.lblIdVacina.Location = new System.Drawing.Point(32, 24);
            this.lblIdVacina.Name = "lblIdVacina";
            this.lblIdVacina.Size = new System.Drawing.Size(18, 13);
            this.lblIdVacina.TabIndex = 0;
            this.lblIdVacina.Text = "ID";
            // 
            // frmVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1111, 376);
            this.Controls.Add(this.tbVacina);
            this.Controls.Add(this.bnVacina);
            this.Name = "frmVacina";
            this.Text = "frmVacina";
            this.Load += new System.EventHandler(this.frmVacina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnVacina)).EndInit();
            this.bnVacina.ResumeLayout(false);
            this.bnVacina.PerformLayout();
            this.tbVacina.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVacina)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnVacina;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tbVacina;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgVacina;
        private System.Windows.Forms.ToolStripButton btnIncluir;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ComboBox cbxPrioriVacina;
        private System.Windows.Forms.ComboBox cbxComorbidade;
        private System.Windows.Forms.ComboBox cbxTipoVacina;
        private System.Windows.Forms.DateTimePicker txtDataVacina;
        private System.Windows.Forms.MaskedTextBox mskRgVacina;
        private System.Windows.Forms.MaskedTextBox mskCpfVacina;
        private System.Windows.Forms.TextBox txtEnderecoVacina;
        private System.Windows.Forms.Label lblEnfermeiroVacina;
        private System.Windows.Forms.Label lblPrioriVacina;
        private System.Windows.Forms.Label lblComorbidadeVacina;
        private System.Windows.Forms.Label lblTipoVacina;
        private System.Windows.Forms.Label lblDataVacinacao;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEnderecoVacina;
        private System.Windows.Forms.TextBox txtNomeVacina;
        private System.Windows.Forms.TextBox txtIdVacina;
        private System.Windows.Forms.DateTimePicker txtDataNascVacina;
        private System.Windows.Forms.Label lblDataNascVacina;
        private System.Windows.Forms.Label lblNomeVacina;
        private System.Windows.Forms.Label lblIdVacina;
        private System.Windows.Forms.ComboBox cbxEnfermeiro;
        private System.Windows.Forms.ComboBox cbxCidadeIdCidade;
    }
}