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
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FrmShowRegistration();
                form.lblName.Text = textName2.Text;
                form.lblCity.Text = textCity.Text;
                form.lblState.Text = comboBoxState.Text;
                int age = (int)Convert.ToInt64(textAge.Text);
                form.lblAge.Text = age.ToString();
                form.lblTel.Text = maskedTextBoxTelefone.Text;
                form.MdiParent = MDISingleton.InstanciaMDI();   
                form.Show();
                SaveAllText();
                Save();

            }
            catch
            {
                MessageBox.Show("Não use caracteres em Idade");
                textAge.Focus();
            }
            

        }

        private string SaveAllText ()
        {
            return ("Nome: " + textName2.Text  + "; " + "\n" + "Idade: " + textAge.Text + "; " + "\n" + "Cidade: " + textCity.Text + "; " + "\n" + "Estado: " + comboBoxState.Text
                + "; " + "\n" +   "Telefone: " + maskedTextBoxTelefone.Text + ";"
                );
        } 
        
        private void Save()
        {
            File.WriteAllText(@"C:\Users\Public\" + textName2.Text + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".txt", SaveAllText());
            MessageBox.Show("Texto Salvado com sucesso em : C:\\Users\\Public\\");
            textName2.Text = string.Empty;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmRegistration_Layout(object sender, LayoutEventArgs e)
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
