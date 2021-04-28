using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using CamadaDados;
using CamadaModelos;

namespace Chamados
{
    public partial class frmListarChamado : Form
    {
        public frmListarChamado()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListarChamados();
        }

        void ListarChamados()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            dgvResultado.DataSource = _ctlEmpresa.ListarChamadoNaoAtendido(_mdlEmpresa);
            dgvSendoAtendido.DataSource = _ctlEmpresa.ListarChamadoSendoAtendido(_mdlEmpresa);
            if (dgvResultado.Rows.Count != 0)
            {
                dgvResultado.CurrentRow.Selected = false;
            }
            if (dgvSendoAtendido.Rows.Count != 0)
            {
                dgvSendoAtendido.CurrentRow.Selected = false;
            }

        }

        private void frmListarChamado_Load(object sender, EventArgs e)
        {
            ListarChamados();
        }

        void DGVClick()
        {
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            frmAtenderChamado frmAC = new frmAtenderChamado();
            frmAC.txtEmpresaID.Text = dgvResultado.CurrentRow.Cells["fk_idempresa"].FormattedValue.ToString();
            frmAC.txtCNPJ.Text = dgvResultado.CurrentRow.Cells["cnpj"].Value.ToString();
            frmAC.txtEmpresa.Text = dgvResultado.CurrentRow.Cells["Nome"].FormattedValue.ToString();
            frmAC.txtChamadoID.Text = dgvResultado.CurrentRow.Cells["chamadoId"].Value.ToString();
            frmAC.txtContato.Text = dgvResultado.CurrentRow.Cells["contato"].Value.ToString();
            frmAC.txtTelefone.Text = dgvResultado.CurrentRow.Cells["telefone"].Value.ToString();
            frmAC.cbbTecnico.Text = dgvResultado.CurrentRow.Cells["fk_idtecnico"].Value.ToString();
            frmAC.txtResumo.Text = dgvResultado.CurrentRow.Cells["resumo"].Value.ToString();
            frmAC.cbbAtendimento.Text = dgvResultado.CurrentRow.Cells["atendimento"].Value.ToString();
            frmAC.ShowDialog();
            ListarChamados();
            
        }

        private void dgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResultado.CurrentRow != null)
            {
                mdlEmpresa _mdlEmpresa = new mdlEmpresa();
                frmAtenderChamado frmAC = new frmAtenderChamado();
                frmAC.txtEmpresaID.Text = dgvResultado.CurrentRow.Cells["fk_idempresa"].FormattedValue.ToString();
                frmAC.txtCNPJ.Text = dgvResultado.CurrentRow.Cells["cnpj"].Value.ToString();
                frmAC.txtEmpresa.Text = dgvResultado.CurrentRow.Cells["Nome"].FormattedValue.ToString();
                frmAC.txtChamadoID.Text = dgvResultado.CurrentRow.Cells["chamadoId"].Value.ToString();
                frmAC.txtContato.Text = dgvResultado.CurrentRow.Cells["contato"].Value.ToString();
                frmAC.txtTelefone.Text = dgvResultado.CurrentRow.Cells["telefone"].Value.ToString();
                frmAC.cbbTecnico.Text = dgvResultado.CurrentRow.Cells["fk_idtecnico"].Value.ToString();
                frmAC.txtResumo.Text = dgvResultado.CurrentRow.Cells["resumo"].Value.ToString();
                frmAC.cbbAtendimento.Text = dgvResultado.CurrentRow.Cells["atendimento"].Value.ToString();
                frmAC.ShowDialog();
                ListarChamados();
            }
        }

        private void dgvSendoAtendido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSendoAtendido.CurrentRow != null)
            {
                mdlEmpresa _mdlEmpresa = new mdlEmpresa();
                frmAtenderChamado frmAC = new frmAtenderChamado();
                frmAC.txtEmpresaID.Text = dgvSendoAtendido.CurrentRow.Cells["fk_idempresaSA"].Value.ToString();
                frmAC.txtCNPJ.Text = dgvSendoAtendido.CurrentRow.Cells["cnpjSA"].Value.ToString();
                frmAC.txtEmpresa.Text = dgvSendoAtendido.CurrentRow.Cells["NomeSA"].FormattedValue.ToString();
                frmAC.txtChamadoID.Text = dgvSendoAtendido.CurrentRow.Cells["chamadoIdSA"].Value.ToString();
                frmAC.txtContato.Text = dgvSendoAtendido.CurrentRow.Cells["contatoSA"].Value.ToString();
                frmAC.txtTelefone.Text = dgvSendoAtendido.CurrentRow.Cells["telefoneSA"].Value.ToString();
                frmAC.cbbTecnico.Text = dgvSendoAtendido.CurrentRow.Cells["fk_idtecnicoSA"].Value.ToString();
                frmAC.txtResumo.Text = dgvSendoAtendido.CurrentRow.Cells["resumoSA"].Value.ToString();
                frmAC.cbbAtendimento.Text = dgvSendoAtendido.CurrentRow.Cells["atendimentoSA"].Value.ToString();
                frmAC.ShowDialog();
                ListarChamados();

            }
        }
    }
}
