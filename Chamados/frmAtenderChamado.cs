using CamadaDados;
using CamadaModelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chamados
{

    public partial class frmAtenderChamado : Form
    {
        public frmAtenderChamado()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
     //   public static string txtEmpresaString;

        void DataBloqueio()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.txtAbrirChamadoID = txtEmpresaID.Text;

            txtDataBloqueio.Text = _ctlEmpresa.DataBloqueio(_mdlEmpresa);
            if (txtDataBloqueio.Text != "")
            {
                string Data = txtDataBloqueio.Text.Substring(0, 10);
                txtDataBloqueio.Text = Data;

                DateTime dataAtu = DateTime.Now;
                DateTime dataBloq = Convert.ToDateTime(Data);

                if (dataAtu > dataBloq || dataAtu == dataBloq)
                {
                    //  lblDataBloqueio.Visible = true;
                    lblBloqueio.Visible = true;
                    //  txtDataBloqueio.Visible = true;
                    lblBloqueio.Text = "BLOQUEADA !";
                }
                else if (dataAtu < dataBloq)
                {
                    //  lblDataBloqueio.Visible = true;
                    lblBloqueio.Visible = true;
                    //  txtDataBloqueio.Visible = true;
                    lblBloqueio.Text = "Data bloqueio Maior que data atual";
                }
            }
            else
            {
                //   lblDataBloqueio.Visible = false;
                lblBloqueio.Visible = false;
                //  txtDataBloqueio.Visible = false;
                //lblBloqueio.Text = " Sem Situação ";
            }
        }

        void DGVDsc()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.ID = txtEmpresaID.Text;
            dgvDsc.DataSource = _ctlEmpresa.PesquisaResumo(_mdlEmpresa);

            if (dgvDsc.Rows.Count != 0)
            {
                dgvDsc.CurrentRow.Selected = false;
            }
            foreach (DataGridViewRow row in dgvDsc.Rows)
            {
                //  if (Convert.ToInt32(row.Cells["pschvps"].Value) == 609) *por codigo

                string str;
                str = Convert.ToString(row.Cells["Dsc"].Value);
                if (str.Contains("CONTRATO") == true || str.Contains("Contrato") == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            } 
        }

        private void frmAtenderChamado_Load(object sender, EventArgs e)
        {
            DataBloqueio();
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.txtEmpresaID = txtEmpresaID.Text;
            _mdlEmpresa.txtID = txtChamadoID.Text;
            dgvOutrosAtendimentos.DataSource = _ctlEmpresa.CarregarOutrosChamados(_mdlEmpresa);
            dgvOutrosAtendimentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVDsc();
            if (dgvOutrosAtendimentos.Rows.Count != 0)
            {
                dgvOutrosAtendimentos.CurrentRow.Selected = false;
            }


            // dgvOutrosAtendimentos.;

            /*mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            txtEmpresa.Text = _mdlEmpresa.txtEmpresa; */

            /*
            frmAtenderChamado frmAC = new frmAtenderChamado();
            frmAC.MdiParent = this.MdiParent;
            frmAC.txtEmpresa.Text = dgvOutrosAtendimentos.CurrentRow.Cells[1].FormattedValue.ToString();
            frmAC.ShowDialog(); */
            /*
            FormEditarCliente fed = new FormEditarCliente();
            fed.MdiParent = this.MdiParent;
            fed.txtnumcli.Text = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();
            fed.txtnome.Text = dataGridView1.CurrentRow.Cells[2].FormattedValue.ToString();
            fed.txtnif.Text = dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString();
            fed.txtemail.Text = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
            fed.txtend.Text = dataGridView1.CurrentRow.Cells[5].FormattedValue.ToString();
            fed.txtende2.Text = dataGridView1.CurrentRow.Cells[6].FormattedValue.ToString();
            fed.txtcp.Text = dataGridView1.CurrentRow.Cells[7].FormattedValue.ToString();
            fed.txtpais.Text = dataGridView1.CurrentRow.Cells[8].FormattedValue.ToString();
            fed.Show();
            */
        }
               
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (cbbTecnico.Text == "")
            {
                MessageBox.Show(" Selecionar o Técnico !! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbbTecnico.DroppedDown = true;
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show(" Telefone não pode ficar em branco !! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefone.Focus();
            }
            else if (txtContato.Text == "")
            {
                MessageBox.Show(" Contato não pode ficar em branco !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContato.Focus();
            }
            else if (cbbAtendimento.Text == "")
            {
                MessageBox.Show(" Selecione o tipo de Atendimento ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbbAtendimento.DroppedDown = true;
            }
            else if(txtResumo.Text=="")
            {
                MessageBox.Show(" Campo Descrição não pode ficar em branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtResumo.Focus();
            }
            else if(txtResumo.Text.Length < 6)
            {
                MessageBox.Show(" De mais detalhes sobre o atendimento ... ", "Preguiçoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                ctlEmpresa _ctlEmpresa = new ctlEmpresa();
                mdlEmpresa _mdlEmpresa = new mdlEmpresa();

                _mdlEmpresa.Telefone = txtTelefone.Text;
                _mdlEmpresa.cbbTecnico = cbbTecnico.Text;
                //_mdlEmpresa.cbbTecnico = cbbTecnico.SelectedValue.ToString(); <-- usar qdo popular
                _mdlEmpresa.Contato = txtContato.Text;
                _mdlEmpresa.Resumo = txtResumo.Text;
                _mdlEmpresa.ID = txtChamadoID.Text;
                _mdlEmpresa.Atendimento = cbbAtendimento.Text;

                bool retorno1 = _ctlEmpresa.FinalizarChamado(_mdlEmpresa);
                if (retorno1)
                {
                    MessageBox.Show("Chamado fechado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao fechar chamado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.TextLength == 11 || txtTelefone.TextLength == 15)
            {
                txtTelefone.Mask = "(00) 00000-0000";
            }
            else if(txtTelefone.TextLength == 10)
            {
                txtTelefone.Mask = "(00) 0000-0000";
            }
            else if(txtTelefone.TextLength == 8 || txtTelefone.TextLength == 9)
            {
                MessageBox.Show(" Digite o telefone com DDD sem ´(  )´", "Alou", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtTelefone.Focus();
            }
            else if(txtTelefone.TextLength > 1 && txtTelefone.TextLength < 8)
            {
                MessageBox.Show(" Falta numero !!! ", "Olhe direito", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtTelefone.Focus();
            }
            else if(txtTelefone.TextLength > 11)
            {
                MessageBox.Show(" Telefone tem numeros a mais ", "Olhe direito", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            string valorSemMascara = "";
            valorSemMascara= txtTelefone.Text;
            valorSemMascara = valorSemMascara.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ","");
            txtTelefone.Text = "";
            txtTelefone.Mask = "";
            txtTelefone.Text = valorSemMascara;
          //  txtTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            //txtTelefone.Mask = "";
           // var tirarmask = txtTelefone.Text;
           // txtTelefone.Text = "";
           // txtTelefone.Mask = "";
           // txtTelefone.Text = tirarmask;
        }

        void FinalizarChamadoOK()
        {
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();

            _mdlEmpresa.Telefone = txtTelefone.Text;
            _mdlEmpresa.cbbTecnico = cbbTecnico.Text;
            //_mdlEmpresa.cbbTecnico = cbbTecnico.SelectedValue.ToString(); <-- usar qdo popular
            _mdlEmpresa.Contato = txtContato.Text;
            _mdlEmpresa.Resumo = txtResumo.Text;
            _mdlEmpresa.ID = txtChamadoID.Text;
            _mdlEmpresa.Atendimento = cbbAtendimento.Text;

            bool retorno1 = _ctlEmpresa.FinalizarChamado(_mdlEmpresa);
            if (retorno1)
            {
                MessageBox.Show("Chamado fechado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao fechar chamado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            if (cbbTecnico.Text == "")
            {
                MessageBox.Show(" Selecionar o Técnico !! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbbTecnico.DroppedDown = true;
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show(" Telefone não pode ficar em branco !! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefone.Focus();
            }
            else if (txtContato.Text == "")
            {
                MessageBox.Show(" Contato não pode ficar em branco !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContato.Focus();
            }
            else if (cbbAtendimento.Text == "")
            {
                MessageBox.Show(" Selecione o tipo de Atendimento ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbbAtendimento.DroppedDown = true;
            }
            else if (txtResumo.Text == "")
            {
                MessageBox.Show(" Campo Descrição não pode ficar em branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtResumo.Focus();
            }
            else if (txtResumo.Text.Length < 6)
            {
                MessageBox.Show(" De mais detalhes sobre o atendimento ... ", "Preguiçoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                if (txtDataBloqueio.Text != "" && cbbAtendimento.Text == "Contrato")
                {
                    DialogResult dialogResult = MessageBox.Show("Empresa Bloqueada e Selecionado como CONTRATO, \n deseja continuar ?", "OPA !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.Yes)
                    {
                        FinalizarChamadoOK();
                    }
                }
                else
                {
                    FinalizarChamadoOK();
                }

                /*else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }*/
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (cbbTecnico.Text == "")
            {
                MessageBox.Show(" Selecionar o Técnico !! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbbTecnico.DroppedDown = true;
            }
           
            else
            {
                ctlEmpresa _ctlEmpresa = new ctlEmpresa();
                mdlEmpresa _mdlEmpresa = new mdlEmpresa();

                _mdlEmpresa.Telefone = txtTelefone.Text;
                _mdlEmpresa.cbbTecnico = cbbTecnico.Text;
                //_mdlEmpresa.cbbTecnico = cbbTecnico.SelectedValue.ToString(); <-- usar qdo popular
                _mdlEmpresa.Contato = txtContato.Text;
                _mdlEmpresa.Resumo = txtResumo.Text;
                _mdlEmpresa.ID = txtChamadoID.Text;
                _mdlEmpresa.Atendimento = cbbAtendimento.Text;

                bool retorno1 = _ctlEmpresa.SalvarChamado(_mdlEmpresa);
                if (retorno1)
                {
                    MessageBox.Show("Chamado salvo com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar chamado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
