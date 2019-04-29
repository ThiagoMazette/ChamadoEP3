namespace Chamados
{
    partial class frmCadastro
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
            this.tabCaddastro = new System.Windows.Forms.TabControl();
            this.tabEmpresa = new System.Windows.Forms.TabPage();
            this.txtEmpresaCNPJ = new System.Windows.Forms.TextBox();
            this.txtEmpresaTelefone = new System.Windows.Forms.TextBox();
            this.txtEmpresaNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpresaSair = new System.Windows.Forms.Button();
            this.btnEmpresaLimpar = new System.Windows.Forms.Button();
            this.btnEmpresaCasdastrar = new System.Windows.Forms.Button();
            this.tabTecnico = new System.Windows.Forms.TabPage();
            this.btnTecnicoSair = new System.Windows.Forms.Button();
            this.btnTecnicoLimpar = new System.Windows.Forms.Button();
            this.btnTecnicoCadastrar = new System.Windows.Forms.Button();
            this.txtTecnicoRamal = new System.Windows.Forms.TextBox();
            this.txtTecnicoNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabCaddastro.SuspendLayout();
            this.tabEmpresa.SuspendLayout();
            this.tabTecnico.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCaddastro
            // 
            this.tabCaddastro.Controls.Add(this.tabEmpresa);
            this.tabCaddastro.Controls.Add(this.tabTecnico);
            this.tabCaddastro.Location = new System.Drawing.Point(0, 0);
            this.tabCaddastro.Name = "tabCaddastro";
            this.tabCaddastro.SelectedIndex = 0;
            this.tabCaddastro.Size = new System.Drawing.Size(327, 185);
            this.tabCaddastro.TabIndex = 0;
            // 
            // tabEmpresa
            // 
            this.tabEmpresa.Controls.Add(this.txtEmpresaCNPJ);
            this.tabEmpresa.Controls.Add(this.txtEmpresaTelefone);
            this.tabEmpresa.Controls.Add(this.txtEmpresaNome);
            this.tabEmpresa.Controls.Add(this.label3);
            this.tabEmpresa.Controls.Add(this.label2);
            this.tabEmpresa.Controls.Add(this.label1);
            this.tabEmpresa.Controls.Add(this.btnEmpresaSair);
            this.tabEmpresa.Controls.Add(this.btnEmpresaLimpar);
            this.tabEmpresa.Controls.Add(this.btnEmpresaCasdastrar);
            this.tabEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tabEmpresa.Name = "tabEmpresa";
            this.tabEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpresa.Size = new System.Drawing.Size(319, 159);
            this.tabEmpresa.TabIndex = 0;
            this.tabEmpresa.Text = "Empresa";
            this.tabEmpresa.UseVisualStyleBackColor = true;
            // 
            // txtEmpresaCNPJ
            // 
            this.txtEmpresaCNPJ.Location = new System.Drawing.Point(90, 27);
            this.txtEmpresaCNPJ.Name = "txtEmpresaCNPJ";
            this.txtEmpresaCNPJ.Size = new System.Drawing.Size(170, 20);
            this.txtEmpresaCNPJ.TabIndex = 6;
            // 
            // txtEmpresaTelefone
            // 
            this.txtEmpresaTelefone.Location = new System.Drawing.Point(90, 91);
            this.txtEmpresaTelefone.Name = "txtEmpresaTelefone";
            this.txtEmpresaTelefone.Size = new System.Drawing.Size(170, 20);
            this.txtEmpresaTelefone.TabIndex = 2;
            // 
            // txtEmpresaNome
            // 
            this.txtEmpresaNome.Location = new System.Drawing.Point(90, 58);
            this.txtEmpresaNome.Name = "txtEmpresaNome";
            this.txtEmpresaNome.Size = new System.Drawing.Size(170, 20);
            this.txtEmpresaNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CNPJ:";
            // 
            // btnEmpresaSair
            // 
            this.btnEmpresaSair.Location = new System.Drawing.Point(238, 122);
            this.btnEmpresaSair.Name = "btnEmpresaSair";
            this.btnEmpresaSair.Size = new System.Drawing.Size(75, 23);
            this.btnEmpresaSair.TabIndex = 5;
            this.btnEmpresaSair.Text = "Voltar";
            this.btnEmpresaSair.UseVisualStyleBackColor = true;
            this.btnEmpresaSair.Click += new System.EventHandler(this.btnEmpresaSair_Click);
            // 
            // btnEmpresaLimpar
            // 
            this.btnEmpresaLimpar.Location = new System.Drawing.Point(128, 122);
            this.btnEmpresaLimpar.Name = "btnEmpresaLimpar";
            this.btnEmpresaLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpresaLimpar.TabIndex = 4;
            this.btnEmpresaLimpar.Text = "Limpar";
            this.btnEmpresaLimpar.UseVisualStyleBackColor = true;
            this.btnEmpresaLimpar.Click += new System.EventHandler(this.btnEmpresaLimpar_Click);
            // 
            // btnEmpresaCasdastrar
            // 
            this.btnEmpresaCasdastrar.Location = new System.Drawing.Point(35, 122);
            this.btnEmpresaCasdastrar.Name = "btnEmpresaCasdastrar";
            this.btnEmpresaCasdastrar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpresaCasdastrar.TabIndex = 3;
            this.btnEmpresaCasdastrar.Text = "Cadastrar";
            this.btnEmpresaCasdastrar.UseVisualStyleBackColor = true;
            this.btnEmpresaCasdastrar.Click += new System.EventHandler(this.btnEmpresaCasdastrar_Click);
            // 
            // tabTecnico
            // 
            this.tabTecnico.Controls.Add(this.btnTecnicoSair);
            this.tabTecnico.Controls.Add(this.btnTecnicoLimpar);
            this.tabTecnico.Controls.Add(this.btnTecnicoCadastrar);
            this.tabTecnico.Controls.Add(this.txtTecnicoRamal);
            this.tabTecnico.Controls.Add(this.txtTecnicoNome);
            this.tabTecnico.Controls.Add(this.label5);
            this.tabTecnico.Controls.Add(this.label4);
            this.tabTecnico.Location = new System.Drawing.Point(4, 22);
            this.tabTecnico.Name = "tabTecnico";
            this.tabTecnico.Padding = new System.Windows.Forms.Padding(3);
            this.tabTecnico.Size = new System.Drawing.Size(319, 159);
            this.tabTecnico.TabIndex = 1;
            this.tabTecnico.Text = "Técnico";
            this.tabTecnico.UseVisualStyleBackColor = true;
            // 
            // btnTecnicoSair
            // 
            this.btnTecnicoSair.Location = new System.Drawing.Point(238, 113);
            this.btnTecnicoSair.Name = "btnTecnicoSair";
            this.btnTecnicoSair.Size = new System.Drawing.Size(75, 23);
            this.btnTecnicoSair.TabIndex = 5;
            this.btnTecnicoSair.Text = "Voltar";
            this.btnTecnicoSair.UseVisualStyleBackColor = true;
            this.btnTecnicoSair.Click += new System.EventHandler(this.btnTecnicoSair_Click);
            // 
            // btnTecnicoLimpar
            // 
            this.btnTecnicoLimpar.Location = new System.Drawing.Point(128, 113);
            this.btnTecnicoLimpar.Name = "btnTecnicoLimpar";
            this.btnTecnicoLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnTecnicoLimpar.TabIndex = 4;
            this.btnTecnicoLimpar.Text = "Limpar";
            this.btnTecnicoLimpar.UseVisualStyleBackColor = true;
            this.btnTecnicoLimpar.Click += new System.EventHandler(this.btnTecnicoLimpar_Click);
            // 
            // btnTecnicoCadastrar
            // 
            this.btnTecnicoCadastrar.Location = new System.Drawing.Point(47, 113);
            this.btnTecnicoCadastrar.Name = "btnTecnicoCadastrar";
            this.btnTecnicoCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnTecnicoCadastrar.TabIndex = 3;
            this.btnTecnicoCadastrar.Text = "Cadastrar";
            this.btnTecnicoCadastrar.UseVisualStyleBackColor = true;
            this.btnTecnicoCadastrar.Click += new System.EventHandler(this.btnTecnicoCadastrar_Click);
            // 
            // txtTecnicoRamal
            // 
            this.txtTecnicoRamal.Location = new System.Drawing.Point(77, 64);
            this.txtTecnicoRamal.Name = "txtTecnicoRamal";
            this.txtTecnicoRamal.Size = new System.Drawing.Size(126, 20);
            this.txtTecnicoRamal.TabIndex = 2;
            // 
            // txtTecnicoNome
            // 
            this.txtTecnicoNome.Location = new System.Drawing.Point(75, 27);
            this.txtTecnicoNome.Name = "txtTecnicoNome";
            this.txtTecnicoNome.Size = new System.Drawing.Size(126, 20);
            this.txtTecnicoNome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ramal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome:";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 190);
            this.Controls.Add(this.tabCaddastro);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.tabCaddastro.ResumeLayout(false);
            this.tabEmpresa.ResumeLayout(false);
            this.tabEmpresa.PerformLayout();
            this.tabTecnico.ResumeLayout(false);
            this.tabTecnico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCaddastro;
        private System.Windows.Forms.TabPage tabEmpresa;
        private System.Windows.Forms.TabPage tabTecnico;
        private System.Windows.Forms.Button btnEmpresaSair;
        private System.Windows.Forms.Button btnEmpresaLimpar;
        private System.Windows.Forms.Button btnEmpresaCasdastrar;
        private System.Windows.Forms.TextBox txtEmpresaTelefone;
        private System.Windows.Forms.TextBox txtEmpresaNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTecnicoRamal;
        private System.Windows.Forms.TextBox txtTecnicoNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTecnicoSair;
        private System.Windows.Forms.Button btnTecnicoLimpar;
        private System.Windows.Forms.Button btnTecnicoCadastrar;
        private System.Windows.Forms.TextBox txtEmpresaCNPJ;
    }
}