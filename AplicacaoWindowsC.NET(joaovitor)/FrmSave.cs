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
    public partial class FrmSave : Form
    {
        public FrmSave()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            File.WriteAllText(@"c:\db\" + textBoxName.Text + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".txt", textBoxSave.Text
                );
            MessageBox.Show("Texto Salvado com sucesso");
            textBoxSave.Text = string.Empty;
        }
    }
}
