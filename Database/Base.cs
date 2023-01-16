using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Database
{
    public abstract class Base : IPessoa
    {
        public Base(string nome, string telefone, string cpf, string idade, string cidade, string estado, string email, string sexo, string dataNascimento)
        {

            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
            this.Idade = idade;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Email = email;
            this.Sexo = sexo;
            this.DataNascimento = dataNascimento;

        }
        public Base()
        { }




        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Idade { get; set; }
        public string Cidade { get; set; }
        public string Sexo { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }

        public  void SetNome(string nome)
        {
            this.Nome = nome;
        }
        public void SetTelefone(string telefone)
        {
            this.Telefone= telefone;
        }
        public void SetCPF(string cpf)
        {
            this.CPF = cpf;
        }
        public void SetIdade(string idade)
        {
            this.Idade= idade;
        }
        public void SetCidade(string cidade)
        {
            this.Cidade= cidade;
        }
        public void SetEstado(string estado)
        {
            this.Estado= estado;
        }
        public void SetEmail(string email)
        {
            this.Email = email;
        }
        public void SetSexo(string sexo)
        {
            this.Sexo= sexo;
        }
        public void SetDataNascimento(string dataNascimento)
        {
            this.DataNascimento= dataNascimento;
        }

        public virtual List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(diretorio())) // Verificando se existe a variavel acima (diretório do arquivo no pc) //
            {
                using (StreamReader arquivo = File.OpenText(diretorio()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null) // Looping lendo cada linha do arquivo //
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');
                        var b = (IPessoa)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseArquivo[0]);
                        b.SetTelefone(baseArquivo[1]);
                        b.SetCPF(baseArquivo[2]);
                        b.SetIdade(baseArquivo[3]);
                        b.SetCidade(baseArquivo[4]);
                        b.SetEstado(baseArquivo[5]);
                        b.SetEmail(baseArquivo[6]);
                        b.SetSexo(baseArquivo[7]);
                        b.SetDataNascimento(baseArquivo[8]);
                        dados.Add(b);
                    }
                }
            }
            return dados;

        }

        private string diretorio()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"] + this.GetType().Name + ".txt";
        }

        public virtual void Gravar()
        {

            var dados = this.Ler();
            dados.Add(this);
            if (File.Exists(diretorio()))
            {
                string conteudo = "Nome;Telefone;CPF;Idade;Cidade;Estado;Email;Sexo;DataNascimento;\n";
                foreach (Base b in dados)
                { 
                    conteudo += b.Nome + ";" + b.Telefone + ";" + b.CPF + ";" + b.Idade + ";" + b.Cidade + ";" + b.Estado + ";" +
                        b.Email + ";" + b.Sexo + ";" + b.DataNascimento + ";\n";
                }

                File.WriteAllText(diretorio(), conteudo);
            }      
        }
    }
}
