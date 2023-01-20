using DatabaseSQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DatabaseSQL
{
    public class Base : IBase
    {
        private string connectionString = ConfigurationManager.AppSettings["SqlConnection"];
        private string connectionstring;

        public string Key
        {
            get
            {
                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    OpcoesBase pOpcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                      if (pOpcoesBase != null && pOpcoesBase.ChavePrimaria)
                    {
                        return Convert.ToString(pi.GetValue(this));
                    }
                }
                return null;
            }
        }


        public virtual void Salvar()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                List<string> campos = new List<string>();
                List<string> valores = new List<string>();

                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    OpcoesBase pOpcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                      if (pOpcoesBase != null && pOpcoesBase.UsarNoBancoDeDados)
                    {
                        campos.Add(pi.Name);
                        valores.Add("'" + pi.GetValue(this) + "'");
                    }
                }

                string queryString = "insert into " + this.GetType().Name + "s (" + string.Join(", ", campos.ToArray()) + "values(" + string.Join(", ", valores.ToArray());


                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public static List<Usuario> Todos()
        {
            var list = new List<Usuario>();
            var tabela = new DatabaseSQL.Usuario().Todos();
            if (tabela.Rows.Count > 0)
            {
                foreach (DataRow row in tabela.Rows)
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
