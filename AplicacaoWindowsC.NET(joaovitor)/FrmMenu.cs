﻿using System;
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
    }
}