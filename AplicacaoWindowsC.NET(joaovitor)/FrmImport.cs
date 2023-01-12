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
using static System.Windows.Forms.LinkLabel;

namespace AplicacaoWindowsC.NET_joaovitor_
{

    public partial class FrmImport : Form
    {
        public FrmImport()
        {
            InitializeComponent();
        }

        private string[] lines;

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                progressBar.Value = (i + 1);
            }
            textBoxImportar.Text = "Todos os dados foram importados";
        }

        private void FrmImport_Load(object sender, EventArgs e)
        {
            string fileName = @"C:\db\dados_importar.txt";
            using (var streamReader = File.OpenText(fileName))
            {
               
                lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                progressBar.Maximum= lines.Length;
                progressBar.Minimum = 0;
            }       
        }
    }
}
