namespace Chamados
{
    partial class frmAbrirChamado
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
            this.btnProcurar = new System.Windows.Forms.Button();
            this.cbbSelecao = new System.Windows.Forms.ComboBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtAbrirChamadoNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirChamado = new System.Windows.Forms.Button();
            this.txtAbrirChamadoID = new System.Windows.Forms.TextBox();
            this.txtAbrirChamadoCNPJ = new System.Windows.Forms.TextBox();
            this.txtProcurar = new System.Windows.Forms.MaskedTextBox();
            this.dgvResumo = new System.Windows.Forms.DataGridView();
            this.rec_chvbfj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chvori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vndBchvvnda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vndBchvps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pschvps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_dem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_vlr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDataBloqueio = new System.Windows.Forms.TextBox();
            this.lblBloqueio = new System.Windows.Forms.Label();
            this.dgvTelefones = new System.Windows.Forms.DataGridView();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.txtTel3 = new System.Windows.Forms.TextBox();
            this.txtTel4 = new System.Windows.Forms.TextBox();
            this.txtTel5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtchvvnda = new System.Windows.Forms.TextBox();
            this.M_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt_fwu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFollowUP = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalContagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowUP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Blue;
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnProcurar.ForeColor = System.Drawing.Color.White;
            this.btnProcurar.Location = new System.Drawing.Point(643, 8);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(85, 23);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // cbbSelecao
            // 
            this.cbbSelecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelecao.FormattingEnabled = true;
            this.cbbSelecao.Items.AddRange(new object[] {
            "CNPJ",
            "Nome"});
            this.cbbSelecao.Location = new System.Drawing.Point(12, 11);
            this.cbbSelecao.Name = "cbbSelecao";
            this.cbbSelecao.Size = new System.Drawing.Size(69, 21);
            this.cbbSelecao.TabIndex = 1;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowDrop = true;
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToResizeRows = false;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cnpj,
            this.nome});
            this.dgvResultado.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvResultado.Location = new System.Drawing.Point(12, 38);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(673, 155);
            this.dgvResultado.TabIndex = 6;
            this.dgvResultado.TabStop = false;
            this.dgvResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultado_CellClick);
            this.dgvResultado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvResultado_KeyUp);
            // 
            // id
            // 
            this.id.DataPropertyName = "chvbfj";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cnpj
            // 
            this.cnpj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnpj.DataPropertyName = "cnpjcpf";
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            this.cnpj.Width = 59;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "rzs";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Blue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(734, 8);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Blue;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(691, 220);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtAbrirChamadoNome
            // 
            this.txtAbrirChamadoNome.Location = new System.Drawing.Point(15, 217);
            this.txtAbrirChamadoNome.Name = "txtAbrirChamadoNome";
            this.txtAbrirChamadoNome.ReadOnly = true;
            this.txtAbrirChamadoNome.Size = new System.Drawing.Size(443, 20);
            this.txtAbrirChamadoNome.TabIndex = 4;
            this.txtAbrirChamadoNome.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Empresa:";
            // 
            // btnAbrirChamado
            // 
            this.btnAbrirChamado.BackColor = System.Drawing.Color.Blue;
            this.btnAbrirChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAbrirChamado.ForeColor = System.Drawing.Color.White;
            this.btnAbrirChamado.Location = new System.Drawing.Point(691, 172);
            this.btnAbrirChamado.Name = "btnAbrirChamado";
            this.btnAbrirChamado.Size = new System.Drawing.Size(118, 39);
            this.btnAbrirChamado.TabIndex = 5;
            this.btnAbrirChamado.Text = "Abrir Chamado";
            this.btnAbrirChamado.UseVisualStyleBackColor = false;
            this.btnAbrirChamado.Click += new System.EventHandler(this.btnAbrirChamado_Click);
            // 
            // txtAbrirChamadoID
            // 
            this.txtAbrirChamadoID.Location = new System.Drawing.Point(126, 191);
            this.txtAbrirChamadoID.Name = "txtAbrirChamadoID";
            this.txtAbrirChamadoID.Size = new System.Drawing.Size(51, 20);
            this.txtAbrirChamadoID.TabIndex = 12;
            this.txtAbrirChamadoID.TabStop = false;
            this.txtAbrirChamadoID.Visible = false;
            // 
            // txtAbrirChamadoCNPJ
            // 
            this.txtAbrirChamadoCNPJ.Location = new System.Drawing.Point(12, 191);
            this.txtAbrirChamadoCNPJ.Name = "txtAbrirChamadoCNPJ";
            this.txtAbrirChamadoCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txtAbrirChamadoCNPJ.TabIndex = 13;
            this.txtAbrirChamadoCNPJ.TabStop = false;
            this.txtAbrirChamadoCNPJ.Visible = false;
            // 
            // txtProcurar
            // 
            this.txtProcurar.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtProcurar.Location = new System.Drawing.Point(87, 11);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(550, 20);
            this.txtProcurar.TabIndex = 2;
            this.txtProcurar.DoubleClick += new System.EventHandler(this.txtProcurar_DoubleClick);
            this.txtProcurar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtProcurar_KeyUp);
            // 
            // dgvResumo
            // 
            this.dgvResumo.AllowDrop = true;
            this.dgvResumo.AllowUserToAddRows = false;
            this.dgvResumo.AllowUserToDeleteRows = false;
            this.dgvResumo.AllowUserToResizeRows = false;
            this.dgvResumo.BackgroundColor = System.Drawing.Color.White;
            this.dgvResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rec_chvbfj,
            this.chvori,
            this.doc,
            this.vndBchvvnda,
            this.vndBchvps,
            this.pschvps,
            this.dt_dem,
            this.Dsc,
            this.c_vlr});
            this.dgvResumo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvResumo.Location = new System.Drawing.Point(15, 249);
            this.dgvResumo.MultiSelect = false;
            this.dgvResumo.Name = "dgvResumo";
            this.dgvResumo.ReadOnly = true;
            this.dgvResumo.RowHeadersVisible = false;
            this.dgvResumo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumo.Size = new System.Drawing.Size(344, 199);
            this.dgvResumo.TabIndex = 15;
            this.dgvResumo.TabStop = false;
            this.dgvResumo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResumo_CellClick);
            this.dgvResumo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvResumo_KeyUp);
            // 
            // rec_chvbfj
            // 
            this.rec_chvbfj.DataPropertyName = "chvbfj";
            this.rec_chvbfj.HeaderText = "rec.chvbfj";
            this.rec_chvbfj.Name = "rec_chvbfj";
            this.rec_chvbfj.ReadOnly = true;
            this.rec_chvbfj.Visible = false;
            // 
            // chvori
            // 
            this.chvori.DataPropertyName = "chvori";
            this.chvori.HeaderText = "chvori";
            this.chvori.Name = "chvori";
            this.chvori.ReadOnly = true;
            this.chvori.Visible = false;
            // 
            // doc
            // 
            this.doc.DataPropertyName = "doc";
            this.doc.HeaderText = "doc";
            this.doc.Name = "doc";
            this.doc.ReadOnly = true;
            this.doc.Visible = false;
            // 
            // vndBchvvnda
            // 
            this.vndBchvvnda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vndBchvvnda.DataPropertyName = "chvvnda";
            this.vndBchvvnda.HeaderText = "chvvnda";
            this.vndBchvvnda.Name = "vndBchvvnda";
            this.vndBchvvnda.ReadOnly = true;
            this.vndBchvvnda.Visible = false;
            // 
            // vndBchvps
            // 
            this.vndBchvps.DataPropertyName = "vndB.chvps";
            this.vndBchvps.HeaderText = "vndB.chvps";
            this.vndBchvps.Name = "vndBchvps";
            this.vndBchvps.ReadOnly = true;
            this.vndBchvps.Visible = false;
            // 
            // pschvps
            // 
            this.pschvps.DataPropertyName = "ps.chvps";
            this.pschvps.HeaderText = "ps.chvps";
            this.pschvps.Name = "pschvps";
            this.pschvps.ReadOnly = true;
            this.pschvps.Visible = false;
            // 
            // dt_dem
            // 
            this.dt_dem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dt_dem.DataPropertyName = "dt_dem";
            this.dt_dem.HeaderText = "Data";
            this.dt_dem.Name = "dt_dem";
            this.dt_dem.ReadOnly = true;
            this.dt_dem.Width = 55;
            // 
            // Dsc
            // 
            this.Dsc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dsc.DataPropertyName = "Dsc";
            this.Dsc.HeaderText = "Descrição";
            this.Dsc.Name = "Dsc";
            this.Dsc.ReadOnly = true;
            // 
            // c_vlr
            // 
            this.c_vlr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.c_vlr.DataPropertyName = "c_vlr";
            this.c_vlr.HeaderText = "Valor";
            this.c_vlr.Name = "c_vlr";
            this.c_vlr.ReadOnly = true;
            this.c_vlr.Width = 5;
            // 
            // txtDataBloqueio
            // 
            this.txtDataBloqueio.Location = new System.Drawing.Point(6, 19);
            this.txtDataBloqueio.Name = "txtDataBloqueio";
            this.txtDataBloqueio.ReadOnly = true;
            this.txtDataBloqueio.Size = new System.Drawing.Size(72, 20);
            this.txtDataBloqueio.TabIndex = 17;
            this.txtDataBloqueio.TabStop = false;
            // 
            // lblBloqueio
            // 
            this.lblBloqueio.AutoSize = true;
            this.lblBloqueio.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloqueio.ForeColor = System.Drawing.Color.Red;
            this.lblBloqueio.Location = new System.Drawing.Point(85, 19);
            this.lblBloqueio.Name = "lblBloqueio";
            this.lblBloqueio.Size = new System.Drawing.Size(120, 20);
            this.lblBloqueio.TabIndex = 18;
            this.lblBloqueio.Text = "BLOQUEADA";
            this.lblBloqueio.Visible = false;
            // 
            // dgvTelefones
            // 
            this.dgvTelefones.AllowDrop = true;
            this.dgvTelefones.AllowUserToAddRows = false;
            this.dgvTelefones.AllowUserToDeleteRows = false;
            this.dgvTelefones.AllowUserToResizeRows = false;
            this.dgvTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefones.Location = new System.Drawing.Point(445, 264);
            this.dgvTelefones.MultiSelect = false;
            this.dgvTelefones.Name = "dgvTelefones";
            this.dgvTelefones.ReadOnly = true;
            this.dgvTelefones.RowHeadersVisible = false;
            this.dgvTelefones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTelefones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefones.Size = new System.Drawing.Size(108, 138);
            this.dgvTelefones.TabIndex = 21;
            this.dgvTelefones.TabStop = false;
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(10, 16);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.ReadOnly = true;
            this.txtTel1.Size = new System.Drawing.Size(100, 20);
            this.txtTel1.TabIndex = 22;
            this.txtTel1.TabStop = false;
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(10, 37);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.ReadOnly = true;
            this.txtTel2.Size = new System.Drawing.Size(100, 20);
            this.txtTel2.TabIndex = 23;
            this.txtTel2.TabStop = false;
            // 
            // txtTel3
            // 
            this.txtTel3.Location = new System.Drawing.Point(10, 58);
            this.txtTel3.Name = "txtTel3";
            this.txtTel3.ReadOnly = true;
            this.txtTel3.Size = new System.Drawing.Size(100, 20);
            this.txtTel3.TabIndex = 24;
            this.txtTel3.TabStop = false;
            // 
            // txtTel4
            // 
            this.txtTel4.Location = new System.Drawing.Point(10, 79);
            this.txtTel4.Name = "txtTel4";
            this.txtTel4.ReadOnly = true;
            this.txtTel4.Size = new System.Drawing.Size(100, 20);
            this.txtTel4.TabIndex = 25;
            this.txtTel4.TabStop = false;
            // 
            // txtTel5
            // 
            this.txtTel5.Location = new System.Drawing.Point(10, 100);
            this.txtTel5.Name = "txtTel5";
            this.txtTel5.ReadOnly = true;
            this.txtTel5.Size = new System.Drawing.Size(100, 20);
            this.txtTel5.TabIndex = 26;
            this.txtTel5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTel3);
            this.groupBox1.Controls.Add(this.txtTel5);
            this.groupBox1.Controls.Add(this.txtTel1);
            this.groupBox1.Controls.Add(this.txtTel4);
            this.groupBox1.Controls.Add(this.txtTel2);
            this.groupBox1.Location = new System.Drawing.Point(691, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 128);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telefone(s):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDataBloqueio);
            this.groupBox2.Controls.Add(this.lblBloqueio);
            this.groupBox2.Location = new System.Drawing.Point(464, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 45);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Bloqueio:";
            // 
            // txtchvvnda
            // 
            this.txtchvvnda.Location = new System.Drawing.Point(183, 191);
            this.txtchvvnda.Name = "txtchvvnda";
            this.txtchvvnda.Size = new System.Drawing.Size(37, 20);
            this.txtchvvnda.TabIndex = 30;
            this.txtchvvnda.Visible = false;
            // 
            // M_desc
            // 
            this.M_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.M_desc.DataPropertyName = "M_desc";
            this.M_desc.HeaderText = "Follow-UP";
            this.M_desc.Name = "M_desc";
            this.M_desc.ReadOnly = true;
            // 
            // Dt_fwu
            // 
            this.Dt_fwu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dt_fwu.DataPropertyName = "Dt_fwu";
            this.Dt_fwu.HeaderText = "Data";
            this.Dt_fwu.Name = "Dt_fwu";
            this.Dt_fwu.ReadOnly = true;
            this.Dt_fwu.Width = 55;
            // 
            // chvent
            // 
            this.chvent.DataPropertyName = "chvent";
            this.chvent.HeaderText = "chvent";
            this.chvent.Name = "chvent";
            this.chvent.ReadOnly = true;
            this.chvent.Visible = false;
            // 
            // dgvFollowUP
            // 
            this.dgvFollowUP.AllowDrop = true;
            this.dgvFollowUP.AllowUserToAddRows = false;
            this.dgvFollowUP.AllowUserToDeleteRows = false;
            this.dgvFollowUP.AllowUserToResizeRows = false;
            this.dgvFollowUP.BackgroundColor = System.Drawing.Color.White;
            this.dgvFollowUP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowUP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chvent,
            this.Dt_fwu,
            this.M_desc});
            this.dgvFollowUP.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvFollowUP.Location = new System.Drawing.Point(365, 249);
            this.dgvFollowUP.MultiSelect = false;
            this.dgvFollowUP.Name = "dgvFollowUP";
            this.dgvFollowUP.ReadOnly = true;
            this.dgvFollowUP.RowHeadersVisible = false;
            this.dgvFollowUP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFollowUP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFollowUP.Size = new System.Drawing.Size(444, 199);
            this.dgvFollowUP.TabIndex = 29;
            this.dgvFollowUP.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(373, 194);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Visible = false;
            // 
            // lblTotalContagem
            // 
            this.lblTotalContagem.AutoSize = true;
            this.lblTotalContagem.Location = new System.Drawing.Point(423, 194);
            this.lblTotalContagem.Name = "lblTotalContagem";
            this.lblTotalContagem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalContagem.Size = new System.Drawing.Size(13, 13);
            this.lblTotalContagem.TabIndex = 32;
            this.lblTotalContagem.Text = "0";
            this.lblTotalContagem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTotalContagem.Visible = false;
            // 
            // frmAbrirChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(819, 464);
            this.Controls.Add(this.lblTotalContagem);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvFollowUP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvResumo);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.btnAbrirChamado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAbrirChamadoNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.cbbSelecao);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtAbrirChamadoCNPJ);
            this.Controls.Add(this.txtAbrirChamadoID);
            this.Controls.Add(this.dgvTelefones);
            this.Controls.Add(this.txtchvvnda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbrirChamado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Chamado";
            this.Load += new System.EventHandler(this.frmAbrirChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.ComboBox cbbSelecao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtAbrirChamadoNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirChamado;
        private System.Windows.Forms.TextBox txtAbrirChamadoID;
        private System.Windows.Forms.TextBox txtAbrirChamadoCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.MaskedTextBox txtProcurar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridView dgvResumo;
        private System.Windows.Forms.TextBox txtDataBloqueio;
        private System.Windows.Forms.Label lblBloqueio;
        private System.Windows.Forms.DataGridView dgvTelefones;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.TextBox txtTel3;
        private System.Windows.Forms.TextBox txtTel4;
        private System.Windows.Forms.TextBox txtTel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtchvvnda;
        private System.Windows.Forms.DataGridViewTextBoxColumn rec_chvbfj;
        private System.Windows.Forms.DataGridViewTextBoxColumn chvori;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vndBchvvnda;
        private System.Windows.Forms.DataGridViewTextBoxColumn vndBchvps;
        private System.Windows.Forms.DataGridViewTextBoxColumn pschvps;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_dem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_vlr;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_fwu;
        private System.Windows.Forms.DataGridViewTextBoxColumn chvent;
        private System.Windows.Forms.DataGridView dgvFollowUP;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalContagem;
    }
}