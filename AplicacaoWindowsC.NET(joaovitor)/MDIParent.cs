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
            salvarArquivos.MdiParent = this;
            salvarArquivos.Show();
        }

        private void sobreMimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void repositóriosGitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var repositorioGitHub = new FrmStatsGitHub();
            repositorioGitHub.MdiParent = this;
            repositorioGitHub.Show();
        }

        private void formulárioCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioCadastro = new FrmRegistration();
            formularioCadastro.MdiParent = this;
            formularioCadastro.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabuada = new FrmMultiplicationTable();
            tabuada.MdiParent = this;
            tabuada.Show();
        }

        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var enviarEmail = new FrmSendEmail();
            enviarEmail.MdiParent = this;
            enviarEmail.Show();
        }

        private void dataEHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dataHora = new FrmDateHour();
            dataHora.MdiParent = this;
            dataHora.Show();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            var form = new Form1();
            form.MdiParent = this;
            form.Show();


            var contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Abrir Pagina Inicial", abrirForm1_Click));
            contextMenu.MenuItems.Add(new MenuItem("Fechar", fechar_Click));
            notifyIcon1.ContextMenu = contextMenu;
        }
        private void abrirForm1_Click(object sender, EventArgs e)
        {
            var abrirForm1 = new Form1();
            abrirForm1.MdiParent = this;
            abrirForm1.Show();
            
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importarArquivosComProgressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var importarArquivo = new FrmImport();
            importarArquivo.MdiParent = this;
            importarArquivo.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
