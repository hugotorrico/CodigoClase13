using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{

    //Todos los empledaos se puede calcular su sueldo
    //Todos los gerentes se puede calcular una bonificacion
    public abstract class Empleado
    {        
        public abstract double CalcularSueldo();
    }
    public class Programador : Empleado
    {

        public override double CalcularSueldo()
        {
            throw new NotImplementedException();
        }
    }

    public class Analista : Empleado
    {

        public override double CalcularSueldo()
        {
            throw new NotImplementedException();
        }
    }
    public class Gerente : Empleado
    {
        public  double CalcularBonificacion()
        {
            return 1000;
        }

        public override double CalcularSueldo()
        {
            throw new NotImplementedException();
        }
    }

   


}
