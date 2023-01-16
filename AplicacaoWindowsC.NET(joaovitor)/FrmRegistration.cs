using ConsoleApp3.Business;
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
using System.Windows.Forms.VisualStyles;

namespace AplicacaoWindowsC.NET_joaovitor_
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, System.EventArgs e)
        {

            comboBoxState.DataSource = State.Lista();
            comboBoxUsuarios.DataSource = Usuario.Todos();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            TabPage.SelectTab("tabPage2");
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmRegistration_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                var usuario = new Usuario();
                usuario.Nome = textName2.Text;
                usuario.CPF = maskedTextBoxCPF.Text;
                usuario.Telefone = maskedTextBoxTelefone.Text;
                usuario.Email = textBoxEmail.Text;
                usuario.Cidade = textCity.Text;
                usuario.Estado = comboBoxState.Text;
                usuario.DataNascimento = maskedTextBoxDN.Text;
                usuario.Idade = textAge.Text;
                usuario.Sexo = textBoxSexo.Text;
                //usuario.Gravar();
                MessageBox.Show("Usuario gravado com sucesso");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)comboBoxUsuarios.SelectedValue;
            lblMostrarCPF.Text = usuario.Nome;
            lblMostrarTelefone.Text = usuario.Telefone;
            lblMostrarIdade.Text = usuario.Idade;
            lblMostrarEmail.Text = usuario.Email;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

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
