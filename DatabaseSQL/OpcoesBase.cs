using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQL
{
    public class OpcoesBase : Attribute
    {
        public bool UsarNoBancoDeDados { get; set; }
        public bool UsarParaBuscar { get; set; }
        public bool ChavePrimaria { get; set; }
    }
}
