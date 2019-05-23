using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CamadaDados;
using CamadaModelos;
using System.Data.OleDb;

namespace Chamados
{
    public partial class frmAbrirChamado : Form
    {

        public frmAbrirChamado()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAbrirChamado_Load(object sender, EventArgs e)
        {
            cbbSelecao.SelectedIndex = 1;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProcurar.Text = "";
            txtAbrirChamadoNome.Text = "";
        }

        void Procurar()
        {
           /* string str = txtProcurar.Text;
            string test = str.Replace("/", "").Replace(".", "").Replace("-", "");
            txtProcurar.Text = test;
            txtProcurar.Select(txtProcurar.Text.Length, 0);
            tirar pontuaccao do cnpj
            */
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.FiltroAbrirChamado = cbbSelecao.Text;

            txtProcurar.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            label1.Text = txtProcurar.Text; //texto não formatado
            _mdlEmpresa.FiltrotxtProcurar = label1.Text;

            dgvResultado.DataSource = _ctlEmpresa.PesquisarMDL(_mdlEmpresa);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Procurar();
        }
        
        private void dgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvResultado.CurrentRow != null)
            {
                txtAbrirChamadoNome.Text = dgvResultado.CurrentRow.Cells["nome"].Value.ToString();
                txtAbrirChamadoID.Text = dgvResultado.CurrentRow.Cells["id"].Value.ToString();
                txtAbrirChamadoCNPJ.Text = dgvResultado.CurrentRow.Cells["CNPJ"].Value.ToString();
            }

           
        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void AbrirChamado()
        {

            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();

            if (txtAbrirChamadoNome.Text == "")
            {
                MessageBox.Show("Selecione uma empresa !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcurar.Focus();
            }
            else
            {
                mdlEmpresa _mdlEmpresaDup  = new mdlEmpresa();
                string Nome = txtAbrirChamadoCNPJ.Text;
                _mdlEmpresaDup.Nome = Nome;
                bool duplicado = ctlEmpresa.VerificarDuplicidade(Nome);
                if (duplicado)
                {
                    _mdlEmpresa.ID = dgvResultado.CurrentRow.Cells["id"].Value.ToString();
                    _mdlEmpresa.CNPJ = dgvResultado.CurrentRow.Cells["CNPJ"].Value.ToString();
                    _mdlEmpresa.Nome = dgvResultado.CurrentRow.Cells["Nome"].Value.ToString();

                    bool retornoComp = _ctlEmpresa.AbrirSoChamado(_mdlEmpresa);
                    if (retornoComp)
                    {
                        MessageBox.Show("Chamado Aberto com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao abrir chamado", "ERRO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                _mdlEmpresa.ID = dgvResultado.CurrentRow.Cells["id"].Value.ToString();
                _mdlEmpresa.CNPJ = dgvResultado.CurrentRow.Cells["CNPJ"].Value.ToString();
                _mdlEmpresa.Nome = dgvResultado.CurrentRow.Cells["Nome"].Value.ToString();

                bool retorno1 = _ctlEmpresa.AbrirChamadoCompleto(_mdlEmpresa);
                if (retorno1)
                {
                    MessageBox.Show("Chamado Aberto com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                    /* dgvResultado.DataSource = null;
                     txtEmpresaAbrirChamado.Text = "";
                     txtProcurar.Text = "";
                     txtProcurar.Focus(); */
                }
                else
                {
                    MessageBox.Show("Erro ao abrir chamado", "ERRO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            AbrirChamado();
        }

        private void txtProcurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtProcurar.Text.Length >= 2)
            {
                Procurar();
            }
        }

        private void dgvResultado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirChamado();
        }

        private void txtProcurar_Enter(object sender, EventArgs e)
        {

        }

        private void txtProcurar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtProcurar_Enter_1(object sender, EventArgs e)
        {
            /*
            if (cbbSelecao.Text == "CNPJ")
            {
                txtProcurar.Mask = "00.000.000/0000-00";
            }
            else if (cbbSelecao.Text == "Nome")
            {
                txtProcurar.Mask = "";
            }
            substituido por txtProcurar_KeyPress_1
            */
        }

        private void txtProcurar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbbSelecao.Text == "CNPJ")
            {
                if (txtProcurar.TextLength == 2)
                {
                    txtProcurar.Text += ".";
                    txtProcurar.Select(txtProcurar.TextLength, 0);
                }
                else if (txtProcurar.TextLength == 6)
                {
                    txtProcurar.Text += ".";
                    txtProcurar.Select(txtProcurar.TextLength, 0);
                }
                else if (txtProcurar.TextLength == 10)
                {
                    txtProcurar.Text += "/";
                    txtProcurar.Select(txtProcurar.TextLength, 0);
                }
                else if (txtProcurar.TextLength == 15)
                {
                    txtProcurar.Text += "-";
                    txtProcurar.Select(txtProcurar.TextLength, 0);
                }
                txtProcurar.MaxLength = 16;

            }
        }
    }
}
