using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicacaoWindowsC.NET_joaovitor_
{
    public partial class FrmMultiplicationTable : Form
    {
        public FrmMultiplicationTable()
        {
            InitializeComponent();
        }

        private void FrmMultiplicationTable_Load(object sender, System.EventArgs e)
        {

            textBoxMultiTable.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new FrmMenu().Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxMultiTable.Text = "";
            textBoxMultiTable.Focus();
            listBox1.Items.Clear();
        }

        private void btnMultiTable_Click(object sender, EventArgs e)
        {
            int num = 0;
            num = Convert.ToInt32(textBoxMultiTable.Text);
            for (int a = 1; a <= 10; a++)
            {
                listBox1.Items.Add(num + " * " + a + "\n = " + num * a);
            }
        }
    }

    
}




/*public static void Tabuada() // Função criada sem repetir o codigo só chamando na Main
                                     // com o valor que quiser
        {

            int numero = TextBox.;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
        } */