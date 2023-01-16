using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Business
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Idade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string DataNascimento { get; set; }

        // public void Gravar()
        //{
          //  new DatabaseSQL.Usuario().Gravar(this.Nome, this.Telefone, this.CPF, this.Idade, this.Cidade, this.Estado, this.Sexo, this.DataNascimento);
        //}

        public override string ToString()
        {
            return this.Nome;
        }

        public static List<Usuario> Todos()
        {
            var list = new List<Usuario>();
            var tabela = new DatabaseSQL.Usuario().Todos();
            if(tabela.Rows.Count > 0)
            {
                foreach(DataRow row in tabela.Rows)
                {
                    list.Add(new Usuario()
                    {
                        CPF = row["cpf"].ToString(),
                        Telefone = row["telefone"].ToString(),
                        Nome = row["nome"].ToString(),
                        Email = row["email"].ToString(),
                        Idade = row["idade"].ToString()
                    }); 
                }
            }
            return list;

        }
    }
}
