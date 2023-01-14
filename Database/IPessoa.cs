using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Database
{
    public interface IPessoa
    {
        void SetNome(string nome);
        void SetTelefone(string telefone);
        void SetCPF(string cpf);
        void SetIdade(string idade);
        void SetCidade(string cidade);
        void SetEstado(string estado);
        void SetEmail(string email);
        void SetSexo(string sexo);
        void SetDataNascimento(string dataNascimento);


        void Gravar();
    }
}
