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

      /*  void EmpresaCadastro()  nao usar - empresario
        {
            mdlEmpresa _mdlEmpresaDup = new mdlEmpresa();
            string CNPJ = txtEmpresaCNPJ.Text;
            _mdlEmpresaDup.CNPJ= CNPJ;
            bool duplicado = ctlEmpresa.VerificarDuplicidade(CNPJ);
            if (duplicado)
            {
                MessageBox.Show(" Essa Empresa já está cadastrada ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                return;
            }

            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.CNPJ = txtEmpresaCNPJ.Text;
            _mdlEmpresa.Nome = txtEmpresaNome.Text;
            _mdlEmpresa.Telefone = txtEmpresaTelefone.Text;

            bool retorno1 = _ctlEmpresa.CadastrarEmpresaMDL(_mdlEmpresa);
            if (retorno1)
            {
                MessageBox.Show("Dados gravados com sucesso");
                EmpresaLimpar();
            }
            else
            {
                MessageBox.Show("Erro ao Gravar");
            }
        } */

        void TecnicoCadastro()
        {

            mdlTecnico _mdlTecnicoDup = new mdlTecnico();
            string Nome = txtTecnicoNome.Text;
            _mdlTecnicoDup.Nome = Nome;
            bool duplicado = ctlTecnico.VerificarDuplicidade(Nome);
            if (duplicado)
            {
                MessageBox.Show(" Esse Técnico já está cadastrado ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ctlTecnico _ctlTecnico = new ctlTecnico();
            mdlTecnico _mdlTecnico = new mdlTecnico();
            _mdlTecnico.Nome = txtTecnicoNome.Text;
            _mdlTecnico.Ramal = txtTecnicoRamal.Text;
            
            bool retorno1 = _ctlTecnico.CadastrarTecnicoMDL(_mdlTecnico);
            if (retorno1)
            {
                MessageBox.Show("Dados gravados com sucesso");
                TecnicoLimpar();
            }
            else
            {
                MessageBox.Show("Erro ao Gravar");
            }
        }


        private void btnEmpresaCasdastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTecnicoCadastrar_Click(object sender, EventArgs e)
        {
            TecnicoCadastro();
        }
    }
}
