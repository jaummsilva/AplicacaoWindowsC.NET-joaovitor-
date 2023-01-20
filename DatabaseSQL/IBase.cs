using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQL
{
    public interface IBase
    {
        string Key { get; }
        void Salvar();
        List< IBase> Todos();
        List< IBase> Busca();
    }
}
