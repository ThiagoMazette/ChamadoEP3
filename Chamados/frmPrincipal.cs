using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chamados
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadastro _frmCadastro = new frmCadastro();
            _frmCadastro.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAbrirChamado _frmAbrirChamado = new frmAbrirChamado();
            _frmAbrirChamado.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListarChamado _frmAtenderChamado = new frmListarChamado();
            _frmAtenderChamado.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListagem _frmListagem = new frmListagem();
            _frmListagem.ShowDialog();
        }
    }
}
