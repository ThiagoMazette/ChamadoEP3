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
            if (txtFim.Text != "")
            {
                var HI = Convert.ToDateTime(txtInicio.Text);
                var HF = Convert.ToDateTime(txtFim.Text);
                var TXTTempo = HF - HI;
                txtTempo.Text = TXTTempo.ToString();
            }
        }

        void ONReadOnly()
        {
            btnOK.Visible = false;
            txtTecnico.ReadOnly     = true;
            txtInicio.ReadOnly      = true;
            txtFim.ReadOnly         = true;
            txtAtendimento.ReadOnly = true;
          //  txtEmpresa.ReadOnly     = true;
         //   txtCNPJ.ReadOnly        = true;
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
         //   txtEmpresa.ReadOnly     = false;
         //   txtCNPJ.ReadOnly        = false;
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

        void ArrumarChamadoOK()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();

            _mdlEmpresa.Telefone = txtTelefone.Text;
            _mdlEmpresa.cbbTecnico = txtTecnico.Text;
            //_mdlEmpresa.cbbTecnico = cbbTecnico.SelectedValue.ToString(); <-- usar qdo popular
            _mdlEmpresa.Contato = txtContato.Text;
            _mdlEmpresa.Resumo = txtResumo.Text;
            _mdlEmpresa.ID = txtChamadoID.Text; 
            _mdlEmpresa.Atendimento = txtAtendimento.Text;
            _mdlEmpresa.Inicial = txtInicio.Text;
            _mdlEmpresa.Final = txtFim.Text;

            bool retorno1 = _ctlEmpresa.ArrumarChamado(_mdlEmpresa);
            if (retorno1)
            {
                MessageBox.Show("Chamado atualizado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao fechar chamado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            ArrumarChamadoOK();
            ONReadOnly();
        }
    }
}
