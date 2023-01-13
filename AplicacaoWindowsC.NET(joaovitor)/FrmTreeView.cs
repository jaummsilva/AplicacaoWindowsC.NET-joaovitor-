using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoWindowsC.NET_joaovitor_
{
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void FrmTreeView_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("estudos");
            var node = treeView1.Nodes[0];
            loadDiretorios(@"C:\Users\João\Downloads", ref node);
        }
        private void loadDiretorios (string diretorio, ref TreeNode node)
        {
            string[] arquivos = Directory.GetFiles(diretorio);
            foreach(string arquivo in arquivos)
            {
                node.Nodes.Add(Path.GetFileName(arquivo));
            }

            string[] subdiretorios = Directory.GetDirectories(diretorio);
            foreach (string subditorio in subdiretorios)
            {
                TreeNode n = new TreeNode(Path.GetFileName(subditorio));
                loadDiretorios(subditorio, ref n);
                node.Nodes.Add(n);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(readChecked(treeView1.Nodes[0]));
        }
        private string readChecked(TreeNode node, string checkeds = "")
        {
            foreach(TreeNode n in node.Nodes)
            {
                if(n.Checked)
                {
                    checkeds += n.Text + ", ";
                }
                checkeds = readChecked(n, checkeds);
            }
            return checkeds;
        }
    }
}
