using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.JScript;

namespace DatabaseSQL
{
    public class Usuario
    {
        private string connectionString;
        public Usuario() {
            connectionString = ConfigurationManager.AppSettings["sqlConnection"];
        }


        //public void Gravar(string nome, string telefone, string cpf, string idade, string cidade, string estado, string email, string sexo, string dataNascimento)
        //{
        //  using (SqlConnection connection = new SqlConnection(
        //               connectionString))
        //{
        //  string queryString = "insert into usuarios (nome, telefone, cpf, idade, cidade, estado, email, sexo, data_nascimento)values('" + this.Nome + "', '" + this.Telefone + "', '" + this.CPF + "', '" + this.Idade + "', '" + this.Cidade + "', '" + this.Estado + "', '" + this.Email + "', '" + this.Sexo + "', '" + this.DataNascimento + "')";
        //SqlCommand command = new SqlCommand(queryString, connection);
        //command.Connection.Open();
        //command.ExecuteNonQuery();
        //}
        //}

        public DataTable Todos()
        {
            using (SqlConnection connection = new SqlConnection(
                           connectionString))
            {
                string queryString = "select * from usuarios";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;

            }
        }

    }
}
