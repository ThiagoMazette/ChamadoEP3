namespace Chamados
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnAbrirChamado = new System.Windows.Forms.Button();
            this.btnAtenderChamado = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnComoEsta = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirChamado
            // 
            this.btnAbrirChamado.BackColor = System.Drawing.Color.Green;
            this.btnAbrirChamado.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirChamado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbrirChamado.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirChamado.Name = "btnAbrirChamado";
            this.btnAbrirChamado.Size = new System.Drawing.Size(133, 131);
            this.btnAbrirChamado.TabIndex = 1;
            this.btnAbrirChamado.Text = "Abrir Chamado";
            this.btnAbrirChamado.UseVisualStyleBackColor = false;
            this.btnAbrirChamado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtenderChamado
            // 
            this.btnAtenderChamado.BackColor = System.Drawing.Color.Green;
            this.btnAtenderChamado.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAtenderChamado.ForeColor = System.Drawing.Color.White;
            this.btnAtenderChamado.Location = new System.Drawing.Point(192, 12);
            this.btnAtenderChamado.Name = "btnAtenderChamado";
            this.btnAtenderChamado.Size = new System.Drawing.Size(133, 131);
            this.btnAtenderChamado.TabIndex = 2;
            this.btnAtenderChamado.Text = "Atender Chamado";
            this.btnAtenderChamado.UseVisualStyleBackColor = false;
            this.btnAtenderChamado.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Green;
            this.btnListar.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnListar.Location = new System.Drawing.Point(12, 208);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(133, 132);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Integracao 2.9.5";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Green;
            this.btnCadastrar.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.Location = new System.Drawing.Point(192, 208);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 132);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Visible = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnComoEsta
            // 
            this.btnComoEsta.ForeColor = System.Drawing.Color.Silver;
            this.btnComoEsta.Location = new System.Drawing.Point(12, 538);
            this.btnComoEsta.Name = "btnComoEsta";
            this.btnComoEsta.Size = new System.Drawing.Size(133, 23);
            this.btnComoEsta.TabIndex = 6;
            this.btnComoEsta.Text = "Como Está?";
            this.btnComoEsta.UseVisualStyleBackColor = true;
            this.btnComoEsta.Visible = false;
            this.btnComoEsta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnComoEsta_MouseDown);
            this.btnComoEsta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnComoEsta_MouseUp);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.ForeColor = System.Drawing.Color.Silver;
            this.btnAtualizar.Location = new System.Drawing.Point(12, 538);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(133, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Deseja Atualizar ?";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAtenderChamado);
            this.Controls.Add(this.btnAbrirChamado);
            this.Controls.Add(this.btnComoEsta);
            this.Controls.Add(this.btnAtualizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Chamados - REP Relogios *Demonstação*  -  Thiago Mazette";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirChamado;
        private System.Windows.Forms.Button btnAtenderChamado;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnComoEsta;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

