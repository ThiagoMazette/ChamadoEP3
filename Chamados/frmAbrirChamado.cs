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

        void DataBloqueio()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.txtAbrirChamadoID = txtAbrirChamadoID.Text;

            txtDataBloqueio.Text = _ctlEmpresa.DataBloqueio(_mdlEmpresa);
            if (txtDataBloqueio.Text != "")
            {
                string Data = txtDataBloqueio.Text.Substring(0, 10);
                txtDataBloqueio.Text = Data;

                DateTime dataAtu = DateTime.Now;
                DateTime dataBloq = Convert.ToDateTime(Data);

                if (dataAtu > dataBloq || dataAtu == dataBloq)
                {
                    lblBloqueio.Visible = true;
                    lblBloqueio.Text = "BLOQUEADA";
                }
                else if (dataAtu < dataBloq)
                {
                    lblBloqueio.Visible = true;
                    lblBloqueio.Text = "Data bloqueio Maior que data atual";
                }
            }
            else
            {
                lblBloqueio.Visible = false;
                //lblBloqueio.Text = " Sem Situação ";
            }
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
            txtProcurar.Text = txtProcurar.Text; //texto não formatado
            _mdlEmpresa.FiltrotxtProcurar = txtProcurar.Text;

            dgvResultado.DataSource = _ctlEmpresa.PesquisarMDL(_mdlEmpresa);

            if (dgvResultado.Rows.Count != 0)
            {
                dgvResultado.CurrentRow.Selected = false;
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Procurar();
            if(dgvResultado.Rows.Count == 0)
            {
                MessageBox.Show( "Empresa não Encontrada !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void dgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResultado.CurrentRow != null)
            {
                txtAbrirChamadoNome.Text = dgvResultado.CurrentRow.Cells["nome"].Value.ToString();
                txtAbrirChamadoID.Text = dgvResultado.CurrentRow.Cells["id"].Value.ToString();
                txtAbrirChamadoCNPJ.Text = dgvResultado.CurrentRow.Cells["CNPJ"].Value.ToString();

                ctlEmpresa _ctlEmpresa = new ctlEmpresa();
                mdlEmpresa _mdlEmpresa = new mdlEmpresa();
                _mdlEmpresa.ID = txtAbrirChamadoID.Text;

                dgvResumo.DataSource = _ctlEmpresa.PesquisaResumo(_mdlEmpresa);

                DataBloqueio();
                PintarDataGrid();
                ProcurarTelefones();
            }
        }

        void PintarDataGrid()
        {
            if (dgvResumo.Rows.Count != 0)
            {
                dgvResumo.CurrentRow.Selected = false;
            }
            foreach (DataGridViewRow row in dgvResumo.Rows)
            {
                //  if (Convert.ToInt32(row.Cells["pschvps"].Value) == 609) *por codigo

                string str;
                str = Convert.ToString(row.Cells["Dsc"].Value);
                if (str.Contains("CONTRATO") == true || str.Contains("Contrato") == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
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
                        if(txtDataBloqueio.Text != "")
                        {
                            MessageBox.Show("Empresa Bloqueda !!! ", "BLOQUEADA !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Close();
                        }
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

        void ProcurarTelefones()
        {

            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.ID = txtAbrirChamadoID.Text;

            dgvTelefones.DataSource = _ctlEmpresa.PesquisarTelefones(_mdlEmpresa);

            txtTel1.Text = dgvTelefones.CurrentRow.Cells["tel1"].Value.ToString();
            txtTel2.Text = dgvTelefones.CurrentRow.Cells["tel2"].Value.ToString();
            txtTel3.Text = dgvTelefones.CurrentRow.Cells["tel3"].Value.ToString();
            txtTel4.Text = dgvTelefones.CurrentRow.Cells["tel4"].Value.ToString();
            txtTel5.Text = dgvTelefones.CurrentRow.Cells["tel5"].Value.ToString();
        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            AbrirChamado();
        }

        private void dgvResultado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirChamado();
        }

        private void txtProcurar_KeyPress(object sender, KeyPressEventArgs e)
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

            if (txtProcurar.Text.Length >= 2)
            {
                Procurar();
            }
        }

    }
}
