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

        private void txtProcurarEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtProcurarEmpresa.Text.Length >= 2)
            {
                EmpresaProcurar();
            }
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
    }
}
