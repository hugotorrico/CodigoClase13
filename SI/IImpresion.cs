using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI
{
    public interface IImpresion
    {
        void ImprimirDocumento();
        void EscanearDocumento();
        void EnviarFax();
    }
}
