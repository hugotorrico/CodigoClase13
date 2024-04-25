using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI
{
    public interface IAdminArchivo
    {
        void CrearArchivo();
        void EliminarArchivo();
        void CopiarArchivo();
        void MoverArchivo();
        void ComprimirArchivo();
        void DescomprimirArchivo();
    }
}
