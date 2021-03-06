﻿using System;
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
            txtProcurar.Select();
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

            lblTotalContagem.Text = Convert.ToString(dgvResultado.Rows.Count);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Procurar();
            if (dgvResultado.Rows.Count == 0)
            {
                MessageBox.Show("Empresa não Encontrada !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (str.Contains("CONTRATO") == true || str.Contains("Contrato") == true || str.Contains("contrato") == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                if (str.Contains("RELOGIO") == true ||
                    str.Contains("Relogio") == true ||
                    str.Contains("relogio") == true ||
                    str.Contains("Relógio") == true ||
                    str.Contains("RELÓGIO") == true ||
                    str.Contains("KURUMIM") == true ||
                    str.Contains("INNER") == true ||
                    str.Contains("GUILHOTINA") == true ||
                    str.Contains("PLUS")
                    )
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
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
                return;
            }
            if (txtDataBloqueio.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Empresa Bloqueada, Favor consultar o MARCELO(R.225), \n deseja abrir o chamado mesmo assim ?", "OPA !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            if (txtDataInativo.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Empresa Inativa, Provavelmente NÂO tem contrato !!! \n deseja abrir o chamado mesmo assim ?", "SEM CONTRATO !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            mdlEmpresa _mdlEmpresaDup = new mdlEmpresa();
            string CNPJ = txtAbrirChamadoCNPJ.Text;
            _mdlEmpresaDup.CNPJ = CNPJ;
            bool duplicado = ctlEmpresa.VerificarDuplicidade(CNPJ);
            if (duplicado)
            {
                _mdlEmpresa.ID = dgvResultado.CurrentRow.Cells["id"].Value.ToString();
                _mdlEmpresa.CNPJ = dgvResultado.CurrentRow.Cells["CNPJ"].Value.ToString();
                _mdlEmpresa.Nome = dgvResultado.CurrentRow.Cells["Nome"].Value.ToString();

                bool retornoComp = _ctlEmpresa.AbrirSoChamado(_mdlEmpresa);
                if (retornoComp)
                {
                    //if(txtDataBloqueio.Text != "")
                    //{
                    //    MessageBox.Show("Empresa Bloqueda !!! ", "BLOQUEADA !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    Close();
                    //}
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

        void ProcurarTelefones()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.ID = txtAbrirChamadoID.Text;

            dgvTelefones.DataSource = _ctlEmpresa.PesquisarTelefones(_mdlEmpresa);

            if (dgvTelefones.Rows.Count > 0)
            {
                txtTel1.Text = dgvTelefones.CurrentRow.Cells["tel1"].Value.ToString();
                txtTel2.Text = dgvTelefones.CurrentRow.Cells["tel2"].Value.ToString();
                txtTel3.Text = dgvTelefones.CurrentRow.Cells["tel3"].Value.ToString();
                txtTel4.Text = dgvTelefones.CurrentRow.Cells["tel4"].Value.ToString();
                txtTel5.Text = dgvTelefones.CurrentRow.Cells["tel5"].Value.ToString();
            }
        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            AbrirChamado();
        }

        private void TxtProcurar_KeyUp(object sender, KeyEventArgs e)
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

        void ListarDescricao()
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
                ListarFollowIndividual(); // esse funciona
                dgvFollowUP.DataSource = _ctlEmpresa.PesquisaFollowUP(_mdlEmpresa);
                // ListarFollowTodos();

                if (dgvFollowUP.Rows.Count != 0)
                {
                    //          dgvFollowUP.CurrentRow.Selected = false;
                }

                DataBloqueio();
                DataInativa();
                PintarDataGrid();
                ProcurarTelefones();
                txtVendedor.Text = "";

            }
        }

        void ProcurarVendedor()
        {
           
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();

            _mdlEmpresa.VendedorvndBchvvnda = dgvResumo.CurrentRow.Cells["vndBchvvnda"].Value.ToString();//pegar o id do pedido

            txtVendedor.Text = _ctlEmpresa.PesquisarVendedor(_mdlEmpresa);
            //tirado 14/05/21
            //if (dgvFollowUP.Rows.Count != 0)
            //{
            //    dgvFollowUP.CurrentRow.Selected = false;
            //}



        }

        void DataInativa()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.txtAbrirChamadoID = txtAbrirChamadoID.Text;

            txtDataInativo.Text = _ctlEmpresa.DataInativo(_mdlEmpresa);
            if (txtDataInativo.Text != "")
            {
                string Data = txtDataInativo.Text.Substring(0, 10);
                txtDataInativo.Text = Data;

                DateTime dataAtu = DateTime.Now;
                DateTime dataBloq = Convert.ToDateTime(Data);

                if (dataAtu > dataBloq || dataAtu == dataBloq)
                {
                    lblInativa.Visible = true;
                    lblInativa.Text = "INATIVA";
                }
                else if (dataAtu < dataBloq)
                {
                    lblInativa.Visible = true;
                    lblInativa.Text = "Data Inativa Maior que data atual";
                }
            }
            else
            {
                lblInativa.Visible = false;
            }
        }

        private void DgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ListarDescricao();
        }

        private void DgvResultado_KeyUp(object sender, KeyEventArgs e)
        {
            ListarDescricao();
        }

        void ListarFollowIndividual()
        {
            if (dgvResumo.CurrentRow != null)
            {
                ctlEmpresa _ctlEmpresa = new ctlEmpresa();
                mdlEmpresa _mdlEmpresa = new mdlEmpresa();

                _mdlEmpresa.chvvnda = dgvResumo.CurrentRow.Cells["vndBchvvnda"].Value.ToString();


                dgvFollowUP.DataSource = _ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa);
                //nao add linha, add em branco dgvFollowUP.Rows.Add (_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa));
                if (dgvFollowUP.Rows.Count != 0)
                {
                    dgvFollowUP.CurrentRow.Selected = false;
                }
            }
        }

        /* void ListarFollowTodos()
         {
             ctlEmpresa _ctlEmpresa = new ctlEmpresa();
             mdlEmpresa _mdlEmpresa = new mdlEmpresa();

             //       string [] okk = new string [dgvResumo.Rows.Count];
             string[] okk = new string[20];

             int i = 0;

             foreach (DataGridViewRow row in dgvResumo.Rows)
             {
                 //  okk[i] = row.Cells["vndBchvvnda"].Value != null ? row.Cells["vndBchvvnda"].Value.ToString() : string.Empty;
                 okk[i] = row.Cells["vndBchvvnda"].Value.ToString();
                 _mdlEmpresa.chvvnda = okk[i];
                 dgvFollowUP.Rows.Add((_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa)));

                 //  vndBchvvnda.Add(row.Cells[i].Value);
                 i++;
             }
   

         }  */ // nao vai :(

        /*   void ListarFollowTodos() // teste esse
           {
               ctlEmpresa _ctlEmpresa = new ctlEmpresa();
               mdlEmpresa _mdlEmpresa = new mdlEmpresa();

               //       string [] okk = new string [dgvResumo.Rows.Count];
               string[] okk = new string[20];

               int i = 0;

               foreach (DataGridViewRow row in dgvResumo.Rows)
               {
                   //  okk[i] = row.Cells["vndBchvvnda"].Value != null ? row.Cells["vndBchvvnda"].Value.ToString() : string.Empty;
                   okk[i] = row.Cells["vndBchvvnda"].Value.ToString();
                   // _mdlEmpresa.chvvnda = okk[i];
           //       textBox1.Text = okk[0];

                   dgvFollowUP2.Rows.Add((_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa)));

                   //  vndBchvvnda.Add(row.Cells[i].Value);
                   i++;
               }
               textBox1.Text = okk[0];
               textBox2.Text = okk[1];
               textBox3.Text = okk[2];
               textBox4.Text = okk[3];
               textBox5.Text = okk[4];
               dgvFollowUP2.Columns.Add("chvvnda", "chvvnda");
               _mdlEmpresa.chvvnda = textBox1.Text;
               dgvFollowUP2.Rows.Add((_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa)));
               //dgvFollowUP.DataSource = (_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa));

               _mdlEmpresa.chvvnda = textBox2.Text;
               dgvFollowUP2.Rows.Add((_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa)));
               //dgvFollowUP.DataSource = (_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa));

               _mdlEmpresa.chvvnda = textBox3.Text;
               dgvFollowUP2.Rows.Add((_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa)));
               //dgvFollowUP.DataSource = (_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa));

               _mdlEmpresa.chvvnda = textBox4.Text;
               dgvFollowUP2.Rows.Add((_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa)));
               //dgvFollowUP.DataSource = (_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa));


           }  */  // nao vai :(  teste ok

        /*     void ListarFollowTodos()
             {
                 ctlEmpresa _ctlEmpresa = new ctlEmpresa();
                 mdlEmpresa _mdlEmpresa = new mdlEmpresa();

                 //       string [] okk = new string [dgvResumo.Rows.Count];
                 //  string[] okk = new string[20];
                 List<Cliente> okk = (List<Clientes>)dgvFollowUP.DataSource;
                 int i = 0;

                 foreach (DataGridViewRow row in dgvResumo.Rows)
                 {
                     //  okk[i] = row.Cells["vndBchvvnda"].Value != null ? row.Cells["vndBchvvnda"].Value.ToString() : string.Empty;
                     okk[i] = row.Cells["vndBchvvnda"].Value.ToString();
                     _mdlEmpresa.chvvnda = okk[i];
                  //   dgvFollowUP.Rows.Add((_ctlEmpresa.PesquisaFollowUPIndividual(_mdlEmpresa)));

                     //  vndBchvvnda.Add(row.Cells[i].Value);
                     i++;
                 }



                 /* List<Clientes> dadosGrid = (List<Clientes>)dgvClientes.DataSource
                      dadosGrid.Add(new Cliente() { id = 1, Nome = "Fulano de tal" });
                      //e pode até repassar os dados para o grid, limpando antes:

                      dgvClientes.DataSource = null;
                      dgvClientes.DataSource = dadosGrid;
                      //a linha acima, preenche o datagridview, com todos os ítens que já estavam nele antes, da forma que estavam e com um cliente novo adicionado.
                      */

        //   }   // nao vai :(

        private void DgvResumo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ListarFollowIndividual();
            ProcurarVendedor();
        }

        private void DgvResumo_KeyUp(object sender, KeyEventArgs e)
        {
            ListarFollowIndividual();
            ProcurarVendedor();
        }

        void MostrarContadores()
        {
            lblTotal.Visible = true;
            lblTotalContagem.Visible = true;
        }

        private void txtProcurar_DoubleClick(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                MostrarContadores();
            }
        }

        private void txtProcurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Procurar();
                if (dgvResultado.Rows.Count == 0)
                {
                    MessageBox.Show("Empresa não Encontrada !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



    }
}
