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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtEmpresaID = new System.Windows.Forms.TextBox();
            this.txtChamadoID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbAtendimento = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDataBloqueio = new System.Windows.Forms.TextBox();
            this.lblBloqueio = new System.Windows.Forms.Label();
            this.lblDataBloqueio = new System.Windows.Forms.Label();
            this.dgvDsc = new System.Windows.Forms.DataGridView();
            this.dt_dem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_vlr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chvbfj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chvori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chvvnda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vndBchvps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pschvps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutrosAtendimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Técnico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contato:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(178, 18);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(385, 20);
            this.txtEmpresa.TabIndex = 9;
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
            "Outros"});
            this.cbbTecnico.Location = new System.Drawing.Point(63, 45);
            this.cbbTecnico.Name = "cbbTecnico";
            this.cbbTecnico.Size = new System.Drawing.Size(103, 21);
            this.cbbTecnico.TabIndex = 1;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(226, 45);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(103, 20);
            this.txtContato.TabIndex = 3;
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
            this.telefone,
            this.Contato});
            this.dgvOutrosAtendimentos.Location = new System.Drawing.Point(12, 197);
            this.dgvOutrosAtendimentos.MultiSelect = false;
            this.dgvOutrosAtendimentos.Name = "dgvOutrosAtendimentos";
            this.dgvOutrosAtendimentos.ReadOnly = true;
            this.dgvOutrosAtendimentos.RowHeadersVisible = false;
            this.dgvOutrosAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutrosAtendimentos.Size = new System.Drawing.Size(855, 334);
            this.dgvOutrosAtendimentos.TabIndex = 8;
            this.dgvOutrosAtendimentos.TabStop = false;
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
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resumo.DefaultCellStyle = dataGridViewCellStyle9;
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
            // Contato
            // 
            this.Contato.DataPropertyName = "contato";
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            // 
            // txtResumo
            // 
            this.txtResumo.Location = new System.Drawing.Point(12, 70);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(582, 114);
            this.txtResumo.TabIndex = 5;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Blue;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalizar.Location = new System.Drawing.Point(711, 40);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Blue;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(792, 40);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtEmpresaID
            // 
            this.txtEmpresaID.Location = new System.Drawing.Point(38, 60);
            this.txtEmpresaID.Name = "txtEmpresaID";
            this.txtEmpresaID.Size = new System.Drawing.Size(25, 20);
            this.txtEmpresaID.TabIndex = 12;
            this.txtEmpresaID.Visible = false;
            // 
            // txtChamadoID
            // 
            this.txtChamadoID.Location = new System.Drawing.Point(12, 60);
            this.txtChamadoID.Name = "txtChamadoID";
            this.txtChamadoID.Size = new System.Drawing.Size(23, 20);
            this.txtChamadoID.TabIndex = 13;
            this.txtChamadoID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 49);
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
            "Só Registro",
            "Só Duvidas"});
            this.cbbAtendimento.Location = new System.Drawing.Point(572, 45);
            this.cbbAtendimento.Name = "cbbAtendimento";
            this.cbbAtendimento.Size = new System.Drawing.Size(103, 21);
            this.cbbAtendimento.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(400, 45);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Blue;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(792, 11);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDataBloqueio
            // 
            this.txtDataBloqueio.Location = new System.Drawing.Point(571, 18);
            this.txtDataBloqueio.Name = "txtDataBloqueio";
            this.txtDataBloqueio.ReadOnly = true;
            this.txtDataBloqueio.Size = new System.Drawing.Size(88, 20);
            this.txtDataBloqueio.TabIndex = 10;
            // 
            // lblBloqueio
            // 
            this.lblBloqueio.AutoSize = true;
            this.lblBloqueio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBloqueio.ForeColor = System.Drawing.Color.Red;
            this.lblBloqueio.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblBloqueio.Location = new System.Drawing.Point(661, 17);
            this.lblBloqueio.Name = "lblBloqueio";
            this.lblBloqueio.Size = new System.Drawing.Size(129, 20);
            this.lblBloqueio.TabIndex = 16;
            this.lblBloqueio.Text = "BLOQUEADA !";
            this.lblBloqueio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBloqueio.Visible = false;
            // 
            // lblDataBloqueio
            // 
            this.lblDataBloqueio.AutoSize = true;
            this.lblDataBloqueio.Location = new System.Drawing.Point(571, 2);
            this.lblDataBloqueio.Name = "lblDataBloqueio";
            this.lblDataBloqueio.Size = new System.Drawing.Size(77, 13);
            this.lblDataBloqueio.TabIndex = 17;
            this.lblDataBloqueio.Text = "Data Bloqueio:";
            // 
            // dgvDsc
            // 
            this.dgvDsc.AllowUserToAddRows = false;
            this.dgvDsc.AllowUserToDeleteRows = false;
            this.dgvDsc.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDsc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDsc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDsc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsc.ColumnHeadersVisible = false;
            this.dgvDsc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dt_dem,
            this.Dsc,
            this.c_vlr,
            this.chvbfj,
            this.chvori,
            this.chvvnda,
            this.vndBchvps,
            this.pschvps});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDsc.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDsc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDsc.Location = new System.Drawing.Point(600, 70);
            this.dgvDsc.MultiSelect = false;
            this.dgvDsc.Name = "dgvDsc";
            this.dgvDsc.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsc.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDsc.RowHeadersVisible = false;
            this.dgvDsc.Size = new System.Drawing.Size(267, 114);
            this.dgvDsc.TabIndex = 18;
            this.dgvDsc.TabStop = false;
            // 
            // dt_dem
            // 
            this.dt_dem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dt_dem.DataPropertyName = "dt_dem";
            this.dt_dem.HeaderText = "Data";
            this.dt_dem.Name = "dt_dem";
            this.dt_dem.ReadOnly = true;
            this.dt_dem.Width = 5;
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
            // chvbfj
            // 
            this.chvbfj.DataPropertyName = "chvbfj";
            this.chvbfj.HeaderText = "chvbfj";
            this.chvbfj.Name = "chvbfj";
            this.chvbfj.ReadOnly = true;
            this.chvbfj.Visible = false;
            // 
            // chvori
            // 
            this.chvori.DataPropertyName = "chvori";
            this.chvori.HeaderText = "chvori";
            this.chvori.Name = "chvori";
            this.chvori.ReadOnly = true;
            this.chvori.Visible = false;
            // 
            // chvvnda
            // 
            this.chvvnda.DataPropertyName = "chvvnda";
            this.chvvnda.HeaderText = "chvvnda";
            this.chvvnda.Name = "chvvnda";
            this.chvvnda.ReadOnly = true;
            this.chvvnda.Visible = false;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "CNPJ:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(12, 18);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.ReadOnly = true;
            this.txtCNPJ.Size = new System.Drawing.Size(154, 20);
            this.txtCNPJ.TabIndex = 20;
            // 
            // frmAtenderChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(879, 546);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.txtEmpresaID);
            this.Controls.Add(this.txtChamadoID);
            this.Controls.Add(this.dgvDsc);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblDataBloqueio);
            this.Controls.Add(this.lblBloqueio);
            this.Controls.Add(this.txtDataBloqueio);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.cbbAtendimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFinalizar);
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
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atender Chamado";
            this.Load += new System.EventHandler(this.frmAtenderChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutrosAtendimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOutrosAtendimentos;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.TextBox txtEmpresa;
        public System.Windows.Forms.TextBox txtContato;
        public System.Windows.Forms.TextBox txtEmpresaID;
        public System.Windows.Forms.TextBox txtChamadoID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.ComboBox cbbTecnico;
        public System.Windows.Forms.TextBox txtResumo;
        public System.Windows.Forms.ComboBox cbbAtendimento;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idtecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.TextBox txtDataBloqueio;
        private System.Windows.Forms.Label lblBloqueio;
        private System.Windows.Forms.Label lblDataBloqueio;
        private System.Windows.Forms.DataGridView dgvDsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_dem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_vlr;
        private System.Windows.Forms.DataGridViewTextBoxColumn chvbfj;
        private System.Windows.Forms.DataGridViewTextBoxColumn chvori;
        private System.Windows.Forms.DataGridViewTextBoxColumn chvvnda;
        private System.Windows.Forms.DataGridViewTextBoxColumn vndBchvps;
        private System.Windows.Forms.DataGridViewTextBoxColumn pschvps;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCNPJ;
    }
}