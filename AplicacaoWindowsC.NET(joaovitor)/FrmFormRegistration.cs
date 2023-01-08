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
    public partial class FrmFormRegistration : Form
    {
        public FrmFormRegistration()
        {
            InitializeComponent();
        }

        private void FrmFormRegistration_Load(object sender, System.EventArgs e)
        {

            comboBoxState.DataSource = State.Lista();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var form = new FrmShowRegistration();
            form.lblName.Text = textName2.Text;
            form.lblAge.Text = textAge.Text;
            form.lblCity.Text = textCity.Text;
            form.lblState.Text = comboBoxState.Text;
            form.Show();
        }
    }
    public class State
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }

        public static List<State> Lista()
        {

            var lista = new List<State>();
            var e1 = new State
            {
                Id = 1,
                Nome = "SP"
            };
            lista.Add(e1);


            e1 = new State
            {
                Id = 2,
                Nome = "MG"
            };
            lista.Add(e1);


            e1 = new State
            {
                Id = 3,
                Nome = "SC"
            };
            lista.Add(e1);


            e1 = new State
            {
                Id = 4,
                Nome = "RJ"
            };
            lista.Add(e1);

            e1 = new State
            {
                Id = 5,
                Nome = "RS"
            };
            lista.Add(e1);

            e1 = new State
            {
                Id = 6,
                Nome = "PE"
            };
            lista.Add(e1);

            e1 = new State
            {
                Id = 7,
                Nome = "AC"
            };
            lista.Add(e1);

            e1 = new State
            {
                Id = 8,
                Nome = "SE"
            };
            lista.Add(e1);

            e1 = new State
            {
                Id = 9,
                Nome = "ES"
            };
            lista.Add(e1);

            e1 = new State
            {
                Id = 10,
                Nome = "GO"
            };
            lista.Add(e1);


            return lista;
        }
    }
}
