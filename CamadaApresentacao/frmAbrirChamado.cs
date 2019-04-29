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
            cbbSelecao.SelectedIndex = 0;
        }
    }
}
