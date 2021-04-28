namespace Chamados
{
    partial class frmListarChamado
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
            this.dgvSendoAtendido = new System.Windows.Forms.DataGridView();
            this.EmpresaIDSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChamadoIDSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendimentoSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_finalSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abertoSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idempresaSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idtecnicoSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumoSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.EmpresaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aberto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idtecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendoAtendido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSendoAtendido
            // 
            this.dgvSendoAtendido.AllowUserToAddRows = false;
            this.dgvSendoAtendido.AllowUserToDeleteRows = false;
            this.dgvSendoAtendido.AllowUserToResizeRows = false;
            this.dgvSendoAtendido.BackgroundColor = System.Drawing.Color.White;
            this.dgvSendoAtendido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendoAtendido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpresaIDSA,
            this.cnpjSA,
            this.telefoneSA,
            this.ChamadoIDSA,
            this.atendimentoSA,
            this.data_finalSA,
            this.abertoSA,
            this.fk_idempresaSA,
            this.NomeSA,
            this.fk_idtecnicoSA,
            this.contatoSA,
            this.resumoSA,
            this.dataSA});
            this.dgvSendoAtendido.Location = new System.Drawing.Point(19, 260);
            this.dgvSendoAtendido.MultiSelect = false;
            this.dgvSendoAtendido.Name = "dgvSendoAtendido";
            this.dgvSendoAtendido.ReadOnly = true;
            this.dgvSendoAtendido.RowHeadersVisible = false;
            this.dgvSendoAtendido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSendoAtendido.Size = new System.Drawing.Size(468, 165);
            this.dgvSendoAtendido.TabIndex = 11;
            this.dgvSendoAtendido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSendoAtendido_CellClick);
            // 
            // EmpresaIDSA
            // 
            this.EmpresaIDSA.DataPropertyName = "tb_empresas.id";
            this.EmpresaIDSA.HeaderText = "Empresa ID";
            this.EmpresaIDSA.Name = "EmpresaIDSA";
            this.EmpresaIDSA.ReadOnly = true;
            this.EmpresaIDSA.Visible = false;
            // 
            // cnpjSA
            // 
            this.cnpjSA.DataPropertyName = "cnpj";
            this.cnpjSA.HeaderText = "cnpj";
            this.cnpjSA.Name = "cnpjSA";
            this.cnpjSA.ReadOnly = true;
            this.cnpjSA.Visible = false;
            // 
            // telefoneSA
            // 
            this.telefoneSA.DataPropertyName = "telefone";
            this.telefoneSA.HeaderText = "telefone";
            this.telefoneSA.Name = "telefoneSA";
            this.telefoneSA.ReadOnly = true;
            this.telefoneSA.Visible = false;
            // 
            // ChamadoIDSA
            // 
            this.ChamadoIDSA.DataPropertyName = "tb_chamados.id";
            this.ChamadoIDSA.HeaderText = "Chamado ID";
            this.ChamadoIDSA.Name = "ChamadoIDSA";
            this.ChamadoIDSA.ReadOnly = true;
            this.ChamadoIDSA.Visible = false;
            // 
            // atendimentoSA
            // 
            this.atendimentoSA.DataPropertyName = "atendimento";
            this.atendimentoSA.HeaderText = "atendimento";
            this.atendimentoSA.Name = "atendimentoSA";
            this.atendimentoSA.ReadOnly = true;
            this.atendimentoSA.Visible = false;
            // 
            // data_finalSA
            // 
            this.data_finalSA.DataPropertyName = "data_final";
            this.data_finalSA.HeaderText = "data_final";
            this.data_finalSA.Name = "data_finalSA";
            this.data_finalSA.ReadOnly = true;
            this.data_finalSA.Visible = false;
            // 
            // abertoSA
            // 
            this.abertoSA.DataPropertyName = "aberto";
            this.abertoSA.HeaderText = "aberto";
            this.abertoSA.Name = "abertoSA";
            this.abertoSA.ReadOnly = true;
            this.abertoSA.Visible = false;
            // 
            // fk_idempresaSA
            // 
            this.fk_idempresaSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fk_idempresaSA.DataPropertyName = "fk_idempresa";
            this.fk_idempresaSA.HeaderText = "fk_idempresa";
            this.fk_idempresaSA.Name = "fk_idempresaSA";
            this.fk_idempresaSA.ReadOnly = true;
            this.fk_idempresaSA.Visible = false;
            // 
            // NomeSA
            // 
            this.NomeSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeSA.DataPropertyName = "Nome";
            this.NomeSA.HeaderText = "Nome";
            this.NomeSA.Name = "NomeSA";
            this.NomeSA.ReadOnly = true;
            // 
            // fk_idtecnicoSA
            // 
            this.fk_idtecnicoSA.DataPropertyName = "fk_idtecnico";
            this.fk_idtecnicoSA.HeaderText = "Tecnico";
            this.fk_idtecnicoSA.Name = "fk_idtecnicoSA";
            this.fk_idtecnicoSA.ReadOnly = true;
            // 
            // contatoSA
            // 
            this.contatoSA.DataPropertyName = "contato";
            this.contatoSA.HeaderText = "contato";
            this.contatoSA.Name = "contatoSA";
            this.contatoSA.ReadOnly = true;
            this.contatoSA.Visible = false;
            // 
            // resumoSA
            // 
            this.resumoSA.DataPropertyName = "resumo";
            this.resumoSA.HeaderText = "resumo";
            this.resumoSA.Name = "resumoSA";
            this.resumoSA.ReadOnly = true;
            this.resumoSA.Visible = false;
            // 
            // dataSA
            // 
            this.dataSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataSA.DataPropertyName = "data";
            this.dataSA.HeaderText = "Data";
            this.dataSA.Name = "dataSA";
            this.dataSA.ReadOnly = true;
            this.dataSA.Width = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sendo atendidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Para atender:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Blue;
            this.btnVoltar.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(493, 402);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(84, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Blue;
            this.btnAtualizar.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(493, 32);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(84, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToResizeRows = false;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpresaID,
            this.cnpj,
            this.telefone,
            this.chamadoId,
            this.atendimento,
            this.data_final,
            this.aberto,
            this.fk_idempresa,
            this.Nome,
            this.fk_idtecnico,
            this.contato,
            this.resumo,
            this.data});
            this.dgvResultado.Location = new System.Drawing.Point(19, 32);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(468, 192);
            this.dgvResultado.TabIndex = 6;
            this.dgvResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellClick);
            // 
            // EmpresaID
            // 
            this.EmpresaID.DataPropertyName = "tb_empresas.id";
            this.EmpresaID.HeaderText = "Empresa ID";
            this.EmpresaID.Name = "EmpresaID";
            this.EmpresaID.ReadOnly = true;
            this.EmpresaID.Visible = false;
            // 
            // cnpj
            // 
            this.cnpj.DataPropertyName = "cnpj";
            this.cnpj.HeaderText = "cnpj";
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            this.cnpj.Visible = false;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Visible = false;
            // 
            // chamadoId
            // 
            this.chamadoId.DataPropertyName = "tb_chamados.id";
            this.chamadoId.HeaderText = "Chamado ID";
            this.chamadoId.Name = "chamadoId";
            this.chamadoId.ReadOnly = true;
            this.chamadoId.Visible = false;
            // 
            // atendimento
            // 
            this.atendimento.DataPropertyName = "atendimento";
            this.atendimento.HeaderText = "atendimento";
            this.atendimento.Name = "atendimento";
            this.atendimento.ReadOnly = true;
            this.atendimento.Visible = false;
            // 
            // data_final
            // 
            this.data_final.DataPropertyName = "data_final";
            this.data_final.HeaderText = "data_final";
            this.data_final.Name = "data_final";
            this.data_final.ReadOnly = true;
            this.data_final.Visible = false;
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
            this.fk_idempresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fk_idempresa.DataPropertyName = "fk_idempresa";
            this.fk_idempresa.HeaderText = "fk_idempresa";
            this.fk_idempresa.Name = "fk_idempresa";
            this.fk_idempresa.ReadOnly = true;
            this.fk_idempresa.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // fk_idtecnico
            // 
            this.fk_idtecnico.DataPropertyName = "fk_idtecnico";
            this.fk_idtecnico.HeaderText = "Tecnico";
            this.fk_idtecnico.Name = "fk_idtecnico";
            this.fk_idtecnico.ReadOnly = true;
            this.fk_idtecnico.Visible = false;
            // 
            // contato
            // 
            this.contato.DataPropertyName = "contato";
            this.contato.HeaderText = "contato";
            this.contato.Name = "contato";
            this.contato.ReadOnly = true;
            this.contato.Visible = false;
            // 
            // resumo
            // 
            this.resumo.DataPropertyName = "resumo";
            this.resumo.HeaderText = "resumo";
            this.resumo.Name = "resumo";
            this.resumo.ReadOnly = true;
            this.resumo.Visible = false;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 55;
            // 
            // frmListarChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(593, 438);
            this.Controls.Add(this.dgvSendoAtendido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarChamado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Chamado";
            this.Load += new System.EventHandler(this.frmListarChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendoAtendido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSendoAtendido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpresaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamadoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn aberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idtecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpresaIDSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChamadoIDSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendimentoSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_finalSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn abertoSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idempresaSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idtecnicoSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumoSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSA;
    }
}