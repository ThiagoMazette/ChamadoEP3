using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CamadaDados;

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
         //   ctlEmpresa _ctlEmpresa = new ctlEmpresa();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListarChamado _frmAtenderChamado = new frmListarChamado();
            _frmAtenderChamado.ShowDialog();
        }

        void Atualizar()
        {
            string fileName = "EP3.MDB";
            string sourcePath = @"\\REP_SERVER\publica\Dropbox\EMPRESARIO3\Dados";
            string targetPath = @"\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            System.IO.File.Copy(sourceFile, destFile, true);
            if (System.IO.Directory.Exists(sourcePath))
            { 
                destFile = System.IO.Path.Combine(targetPath, fileName);
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            else
            {
               MessageBox.Show(" Caminho do banco atualizado não encontrado !!! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void Comparar()
        {
            string fileName = "EP3.MDB";
            string sourcePath = @"\\REP_SERVER\publica\Dropbox\EMPRESARIO3\Dados";
            string targetPath = @"\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\temp";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            System.IO.File.Copy(sourceFile, destFile, true);
            if (System.IO.Directory.Exists(sourcePath))
            {
                destFile = System.IO.Path.Combine(targetPath, fileName);
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            else
            {
                MessageBox.Show(" Caminho do banco atualizado não encontrado !!! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            byte[] ByteArray1 = null;
            byte[] ByteArray2 = null;
            string File1 = @"\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\temp\EP3.MDB";
            string File2 = @"\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\EP3.MDB";

            ByteArray1 = File.ReadAllBytes(File1);
            ByteArray2 = File.ReadAllBytes(File2);

            if (ByteArray1.SequenceEqual<byte>(ByteArray2) == true)
            {
                btnComoEsta.Text = "Atualizado !";

            }
            else
            {
                btnComoEsta.Visible = false;
                btnAtualizar.Visible = true;
                
            }
        }
                
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListagem _frmListagem = new frmListagem();
            _frmListagem.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
            btnComoEsta.Visible = true;
            btnAtualizar.Visible = false;
            btnComoEsta.Text = " Atualizado ";
        }

        private void btnComoEsta_MouseUp(object sender, MouseEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Comparar();
            }
            
        }

        private void btnComoEsta_MouseDown(object sender, MouseEventArgs e)
        {
            btnComoEsta.Text = " Aguarde ...";
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
