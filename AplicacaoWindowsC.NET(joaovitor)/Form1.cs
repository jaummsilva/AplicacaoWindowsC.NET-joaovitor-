using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoWindowsC.NET_joaovitor_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnForm1_Click(object sender, EventArgs e)
        {
            new FrmMenu().Show();
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/jaumm.silva/");
        }

        private void linkLabelInstragram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/jo%C3%A3ovitordasilva/");
        }

        private void linkLabelLinkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/jo%C3%A3ovitordasilva/");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Abrir Pagina Inicial", abrirForm1_Click));
            contextMenu.MenuItems.Add(new MenuItem("Fechar", fechar_Click));
            notifyIcon1.ContextMenu = contextMenu;

        }

        private void abrirForm1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
