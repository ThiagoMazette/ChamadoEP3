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
    public partial class frmListagemDetalhes : Form
    {
        public frmListagemDetalhes()
        {
            InitializeComponent();
        }

        private void FrmListagemDetalhes_Load(object sender, EventArgs e)
        {
            var HI = Convert.ToDateTime(txtInicio.Text);
            var HF = Convert.ToDateTime(txtFim.Text);
            var TXTTempo = HF - HI;
            txtTempo.Text = TXTTempo.ToString();
        }

        void ONReadOnly()
        {
            btnOK.Visible = false;
            txtTecnico.ReadOnly     = true;
            txtInicio.ReadOnly      = true;
            txtFim.ReadOnly         = true;
            txtAtendimento.ReadOnly = true;
            txtEmpresa.ReadOnly     = true;
            txtCNPJ.ReadOnly        = true;
            txtContato.ReadOnly     = true;
            txtTelefone.ReadOnly    = true;
            txtResumo.ReadOnly      = true;
        }

        void OFFReadOnly()
        {
            btnOK.Visible = true;
            txtTecnico.ReadOnly     = false;
            txtInicio.ReadOnly      = false;
            txtFim.ReadOnly         = false;
            txtAtendimento.ReadOnly = false;
            txtEmpresa.ReadOnly     = false;
            txtCNPJ.ReadOnly        = false;
            txtContato.ReadOnly     = false;
            txtTelefone.ReadOnly    = false;
            txtResumo.ReadOnly      = false;
        }

        private void TxtAtendimento_DoubleClick(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                OFFReadOnly();
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            ONReadOnly();
        }
    }
}
