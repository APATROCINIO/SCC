namespace SCC
{
    partial class frmCadChamados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadChamados));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridChamados = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItemChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsItemChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsItemTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomePesqisa = new System.Windows.Forms.TextBox();
            this.pnlChamadoCelular = new System.Windows.Forms.Panel();
            this.grbChip = new System.Windows.Forms.GroupBox();
            this.rdbChipNao = new System.Windows.Forms.RadioButton();
            this.rdbChipSim = new System.Windows.Forms.RadioButton();
            this.grbCartaoMemoria = new System.Windows.Forms.GroupBox();
            this.rdbCartaoMemoriaNao = new System.Windows.Forms.RadioButton();
            this.rdbCartaoMemoriaSim = new System.Windows.Forms.RadioButton();
            this.grbCarregador = new System.Windows.Forms.GroupBox();
            this.rdbCarregadorNao = new System.Windows.Forms.RadioButton();
            this.rdbCarregadorSim = new System.Windows.Forms.RadioButton();
            this.gbrTipoChamado = new System.Windows.Forms.GroupBox();
            this.rdbtipoChamadoCelular = new System.Windows.Forms.RadioButton();
            this.rdbTipoChamadoManutencao = new System.Windows.Forms.RadioButton();
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.Slecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlChamadoProduto = new System.Windows.Forms.Panel();
            this.pnlChamadoPadrao = new System.Windows.Forms.Panel();
            this.grbComputer = new System.Windows.Forms.GroupBox();
            this.rtxMarcaModeloSerie = new System.Windows.Forms.RichTextBox();
            this.gbrNoteBook = new System.Windows.Forms.GroupBox();
            this.rdbCarregadorNoteNao = new System.Windows.Forms.RadioButton();
            this.rdbCarregadorNoteSim = new System.Windows.Forms.RadioButton();
            this.pnlObsAtendente = new System.Windows.Forms.Panel();
            this.rtxObsAtendente = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamados)).BeginInit();
            this.pnlChamadoCelular.SuspendLayout();
            this.grbChip.SuspendLayout();
            this.grbCartaoMemoria.SuspendLayout();
            this.grbCarregador.SuspendLayout();
            this.gbrTipoChamado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            this.pnlChamadoProduto.SuspendLayout();
            this.pnlChamadoPadrao.SuspendLayout();
            this.grbComputer.SuspendLayout();
            this.gbrNoteBook.SuspendLayout();
            this.pnlObsAtendente.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar,
            this.toolStripSeparator1,
            this.btnCancelar,
            this.btnExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Novo Usuário";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar Usuário";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar Usuário";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Data Cadastro";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblCodigo.Location = new System.Drawing.Point(85, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(28, 24);
            this.lblCodigo.TabIndex = 97;
            this.lblCodigo.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 96;
            this.label1.Text = "Código";
            // 
            // maskDataCadastro
            // 
            this.maskDataCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.maskDataCadastro.Enabled = false;
            this.maskDataCadastro.Location = new System.Drawing.Point(732, 46);
            this.maskDataCadastro.Mask = "00/00/0000";
            this.maskDataCadastro.Name = "maskDataCadastro";
            this.maskDataCadastro.ReadOnly = true;
            this.maskDataCadastro.Size = new System.Drawing.Size(91, 20);
            this.maskDataCadastro.TabIndex = 99;
            this.maskDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Controls.Add(this.textBox1);
            this.pnlCabecalho.Controls.Add(this.label2);
            this.pnlCabecalho.Controls.Add(this.dataGridClientes);
            this.pnlCabecalho.Location = new System.Drawing.Point(6, 107);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(417, 159);
            this.pnlCabecalho.TabIndex = 104;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Cliente";
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.Column1,
            this.Column2});
            this.dataGridClientes.Location = new System.Drawing.Point(3, 26);
            this.dataGridClientes.MultiSelect = false;
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.Size = new System.Drawing.Size(410, 130);
            this.dataGridClientes.TabIndex = 103;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Width = 60;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idCliente";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NomeCliente";
            this.Column2.HeaderText = "Cliente";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Controls.Add(this.dataGridChamados);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtNomePesqisa);
            this.panel2.Location = new System.Drawing.Point(6, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 146);
            this.panel2.TabIndex = 109;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(137, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(72, 25);
            this.btnPesquisar.TabIndex = 99;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridChamados
            // 
            this.dataGridChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.idCliente,
            this.idItemChamado,
            this.ObsItemChamado,
            this.ObsItemTecnico,
            this.ValorItem,
            this.Column7,
            this.Column6,
            this.Column8,
            this.Column9});
            this.dataGridChamados.Location = new System.Drawing.Point(3, 48);
            this.dataGridChamados.Name = "dataGridChamados";
            this.dataGridChamados.Size = new System.Drawing.Size(832, 95);
            this.dataGridChamados.TabIndex = 98;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "idChamado";
            this.Column5.HeaderText = "Cód Chamado";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // idItemChamado
            // 
            this.idItemChamado.DataPropertyName = "idItemChamado";
            this.idItemChamado.HeaderText = "idItemChamado";
            this.idItemChamado.Name = "idItemChamado";
            this.idItemChamado.ReadOnly = true;
            this.idItemChamado.Visible = false;
            // 
            // ObsItemChamado
            // 
            this.ObsItemChamado.DataPropertyName = "ObsItemChamado";
            this.ObsItemChamado.HeaderText = "ObsItemChamado";
            this.ObsItemChamado.Name = "ObsItemChamado";
            this.ObsItemChamado.ReadOnly = true;
            this.ObsItemChamado.Visible = false;
            // 
            // ObsItemTecnico
            // 
            this.ObsItemTecnico.DataPropertyName = "ObsItemTecnico";
            this.ObsItemTecnico.HeaderText = "ObsItemTecnico";
            this.ObsItemTecnico.Name = "ObsItemTecnico";
            this.ObsItemTecnico.ReadOnly = true;
            this.ObsItemTecnico.Visible = false;
            // 
            // ValorItem
            // 
            this.ValorItem.DataPropertyName = "ValorItem";
            this.ValorItem.HeaderText = "ValorItem";
            this.ValorItem.Name = "ValorItem";
            this.ValorItem.ReadOnly = true;
            this.ValorItem.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NomeCliente";
            this.Column7.HeaderText = "Cliente";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 160;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "idProduto";
            this.Column6.HeaderText = "Cód Produto";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NomeProduto";
            this.Column8.HeaderText = "Produto";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 160;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DataAtendimento";
            this.Column9.HeaderText = "Data Atendimento";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Pesquisar Chamado";
            // 
            // txtNomePesqisa
            // 
            this.txtNomePesqisa.Location = new System.Drawing.Point(5, 22);
            this.txtNomePesqisa.Name = "txtNomePesqisa";
            this.txtNomePesqisa.Size = new System.Drawing.Size(127, 20);
            this.txtNomePesqisa.TabIndex = 96;
            // 
            // pnlChamadoCelular
            // 
            this.pnlChamadoCelular.Controls.Add(this.grbChip);
            this.pnlChamadoCelular.Controls.Add(this.grbCartaoMemoria);
            this.pnlChamadoCelular.Controls.Add(this.grbCarregador);
            this.pnlChamadoCelular.Enabled = false;
            this.pnlChamadoCelular.Location = new System.Drawing.Point(232, 269);
            this.pnlChamadoCelular.Name = "pnlChamadoCelular";
            this.pnlChamadoCelular.Size = new System.Drawing.Size(191, 160);
            this.pnlChamadoCelular.TabIndex = 110;
            // 
            // grbChip
            // 
            this.grbChip.Controls.Add(this.rdbChipNao);
            this.grbChip.Controls.Add(this.rdbChipSim);
            this.grbChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChip.Location = new System.Drawing.Point(8, 107);
            this.grbChip.Name = "grbChip";
            this.grbChip.Size = new System.Drawing.Size(177, 46);
            this.grbChip.TabIndex = 3;
            this.grbChip.TabStop = false;
            this.grbChip.Text = "Possui Chip";
            // 
            // rdbChipNao
            // 
            this.rdbChipNao.AutoSize = true;
            this.rdbChipNao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbChipNao.Location = new System.Drawing.Point(116, 23);
            this.rdbChipNao.Name = "rdbChipNao";
            this.rdbChipNao.Size = new System.Drawing.Size(48, 17);
            this.rdbChipNao.TabIndex = 2;
            this.rdbChipNao.TabStop = true;
            this.rdbChipNao.Text = "Não";
            this.rdbChipNao.UseVisualStyleBackColor = true;
            // 
            // rdbChipSim
            // 
            this.rdbChipSim.AutoSize = true;
            this.rdbChipSim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbChipSim.Location = new System.Drawing.Point(10, 23);
            this.rdbChipSim.Name = "rdbChipSim";
            this.rdbChipSim.Size = new System.Drawing.Size(45, 17);
            this.rdbChipSim.TabIndex = 1;
            this.rdbChipSim.TabStop = true;
            this.rdbChipSim.Text = "Sim";
            this.rdbChipSim.UseVisualStyleBackColor = true;
            // 
            // grbCartaoMemoria
            // 
            this.grbCartaoMemoria.Controls.Add(this.rdbCartaoMemoriaNao);
            this.grbCartaoMemoria.Controls.Add(this.rdbCartaoMemoriaSim);
            this.grbCartaoMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCartaoMemoria.Location = new System.Drawing.Point(10, 56);
            this.grbCartaoMemoria.Name = "grbCartaoMemoria";
            this.grbCartaoMemoria.Size = new System.Drawing.Size(177, 46);
            this.grbCartaoMemoria.TabIndex = 1;
            this.grbCartaoMemoria.TabStop = false;
            this.grbCartaoMemoria.Text = "Possui Cartão de Memória";
            // 
            // rdbCartaoMemoriaNao
            // 
            this.rdbCartaoMemoriaNao.AutoSize = true;
            this.rdbCartaoMemoriaNao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbCartaoMemoriaNao.Location = new System.Drawing.Point(114, 23);
            this.rdbCartaoMemoriaNao.Name = "rdbCartaoMemoriaNao";
            this.rdbCartaoMemoriaNao.Size = new System.Drawing.Size(48, 17);
            this.rdbCartaoMemoriaNao.TabIndex = 2;
            this.rdbCartaoMemoriaNao.TabStop = true;
            this.rdbCartaoMemoriaNao.Text = "Não";
            this.rdbCartaoMemoriaNao.UseVisualStyleBackColor = true;
            // 
            // rdbCartaoMemoriaSim
            // 
            this.rdbCartaoMemoriaSim.AutoSize = true;
            this.rdbCartaoMemoriaSim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbCartaoMemoriaSim.Location = new System.Drawing.Point(8, 23);
            this.rdbCartaoMemoriaSim.Name = "rdbCartaoMemoriaSim";
            this.rdbCartaoMemoriaSim.Size = new System.Drawing.Size(45, 17);
            this.rdbCartaoMemoriaSim.TabIndex = 1;
            this.rdbCartaoMemoriaSim.TabStop = true;
            this.rdbCartaoMemoriaSim.Text = "Sim";
            this.rdbCartaoMemoriaSim.UseVisualStyleBackColor = true;
            // 
            // grbCarregador
            // 
            this.grbCarregador.Controls.Add(this.rdbCarregadorNao);
            this.grbCarregador.Controls.Add(this.rdbCarregadorSim);
            this.grbCarregador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCarregador.Location = new System.Drawing.Point(8, 3);
            this.grbCarregador.Name = "grbCarregador";
            this.grbCarregador.Size = new System.Drawing.Size(177, 46);
            this.grbCarregador.TabIndex = 0;
            this.grbCarregador.TabStop = false;
            this.grbCarregador.Text = "Possui Carregador";
            // 
            // rdbCarregadorNao
            // 
            this.rdbCarregadorNao.AutoSize = true;
            this.rdbCarregadorNao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbCarregadorNao.Location = new System.Drawing.Point(116, 23);
            this.rdbCarregadorNao.Name = "rdbCarregadorNao";
            this.rdbCarregadorNao.Size = new System.Drawing.Size(48, 17);
            this.rdbCarregadorNao.TabIndex = 2;
            this.rdbCarregadorNao.TabStop = true;
            this.rdbCarregadorNao.Text = "Não";
            this.rdbCarregadorNao.UseVisualStyleBackColor = true;
            // 
            // rdbCarregadorSim
            // 
            this.rdbCarregadorSim.AutoSize = true;
            this.rdbCarregadorSim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbCarregadorSim.Location = new System.Drawing.Point(10, 23);
            this.rdbCarregadorSim.Name = "rdbCarregadorSim";
            this.rdbCarregadorSim.Size = new System.Drawing.Size(45, 17);
            this.rdbCarregadorSim.TabIndex = 1;
            this.rdbCarregadorSim.TabStop = true;
            this.rdbCarregadorSim.Text = "Sim";
            this.rdbCarregadorSim.UseVisualStyleBackColor = true;
            // 
            // gbrTipoChamado
            // 
            this.gbrTipoChamado.Controls.Add(this.rdbtipoChamadoCelular);
            this.gbrTipoChamado.Controls.Add(this.rdbTipoChamadoManutencao);
            this.gbrTipoChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbrTipoChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrTipoChamado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbrTipoChamado.Location = new System.Drawing.Point(6, 66);
            this.gbrTipoChamado.Name = "gbrTipoChamado";
            this.gbrTipoChamado.Size = new System.Drawing.Size(823, 34);
            this.gbrTipoChamado.TabIndex = 112;
            this.gbrTipoChamado.TabStop = false;
            // 
            // rdbtipoChamadoCelular
            // 
            this.rdbtipoChamadoCelular.AutoSize = true;
            this.rdbtipoChamadoCelular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbtipoChamadoCelular.Location = new System.Drawing.Point(501, 11);
            this.rdbtipoChamadoCelular.Name = "rdbtipoChamadoCelular";
            this.rdbtipoChamadoCelular.Size = new System.Drawing.Size(64, 17);
            this.rdbtipoChamadoCelular.TabIndex = 2;
            this.rdbtipoChamadoCelular.TabStop = true;
            this.rdbtipoChamadoCelular.Text = "Celular";
            this.rdbtipoChamadoCelular.UseVisualStyleBackColor = true;
            this.rdbtipoChamadoCelular.Click += new System.EventHandler(this.rdbtipoChamadoCelular_Click);
            // 
            // rdbTipoChamadoManutencao
            // 
            this.rdbTipoChamadoManutencao.AutoSize = true;
            this.rdbTipoChamadoManutencao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbTipoChamadoManutencao.Location = new System.Drawing.Point(190, 11);
            this.rdbTipoChamadoManutencao.Name = "rdbTipoChamadoManutencao";
            this.rdbTipoChamadoManutencao.Size = new System.Drawing.Size(95, 17);
            this.rdbTipoChamadoManutencao.TabIndex = 1;
            this.rdbTipoChamadoManutencao.TabStop = true;
            this.rdbTipoChamadoManutencao.Text = "Manutenção";
            this.rdbTipoChamadoManutencao.UseVisualStyleBackColor = true;
            this.rdbTipoChamadoManutencao.Click += new System.EventHandler(this.rdbTipoChamadoManutencao_Click);
            // 
            // dataGridProdutos
            // 
            this.dataGridProdutos.AllowUserToAddRows = false;
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Slecionar,
            this.Column3,
            this.Column4});
            this.dataGridProdutos.Location = new System.Drawing.Point(3, 27);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.Size = new System.Drawing.Size(410, 130);
            this.dataGridProdutos.TabIndex = 107;
            this.dataGridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProdutos_CellClick);
            // 
            // Slecionar
            // 
            this.Slecionar.HeaderText = "Selecionar";
            this.Slecionar.Name = "Slecionar";
            this.Slecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Slecionar.Width = 60;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "idProduto";
            this.Column3.HeaderText = "Código";
            this.Column3.MaxInputLength = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NomeProduto";
            this.Column4.HeaderText = "Produto";
            this.Column4.MaxInputLength = 50;
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "Produto";
            // 
            // pnlChamadoProduto
            // 
            this.pnlChamadoProduto.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChamadoProduto.Controls.Add(this.label4);
            this.pnlChamadoProduto.Controls.Add(this.dataGridProdutos);
            this.pnlChamadoProduto.Location = new System.Drawing.Point(428, 106);
            this.pnlChamadoProduto.Name = "pnlChamadoProduto";
            this.pnlChamadoProduto.Size = new System.Drawing.Size(419, 160);
            this.pnlChamadoProduto.TabIndex = 111;
            // 
            // pnlChamadoPadrao
            // 
            this.pnlChamadoPadrao.Controls.Add(this.grbComputer);
            this.pnlChamadoPadrao.Controls.Add(this.gbrNoteBook);
            this.pnlChamadoPadrao.Enabled = false;
            this.pnlChamadoPadrao.Location = new System.Drawing.Point(6, 269);
            this.pnlChamadoPadrao.Name = "pnlChamadoPadrao";
            this.pnlChamadoPadrao.Size = new System.Drawing.Size(220, 160);
            this.pnlChamadoPadrao.TabIndex = 114;
            // 
            // grbComputer
            // 
            this.grbComputer.Controls.Add(this.rtxMarcaModeloSerie);
            this.grbComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbComputer.Location = new System.Drawing.Point(7, 60);
            this.grbComputer.Name = "grbComputer";
            this.grbComputer.Size = new System.Drawing.Size(210, 93);
            this.grbComputer.TabIndex = 1;
            this.grbComputer.TabStop = false;
            this.grbComputer.Text = "Marca/Modelo/Série";
            // 
            // rtxMarcaModeloSerie
            // 
            this.rtxMarcaModeloSerie.Location = new System.Drawing.Point(7, 19);
            this.rtxMarcaModeloSerie.MaxLength = 45;
            this.rtxMarcaModeloSerie.Name = "rtxMarcaModeloSerie";
            this.rtxMarcaModeloSerie.Size = new System.Drawing.Size(195, 74);
            this.rtxMarcaModeloSerie.TabIndex = 0;
            this.rtxMarcaModeloSerie.Text = "";
            this.rtxMarcaModeloSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxMarcaModeloSerie_KeyPress);
            // 
            // gbrNoteBook
            // 
            this.gbrNoteBook.Controls.Add(this.rdbCarregadorNoteNao);
            this.gbrNoteBook.Controls.Add(this.rdbCarregadorNoteSim);
            this.gbrNoteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrNoteBook.Location = new System.Drawing.Point(8, 8);
            this.gbrNoteBook.Name = "gbrNoteBook";
            this.gbrNoteBook.Size = new System.Drawing.Size(209, 46);
            this.gbrNoteBook.TabIndex = 0;
            this.gbrNoteBook.TabStop = false;
            this.gbrNoteBook.Text = "NoteBook Possui Carregador";
            // 
            // rdbCarregadorNoteNao
            // 
            this.rdbCarregadorNoteNao.AutoSize = true;
            this.rdbCarregadorNoteNao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbCarregadorNoteNao.Location = new System.Drawing.Point(129, 24);
            this.rdbCarregadorNoteNao.Name = "rdbCarregadorNoteNao";
            this.rdbCarregadorNoteNao.Size = new System.Drawing.Size(48, 17);
            this.rdbCarregadorNoteNao.TabIndex = 2;
            this.rdbCarregadorNoteNao.TabStop = true;
            this.rdbCarregadorNoteNao.Text = "Não";
            this.rdbCarregadorNoteNao.UseVisualStyleBackColor = true;
            // 
            // rdbCarregadorNoteSim
            // 
            this.rdbCarregadorNoteSim.AutoSize = true;
            this.rdbCarregadorNoteSim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbCarregadorNoteSim.Location = new System.Drawing.Point(6, 24);
            this.rdbCarregadorNoteSim.Name = "rdbCarregadorNoteSim";
            this.rdbCarregadorNoteSim.Size = new System.Drawing.Size(45, 17);
            this.rdbCarregadorNoteSim.TabIndex = 1;
            this.rdbCarregadorNoteSim.TabStop = true;
            this.rdbCarregadorNoteSim.Text = "Sim";
            this.rdbCarregadorNoteSim.UseVisualStyleBackColor = true;
            // 
            // pnlObsAtendente
            // 
            this.pnlObsAtendente.Controls.Add(this.rtxObsAtendente);
            this.pnlObsAtendente.Location = new System.Drawing.Point(431, 269);
            this.pnlObsAtendente.Name = "pnlObsAtendente";
            this.pnlObsAtendente.Size = new System.Drawing.Size(416, 160);
            this.pnlObsAtendente.TabIndex = 115;
            // 
            // rtxObsAtendente
            // 
            this.rtxObsAtendente.Location = new System.Drawing.Point(5, 4);
            this.rtxObsAtendente.MaxLength = 500;
            this.rtxObsAtendente.Name = "rtxObsAtendente";
            this.rtxObsAtendente.Size = new System.Drawing.Size(405, 152);
            this.rtxObsAtendente.TabIndex = 116;
            this.rtxObsAtendente.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 25);
            this.statusStrip1.TabIndex = 116;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(160, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmCadChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 606);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlObsAtendente);
            this.Controls.Add(this.pnlChamadoPadrao);
            this.Controls.Add(this.pnlChamadoCelular);
            this.Controls.Add(this.gbrTipoChamado);
            this.Controls.Add(this.pnlChamadoProduto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskDataCadastro);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadChamados";
            this.Text = "Chamados";
            this.Load += new System.EventHandler(this.frmCadChamados_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamados)).EndInit();
            this.pnlChamadoCelular.ResumeLayout(false);
            this.grbChip.ResumeLayout(false);
            this.grbChip.PerformLayout();
            this.grbCartaoMemoria.ResumeLayout(false);
            this.grbCartaoMemoria.PerformLayout();
            this.grbCarregador.ResumeLayout(false);
            this.grbCarregador.PerformLayout();
            this.gbrTipoChamado.ResumeLayout(false);
            this.gbrTipoChamado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            this.pnlChamadoProduto.ResumeLayout(false);
            this.pnlChamadoProduto.PerformLayout();
            this.pnlChamadoPadrao.ResumeLayout(false);
            this.grbComputer.ResumeLayout(false);
            this.gbrNoteBook.ResumeLayout(false);
            this.gbrNoteBook.PerformLayout();
            this.pnlObsAtendente.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskDataCadastro;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridChamados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomePesqisa;
        private System.Windows.Forms.Panel pnlChamadoCelular;
        private System.Windows.Forms.GroupBox grbCartaoMemoria;
        private System.Windows.Forms.RadioButton rdbCartaoMemoriaNao;
        private System.Windows.Forms.RadioButton rdbCartaoMemoriaSim;
        private System.Windows.Forms.GroupBox grbCarregador;
        private System.Windows.Forms.RadioButton rdbCarregadorNao;
        private System.Windows.Forms.RadioButton rdbCarregadorSim;
        private System.Windows.Forms.GroupBox gbrTipoChamado;
        private System.Windows.Forms.RadioButton rdbtipoChamadoCelular;
        private System.Windows.Forms.RadioButton rdbTipoChamadoManutencao;
        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlChamadoProduto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Slecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grbChip;
        private System.Windows.Forms.RadioButton rdbChipNao;
        private System.Windows.Forms.RadioButton rdbChipSim;
        private System.Windows.Forms.Panel pnlChamadoPadrao;
        private System.Windows.Forms.GroupBox grbComputer;
        private System.Windows.Forms.GroupBox gbrNoteBook;
        private System.Windows.Forms.RadioButton rdbCarregadorNoteNao;
        private System.Windows.Forms.RadioButton rdbCarregadorNoteSim;
        private System.Windows.Forms.RichTextBox rtxMarcaModeloSerie;
        private System.Windows.Forms.Panel pnlObsAtendente;
        private System.Windows.Forms.RichTextBox rtxObsAtendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsItemChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsItemTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}