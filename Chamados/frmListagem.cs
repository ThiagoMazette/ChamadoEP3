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
using DGVPrinterHelper;
using ImprimirDataGridView;

using System.Data.OleDb;


namespace Chamados
{
    public partial class frmListagem : Form
    {
        public frmListagem()
        {
            InitializeComponent();
        }

        //void ListarChamado()
        //{
        //    ctlEmpresa _ctlEmpresa = new ctlEmpresa();
        //    mdlEmpresa _mdlEmpresa = new mdlEmpresa();
        //    _mdlEmpresa.CNPJ = txtEmpresaSelecionada.Text;
        //    _mdlEmpresa.cbbTecnico = cbbTecnico.Text;
        //    dgvListarResultado.DataSource = _ctlEmpresa.ListarChamado(_mdlEmpresa);
        //}

        void EmpresaProcurar()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.FiltroAbrirChamado = cbbEmpresa.Text;
            _mdlEmpresa.FiltrotxtProcurar = txtProcurarEmpresa.Text;
            dgvProcurarEmpresa.DataSource = _ctlEmpresa.PesquisarMDL(_mdlEmpresa);
            lblTotalContagemEmpresa.Text = Convert.ToString(dgvProcurarEmpresa.RowCount);
        }

        private void btnProcurarEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaProcurar();
            if (dgvProcurarEmpresa.Rows.Count == 0)
            {
                MessageBox.Show("Empresa não Encontrada !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void ListarResultado()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();

            _mdlEmpresa.FiltrotxtProcurar = txtEmpresaID.Text;
            _mdlEmpresa.cbbTecnico = cbbTecnico.Text;
            dgvListarResultado.DataSource = _ctlEmpresa.ListagemResultado(_mdlEmpresa);
            if (dgvListarResultado.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum resultado encontrado !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            lblTotalContagemResumo.Text = Convert.ToString(dgvListarResultado.Rows.Count);
        }

        private void btnListarResultado_Click(object sender, EventArgs e)
        {
            ListarResultado();
        }

        private void frmListagem_Load(object sender, EventArgs e)
        {
            cbbEmpresa.SelectedIndex = 1;
            cbbTecnico.SelectedItem = "Todos";
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

        private void txtProcurarEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        /*    comeca aki    imprimir em um form feito com cristal report
            private void Button1_Click(object sender, EventArgs e)
            {
                var dataSet = new DataSetRelatorio();
                foreach (DataGridViewRow linha in dgvListarResultado.Rows)
                {
                    if (!linha.IsNewRow)
                    {
                        var novaLinhaDataSet = dataSet.Funcionario.NewFuncionarioRow();
                       //*     if (linha.Cells["Nome"].Value != null)
                            novaLinhaDataSet.Nome = linha.Cells["Nome"].Value.ToString();
                        if (linha.Cells["Sobrenome"].Value != null)
                            novaLinhaDataSet.Sobrenome = linha.Cells["Sobrenome"].Value.ToString();
    //* //
                        dataSet.Funcionario.AddFuncionarioRow(novaLinhaDataSet);
                    }
                }

                var formRelatorio = new FormRelatorio(dataSet);
                formRelatorio.Show();
            }
        acaba aki   */

        private void Button3_Click(object sender, EventArgs e)
        {
            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.Print();

        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            dgvListarResultado.ScrollBars = ScrollBars.None;
            printDocument.DefaultPageSettings.Landscape = true;
            Bitmap bm = new Bitmap(dgvListarResultado.Width, dgvListarResultado.Height);
            dgvListarResultado.DrawToBitmap(bm, new Rectangle(0, 0, dgvListarResultado.Width, dgvListarResultado.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            dgvListarResultado.ScrollBars = ScrollBars.Both ;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvListarResultado.RowCount >0)
            {
                DGVPrinter printer = new DGVPrinter();
                printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(dgvListarResultado);
            }
            else
            {
                MessageBox.Show("Nada para Imprimir!!", "Nenhuma Empresa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DgvListarResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          //  if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
          //  {
                if (dgvListarResultado.CurrentRow != null)
                {
                    mdlEmpresa _mdlEmpresa = new mdlEmpresa();
                    frmListagemDetalhes frmLD = new frmListagemDetalhes();

                    frmLD.txtTecnico.Text = dgvListarResultado.CurrentRow.Cells["fk_idtecnico"].Value.ToString();
                    frmLD.txtInicio.Text = dgvListarResultado.CurrentRow.Cells["data"].Value.ToString();
                    frmLD.txtFim.Text = dgvListarResultado.CurrentRow.Cells["dataFinal"].Value.ToString();
                    frmLD.txtAtendimento.Text = dgvListarResultado.CurrentRow.Cells["atendimento"].Value.ToString();
                    frmLD.txtEmpresa.Text = dgvListarResultado.CurrentRow.Cells["nomeE"].Value.ToString();
                    frmLD.txtCNPJ.Text = dgvListarResultado.CurrentRow.Cells["cnpjcpf"].Value.ToString();
                    frmLD.txtContato.Text = dgvListarResultado.CurrentRow.Cells["contato"].Value.ToString();
                    frmLD.txtTelefone.Text = dgvListarResultado.CurrentRow.Cells["telefone1"].Value.ToString();
                    frmLD.txtResumo.Text = dgvListarResultado.CurrentRow.Cells["resumo"].Value.ToString();
                    frmLD.txtChamadoID.Text = dgvListarResultado.CurrentRow.Cells["id1"].Value.ToString();
                    frmLD.ShowDialog();
                    ListarResultado();
                }
            //}
        }

        private void txtProcurarEmpresa_KeyPress(object sender, KeyEventArgs e)
        {
            if (txtProcurarEmpresa.Text.Length >= 2)
            {
                EmpresaProcurar();
            }
        }

        void MostrarContadores()
        {
            lblTotalContagemEmpresa.Visible = true;
            lblTotalContagemResumo.Visible = true;
            lblTotalEmpresa.Visible = true;
            lblTotalResumo.Visible = true;
        }

        private void txtProcurarEmpresa_DoubleClick(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                MostrarContadores();
            }
        }
    }
}
