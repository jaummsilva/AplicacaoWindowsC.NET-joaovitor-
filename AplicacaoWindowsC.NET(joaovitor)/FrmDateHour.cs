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
    public partial class FrmDateHour : Form
    {
        public FrmDateHour()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDateHour_Load(object sender, EventArgs e)
        {
            refreshSeconds();
            refreshMinutes();
            refreshHour();
        }

        private void refreshHour()
        {
            lblHours.Text = "Dia e hora atual: " + DateTime.Now.ToString("dd/MM/yyyy | HH:mm");
        }

        private void refreshMinutes()
        {
            lblMinutes.Text = "Dia e hora atual: " + DateTime.Now.ToString("dd/MM/yyyy | HH:mm");
        }

        private void refreshSeconds()
        {
            lblSeconds.Text = "Dia e hora atual: " + DateTime.Now.ToString("dd/MM/yyyy | HH:mm:ss");
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            refreshSeconds();
        }

        private void timerMinutes_Tick(object sender, EventArgs e)
        {
            refreshMinutes();
        }

        private void timerHours_Tick(object sender, EventArgs e)
        {
            refreshHour();
        }
    }
}
