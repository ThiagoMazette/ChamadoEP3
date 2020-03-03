namespace Chamados
{
    partial class frmListagem
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
            this.cbbTecnico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcurarEmpresa = new System.Windows.Forms.TextBox();
            this.btnProcurarEmpresa = new System.Windows.Forms.Button();
            this.dgvProcurarEmpresa = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpresaSelecionada = new System.Windows.Forms.TextBox();
            this.btnListarResultado = new System.Windows.Forms.Button();
            this.dgvListarResultado = new System.Windows.Forms.DataGridView();
            this.cbbEmpresa = new System.Windows.Forms.ComboBox();
            this.txtEmpresaID = new System.Windows.Forms.TextBox();
            this.btnLimparEmpresa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idtecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjcpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurarEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarResultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTecnico
            // 
            this.cbbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTecnico.FormattingEnabled = true;
            this.cbbTecnico.Items.AddRange(new object[] {
            "Jefferson",
            "Fabio",
            "Jadilson",
            "Thiago",
            "Rafael",
            "Beto",
            "Todos"});
            this.cbbTecnico.Location = new System.Drawing.Point(68, 18);
            this.cbbTecnico.Name = "cbbTecnico";
            this.cbbTecnico.Size = new System.Drawing.Size(100, 21);
            this.cbbTecnico.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Técnico:";
            // 
            // txtProcurarEmpresa
            // 
            this.txtProcurarEmpresa.Location = new System.Drawing.Point(153, 16);
            this.txtProcurarEmpresa.Name = "txtProcurarEmpresa";
            this.txtProcurarEmpresa.Size = new System.Drawing.Size(459, 20);
            this.txtProcurarEmpresa.TabIndex = 3;
            this.txtProcurarEmpresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProcurarEmpresa_KeyPress);
            // 
            // btnProcurarEmpresa
            // 
            this.btnProcurarEmpresa.BackColor = System.Drawing.Color.Blue;
            this.btnProcurarEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnProcurarEmpresa.Location = new System.Drawing.Point(19, 42);
            this.btnProcurarEmpresa.Name = "btnProcurarEmpresa";
            this.btnProcurarEmpresa.Size = new System.Drawing.Size(118, 23);
            this.btnProcurarEmpresa.TabIndex = 4;
            this.btnProcurarEmpresa.Text = "Procurar Empresa";
            this.btnProcurarEmpresa.UseVisualStyleBackColor = false;
            this.btnProcurarEmpresa.Click += new System.EventHandler(this.btnProcurarEmpresa_Click);
            // 
            // dgvProcurarEmpresa
            // 
            this.dgvProcurarEmpresa.AllowDrop = true;
            this.dgvProcurarEmpresa.AllowUserToAddRows = false;
            this.dgvProcurarEmpresa.AllowUserToDeleteRows = false;
            this.dgvProcurarEmpresa.AllowUserToResizeRows = false;
            this.dgvProcurarEmpresa.BackgroundColor = System.Drawing.Color.White;
            this.dgvProcurarEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcurarEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cnpj,
            this.nome,
            this.telefone});
            this.dgvProcurarEmpresa.Location = new System.Drawing.Point(591, 43);
            this.dgvProcurarEmpresa.MultiSelect = false;
            this.dgvProcurarEmpresa.Name = "dgvProcurarEmpresa";
            this.dgvProcurarEmpresa.ReadOnly = true;
            this.dgvProcurarEmpresa.RowHeadersVisible = false;
            this.dgvProcurarEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcurarEmpresa.Size = new System.Drawing.Size(459, 133);
            this.dgvProcurarEmpresa.TabIndex = 5;
            this.dgvProcurarEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcurarEmpresa_CellClick);
            this.dgvProcurarEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcurarEmpresa_CellContentClick);
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
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Visible = false;
            // 
            // txtEmpresaSelecionada
            // 
            this.txtEmpresaSelecionada.Location = new System.Drawing.Point(6, 19);
            this.txtEmpresaSelecionada.Name = "txtEmpresaSelecionada";
            this.txtEmpresaSelecionada.ReadOnly = true;
            this.txtEmpresaSelecionada.Size = new System.Drawing.Size(433, 20);
            this.txtEmpresaSelecionada.TabIndex = 8;
            // 
            // btnListarResultado
            // 
            this.btnListarResultado.BackColor = System.Drawing.Color.Blue;
            this.btnListarResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnListarResultado.ForeColor = System.Drawing.Color.White;
            this.btnListarResultado.Location = new System.Drawing.Point(445, 18);
            this.btnListarResultado.Name = "btnListarResultado";
            this.btnListarResultado.Size = new System.Drawing.Size(118, 23);
            this.btnListarResultado.TabIndex = 6;
            this.btnListarResultado.Text = "Listar Resultado";
            this.btnListarResultado.UseVisualStyleBackColor = false;
            this.btnListarResultado.Click += new System.EventHandler(this.btnListarResultado_Click);
            // 
            // dgvListarResultado
            // 
            this.dgvListarResultado.AllowUserToAddRows = false;
            this.dgvListarResultado.AllowUserToDeleteRows = false;
            this.dgvListarResultado.AllowUserToResizeRows = false;
            this.dgvListarResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgvListarResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.NomeE,
            this.resumo,
            this.contato,
            this.fk_idtecnico,
            this.atendimento,
            this.telefone1,
            this.cnpjcpf,
            this.id1,
            this.fk_idempresa,
            this.dataFinal});
            this.dgvListarResultado.DataMember = "Funcionario";
            this.dgvListarResultado.Location = new System.Drawing.Point(12, 188);
            this.dgvListarResultado.MultiSelect = false;
            this.dgvListarResultado.Name = "dgvListarResultado";
            this.dgvListarResultado.ReadOnly = true;
            this.dgvListarResultado.RowHeadersVisible = false;
            this.dgvListarResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListarResultado.Size = new System.Drawing.Size(1044, 375);
            this.dgvListarResultado.TabIndex = 6;
            this.dgvListarResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListarResultado_CellDoubleClick);
            // 
            // cbbEmpresa
            // 
            this.cbbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEmpresa.FormattingEnabled = true;
            this.cbbEmpresa.Items.AddRange(new object[] {
            "CNPJ",
            "Nome"});
            this.cbbEmpresa.Location = new System.Drawing.Point(58, 16);
            this.cbbEmpresa.Name = "cbbEmpresa";
            this.cbbEmpresa.Size = new System.Drawing.Size(79, 21);
            this.cbbEmpresa.TabIndex = 2;
            this.cbbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbbEmpresa_SelectedIndexChanged);
            // 
            // txtEmpresaID
            // 
            this.txtEmpresaID.Location = new System.Drawing.Point(58, 71);
            this.txtEmpresaID.Name = "txtEmpresaID";
            this.txtEmpresaID.Size = new System.Drawing.Size(79, 20);
            this.txtEmpresaID.TabIndex = 11;
            this.txtEmpresaID.Visible = false;
            // 
            // btnLimparEmpresa
            // 
            this.btnLimparEmpresa.BackColor = System.Drawing.Color.Blue;
            this.btnLimparEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnLimparEmpresa.Location = new System.Drawing.Point(19, 71);
            this.btnLimparEmpresa.Name = "btnLimparEmpresa";
            this.btnLimparEmpresa.Size = new System.Drawing.Size(118, 23);
            this.btnLimparEmpresa.TabIndex = 5;
            this.btnLimparEmpresa.Text = "Limpar Empresa";
            this.btnLimparEmpresa.UseVisualStyleBackColor = false;
            this.btnLimparEmpresa.Click += new System.EventHandler(this.btnLimparEmpresa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmpresaSelecionada);
            this.groupBox1.Controls.Add(this.btnListarResultado);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 50);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa Selecionada:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcurarEmpresa);
            this.groupBox2.Controls.Add(this.btnLimparEmpresa);
            this.groupBox2.Controls.Add(this.cbbEmpresa);
            this.groupBox2.Controls.Add(this.txtProcurarEmpresa);
            this.groupBox2.Controls.Add(this.txtEmpresaID);
            this.groupBox2.Location = new System.Drawing.Point(438, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 180);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procurar Empresa:";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Blue;
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(18, 103);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(109, 23);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir Resultado";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data/Hora";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 83;
            // 
            // NomeE
            // 
            this.NomeE.DataPropertyName = "nome";
            this.NomeE.HeaderText = "Empresa";
            this.NomeE.Name = "NomeE";
            this.NomeE.ReadOnly = true;
            this.NomeE.Width = 200;
            // 
            // resumo
            // 
            this.resumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resumo.DataPropertyName = "resumo";
            this.resumo.HeaderText = "Resumo";
            this.resumo.Name = "resumo";
            this.resumo.ReadOnly = true;
            // 
            // contato
            // 
            this.contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.contato.DataPropertyName = "contato";
            this.contato.HeaderText = "Contato";
            this.contato.Name = "contato";
            this.contato.ReadOnly = true;
            this.contato.Width = 69;
            // 
            // fk_idtecnico
            // 
            this.fk_idtecnico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fk_idtecnico.DataPropertyName = "fk_idtecnico";
            this.fk_idtecnico.HeaderText = "Técnico";
            this.fk_idtecnico.Name = "fk_idtecnico";
            this.fk_idtecnico.ReadOnly = true;
            this.fk_idtecnico.Width = 71;
            // 
            // atendimento
            // 
            this.atendimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.atendimento.DataPropertyName = "atendimento";
            this.atendimento.HeaderText = "Atendimento";
            this.atendimento.Name = "atendimento";
            this.atendimento.ReadOnly = true;
            this.atendimento.Width = 5;
            // 
            // telefone1
            // 
            this.telefone1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.telefone1.DataPropertyName = "telefone";
            this.telefone1.HeaderText = "Telefone";
            this.telefone1.Name = "telefone1";
            this.telefone1.ReadOnly = true;
            this.telefone1.Width = 5;
            // 
            // cnpjcpf
            // 
            this.cnpjcpf.DataPropertyName = "cnpj";
            this.cnpjcpf.HeaderText = "cnpjcpf";
            this.cnpjcpf.Name = "cnpjcpf";
            this.cnpjcpf.ReadOnly = true;
            this.cnpjcpf.Visible = false;
            // 
            // id1
            // 
            this.id1.DataPropertyName = "id";
            this.id1.HeaderText = "id1";
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            this.id1.Visible = false;
            // 
            // fk_idempresa
            // 
            this.fk_idempresa.DataPropertyName = "fk_idempresa";
            this.fk_idempresa.HeaderText = "fk_idempresa";
            this.fk_idempresa.Name = "fk_idempresa";
            this.fk_idempresa.ReadOnly = true;
            this.fk_idempresa.Visible = false;
            // 
            // dataFinal
            // 
            this.dataFinal.DataPropertyName = "dataFinal";
            this.dataFinal.HeaderText = "dataFinal";
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.ReadOnly = true;
            this.dataFinal.Visible = false;
            // 
            // frmListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1068, 580);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListarResultado);
            this.Controls.Add(this.dgvProcurarEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTecnico);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListagem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Chamados";
            this.Load += new System.EventHandler(this.frmListagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurarEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarResultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTecnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcurarEmpresa;
        private System.Windows.Forms.Button btnProcurarEmpresa;
        private System.Windows.Forms.DataGridView dgvProcurarEmpresa;
        private System.Windows.Forms.TextBox txtEmpresaSelecionada;
        private System.Windows.Forms.Button btnListarResultado;
        private System.Windows.Forms.DataGridView dgvListarResultado;
        private System.Windows.Forms.ComboBox cbbEmpresa;
        private System.Windows.Forms.TextBox txtEmpresaID;
        private System.Windows.Forms.Button btnLimparEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeE;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idtecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjcpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinal;
    }
}