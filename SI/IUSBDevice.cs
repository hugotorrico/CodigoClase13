using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI
{
    public interface IUSBDevice
    {
        void Conectar();
        void Desconectar();
        void LeerDatos();
        void EscribirDatos();
    }
}
