using ConsoleApp3.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace DatabaseSQL
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




        public string Nome;
        public string Telefone;
        public string CPF;
        public string Idade;
        public string Cidade;
        public string Sexo;
        public string DataNascimento;
        public string Email;
        public string Estado;

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }
        public void SetTelefone(string telefone)
        {
            this.Telefone = telefone;
        }
        public void SetCPF(string cpf)
        {
            this.CPF = cpf;
        }
        public void SetIdade(string idade)
        {
            this.Idade = idade;
        }
        public void SetCidade(string cidade)
        {
            this.Cidade = cidade;
        }
        public void SetEstado(string estado)
        {
            this.Estado = estado;
        }
        public void SetEmail(string email)
        {
            this.Email = email;
        }
        public void SetSexo(string sexo)
        {
            this.Sexo = sexo;
        }
        public void SetDataNascimento(string dataNascimento)
        {
            this.DataNascimento = dataNascimento;
        } 
        public virtual void Gravar()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlConnection"];
            using (SqlConnection connection = new SqlConnection(
                           connectionString))
            {
                string queryString = "insert into " + this.GetType().Name + "s (nome, telefone, cpf, idade, cidade, estado, email, sexo, data_nascimento)values('" + this.Nome +  "', '" + this.Telefone + "', '" + this.CPF + "', '" + this.Idade + "', '" + this.Cidade + "', '" + this.Estado + "', '" + this.Email + "', '" + this.Sexo + "', '" + this.DataNascimento + "')";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        }
    }
