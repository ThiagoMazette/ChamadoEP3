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
            ListarChamado();
        }

        void ListarChamado()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            dgvResultado.DataSource = _ctlEmpresa.ListarChamado(_mdlEmpresa);

        }

        private void frmListarChamado_Load(object sender, EventArgs e)
        {
            ListarChamado();
        }

        private void dgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResultado.CurrentRow != null)
            {
                mdlEmpresa _mdlEmpresa = new mdlEmpresa();
                frmAtenderChamado frmAC = new frmAtenderChamado();
                frmAC.txtEmpresaID.Text = dgvResultado.CurrentRow.Cells[5].FormattedValue.ToString();
                frmAC.txtEmpresa.Text = dgvResultado.CurrentRow.Cells[6].FormattedValue.ToString();
                frmAC.txtChamadoID.Text = dgvResultado.CurrentRow.Cells["chamadoId"].Value.ToString();

                frmAC.ShowDialog();
                ListarChamado();
            }
        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void dgvResultado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
