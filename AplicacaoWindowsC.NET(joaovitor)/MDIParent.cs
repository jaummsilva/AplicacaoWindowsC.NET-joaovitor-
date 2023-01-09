using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoWindowsC.NET_joaovitor_
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarArquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var salvarArquivos = new FrmSave();
            salvarArquivos.MdiParent = MDISingleton.InstanciaMDI();
            salvarArquivos.Show();
        }

        private void sobreMimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.MdiParent = MDISingleton.InstanciaMDI();
            form.Show();
        }

        private void repositóriosGitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var repositorioGitHub = new FrmStatsGitHub();
            repositorioGitHub.MdiParent = MDISingleton.InstanciaMDI();
            repositorioGitHub.Show();
        }

        private void formulárioCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioCadastro = new FrmRegistration();
            formularioCadastro.MdiParent = MDISingleton.InstanciaMDI();
            formularioCadastro.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabuada = new FrmMultiplicationTable();
            tabuada.MdiParent = MDISingleton.InstanciaMDI();
            tabuada.Show();
        }

        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var enviarEmail = new FrmSendEmail();
            enviarEmail.MdiParent = MDISingleton.InstanciaMDI();
            enviarEmail.Show();
        }

        private void dataEHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dataHora = new FrmDateHour();
            dataHora.MdiParent = MDISingleton.InstanciaMDI();
            dataHora.Show();
        }
    }
}
