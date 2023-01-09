using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoWindowsC.NET_joaovitor_
{
    public class MDISingleton
    {
        private MDISingleton() { }
        private static MDIParent instanciaMDIParentePrincipal;

        public static MDIParent InstanciaMDI()
        {
            if (instanciaMDIParentePrincipal == null)
            {
                instanciaMDIParentePrincipal = new MDIParent();
                return instanciaMDIParentePrincipal;
            }
            return instanciaMDIParentePrincipal;
        }
    }
}
