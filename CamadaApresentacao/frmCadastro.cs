using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using CamadaModelos;
using CamadaDados;

namespace Chamados
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnTecnicoSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmpresaSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        void EmpresaLimpar()
        {
            txtEmpresaCNPJ.Text = "";
            txtEmpresaNome.Text = "";
            txtEmpresaTelefone.Text = "";
        }
        private void btnEmpresaLimpar_Click(object sender, EventArgs e)
        {
            EmpresaLimpar();
        }

        void TecnicoLimpar()
        {
            txtTecnicoNome.Text = "";
            txtTecnicoRamal.Text = "";
        }
        private void btnTecnicoLimpar_Click(object sender, EventArgs e)
        {
            TecnicoLimpar();
        }

        private void btnEmpresaCasdastrar_Click(object sender, EventArgs e)
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.CNPJ = txtEmpresaCNPJ.Text;
            _mdlEmpresa.Nome = txtEmpresaNome.Text;
            _mdlEmpresa.Telefone = txtEmpresaTelefone.Text;
            
            
            bool retorno1 = _ctlEmpresa.CadastrarEmpresaMDL(_mdlEmpresa);
            //  bool retorno = _ctlPessoa.InserirPessoa(txtNome.Text, mskRG.Text, mskCPF.Text);
            if (retorno1)
            {
                MessageBox.Show("Dados gravados com sucesso");
                //limpar();
            }
            else
            {
                MessageBox.Show("Erro ao Gravar");
            }


        }
    }
}
