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
    public partial class FrmPanel : Form
    {
        public FrmPanel()
        {
            InitializeComponent();
        }

        private void btnAlerta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("o dado digitado é:" + textBoxName3.Text);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GitHubStatsProjects.ListGitHub();
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
    }
}
