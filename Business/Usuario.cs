using DatabaseSQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Business
{
    public class Usuario : Base
    {
        public Usuario(string nome, string telefone, string cpf, string idade, string cidade, string estado, string email, string sexo, string dataNascimento)
        {

            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
            this.Idade = idade;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Email = email;
            this.Sexo = sexo;
            this.DataNascimento= dataNascimento;
        }
        public Usuario(){ }
    }
}
