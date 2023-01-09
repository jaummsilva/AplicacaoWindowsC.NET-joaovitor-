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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void repositóriosGitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmStatsGitHub().Show();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void salvarArquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSave().Show();
        }

        private void formulárioCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRegistration().Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMultiplicationTable().Show();
        }

        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSendEmail().Show(); 
        }

        private void dataEHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDateHour().Show();   
        }
    }
}
