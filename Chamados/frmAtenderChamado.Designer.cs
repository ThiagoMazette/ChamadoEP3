namespace Chamados
{
    partial class frmAtenderChamado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.cbbTecnico = new System.Windows.Forms.ComboBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.dgvOutrosAtendimentos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idtecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtEmpresaID = new System.Windows.Forms.TextBox();
            this.txtChamadoID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbAtendimento = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutrosAtendimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Técnico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contato:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(75, 25);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(282, 20);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.TextChanged += new System.EventHandler(this.txtEmpresa_TextChanged);
            // 
            // cbbTecnico
            // 
            this.cbbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTecnico.FormattingEnabled = true;
            this.cbbTecnico.Items.AddRange(new object[] {
            "Jefferson",
            "Fabio",
            "Jadilson",
            "Thiago"});
            this.cbbTecnico.Location = new System.Drawing.Point(463, 25);
            this.cbbTecnico.Name = "cbbTecnico";
            this.cbbTecnico.Size = new System.Drawing.Size(121, 21);
            this.cbbTecnico.TabIndex = 2;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(234, 53);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(123, 20);
            this.txtContato.TabIndex = 4;
            // 
            // dgvOutrosAtendimentos
            // 
            this.dgvOutrosAtendimentos.AllowUserToAddRows = false;
            this.dgvOutrosAtendimentos.AllowUserToDeleteRows = false;
            this.dgvOutrosAtendimentos.AllowUserToResizeRows = false;
            this.dgvOutrosAtendimentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvOutrosAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutrosAtendimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.aberto,
            this.fk_idempresa,
            this.atendimento,
            this.resumo,
            this.fk_idtecnico,
            this.data,
            this.data_final,
            this.telefone});
            this.dgvOutrosAtendimentos.Location = new System.Drawing.Point(12, 227);
            this.dgvOutrosAtendimentos.MultiSelect = false;
            this.dgvOutrosAtendimentos.Name = "dgvOutrosAtendimentos";
            this.dgvOutrosAtendimentos.ReadOnly = true;
            this.dgvOutrosAtendimentos.RowHeadersVisible = false;
            this.dgvOutrosAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutrosAtendimentos.Size = new System.Drawing.Size(855, 334);
            this.dgvOutrosAtendimentos.TabIndex = 8;
            this.dgvOutrosAtendimentos.TabStop = false;
            this.dgvOutrosAtendimentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutrosAtendimentos_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // aberto
            // 
            this.aberto.DataPropertyName = "aberto";
            this.aberto.HeaderText = "aberto";
            this.aberto.Name = "aberto";
            this.aberto.ReadOnly = true;
            this.aberto.Visible = false;
            // 
            // fk_idempresa
            // 
            this.fk_idempresa.DataPropertyName = "fk_idempresa";
            this.fk_idempresa.HeaderText = "fk_idempresa";
            this.fk_idempresa.Name = "fk_idempresa";
            this.fk_idempresa.ReadOnly = true;
            this.fk_idempresa.Visible = false;
            // 
            // atendimento
            // 
            this.atendimento.DataPropertyName = "atendimento";
            this.atendimento.HeaderText = "atendimento";
            this.atendimento.Name = "atendimento";
            this.atendimento.ReadOnly = true;
            this.atendimento.Visible = false;
            // 
            // resumo
            // 
            this.resumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.resumo.DataPropertyName = "resumo";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resumo.DefaultCellStyle = dataGridViewCellStyle2;
            this.resumo.HeaderText = "Resumo";
            this.resumo.Name = "resumo";
            this.resumo.ReadOnly = true;
            this.resumo.Width = 71;
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
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data Inicio";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 83;
            // 
            // data_final
            // 
            this.data_final.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.data_final.DataPropertyName = "dataFinal";
            this.data_final.HeaderText = "Data Fim";
            this.data_final.Name = "data_final";
            this.data_final.ReadOnly = true;
            this.data_final.Width = 74;
            // 
            // telefone
            // 
            this.telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 74;
            // 
            // txtResumo
            // 
            this.txtResumo.Location = new System.Drawing.Point(12, 93);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(855, 128);
            this.txtResumo.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Blue;
            this.btnSalvar.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(686, 51);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Finalizar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Blue;
            this.btnSair.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(792, 51);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtEmpresaID
            // 
            this.txtEmpresaID.Location = new System.Drawing.Point(75, -1);
            this.txtEmpresaID.Name = "txtEmpresaID";
            this.txtEmpresaID.Size = new System.Drawing.Size(25, 20);
            this.txtEmpresaID.TabIndex = 12;
            this.txtEmpresaID.Visible = false;
            // 
            // txtChamadoID
            // 
            this.txtChamadoID.Location = new System.Drawing.Point(15, -1);
            this.txtChamadoID.Name = "txtChamadoID";
            this.txtChamadoID.Size = new System.Drawing.Size(23, 20);
            this.txtChamadoID.TabIndex = 13;
            this.txtChamadoID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Atendimento:";
            // 
            // cbbAtendimento
            // 
            this.cbbAtendimento.AllowDrop = true;
            this.cbbAtendimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAtendimento.FormattingEnabled = true;
            this.cbbAtendimento.Items.AddRange(new object[] {
            "Contrato",
            "Avulso",
            "Garantia",
            "Sem Contrato",
            "Só Registro"});
            this.cbbAtendimento.Location = new System.Drawing.Point(463, 53);
            this.cbbAtendimento.Name = "cbbAtendimento";
            this.cbbAtendimento.Size = new System.Drawing.Size(121, 21);
            this.cbbAtendimento.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(70, 53);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // frmAtenderChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(879, 573);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.cbbAtendimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChamadoID);
            this.Controls.Add(this.txtEmpresaID);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.dgvOutrosAtendimentos);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.cbbTecnico);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtenderChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atender Chamado";
            this.Load += new System.EventHandler(this.frmAtenderChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutrosAtendimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTecnico;
        private System.Windows.Forms.DataGridView dgvOutrosAtendimentos;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.TextBox txtEmpresa;
        public System.Windows.Forms.TextBox txtContato;
        public System.Windows.Forms.TextBox txtEmpresaID;
        public System.Windows.Forms.TextBox txtChamadoID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idtecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
    }
}