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

namespace Chamados
{
    public partial class frmListagem : Form
    {
        public frmListagem()
        {
            InitializeComponent();
        }

        void ListarChamado()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.CNPJ = txtEmpresaSelecionada.Text;
            _mdlEmpresa.cbbTecnico = cbbTecnico.Text;
            dgvListarResultado.DataSource = _ctlEmpresa.ListarChamado(_mdlEmpresa);

        }

        void EmpresaProcurar()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.FiltroAbrirChamado = cbbEmpresa.Text;
            _mdlEmpresa.FiltrotxtProcurar = txtProcurarEmpresa.Text;
            dgvProcurarEmpresa.DataSource = _ctlEmpresa.PesquisarMDL(_mdlEmpresa);
        }
        private void btnProcurarEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaProcurar();
        }

        private void btnListarResultado_Click(object sender, EventArgs e)
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();


            _mdlEmpresa.FiltrotxtProcurar = txtEmpresaID.Text;
            _mdlEmpresa.cbbTecnico = cbbTecnico.Text;
            dgvListarResultado.DataSource = _ctlEmpresa.ListagemResultado(_mdlEmpresa);
        }

        private void frmListagem_Load(object sender, EventArgs e)
        {
            cbbEmpresa.SelectedIndex = 1;
            cbbTecnico.SelectedIndex = 4;
            txtProcurarEmpresa.Focus();
        }

        private void cbbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvProcurarEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvProcurarEmpresa.CurrentRow != null)
            {
                txtEmpresaID.Text = dgvProcurarEmpresa.CurrentRow.Cells["id"].Value.ToString();
                txtEmpresaSelecionada.Text = dgvProcurarEmpresa.CurrentRow.Cells["nome"].Value.ToString();
            }
        }

        private void dgvProcurarEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimparEmpresa_Click(object sender, EventArgs e)
        {
            txtEmpresaSelecionada.Text = "";
            txtEmpresaID.Text = "";
            txtProcurarEmpresa.Text = "";
        }
    }
}
