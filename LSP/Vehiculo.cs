using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class Vehiculo
    {
        public abstract void Arrancar();
        public abstract void Detener();
    }

    public class Automovil : Vehiculo
    {
        public override void Arrancar()
        {
            Console.WriteLine("El automóvil arranca.");
        }

        public override void Detener()
        {
            Console.WriteLine("El automóvil se detiene.");
        }
    }

    public class Moto : Vehiculo
    {
        public override void Arrancar()
        {
            Console.WriteLine("La moto arranca.");
        }

        public override void Detener()
        {
            Console.WriteLine("La moto se detiene.");
        }
    }
    public class EjemploLSP
    {
        public void Conducir(Vehiculo vehiculo)
        {
            vehiculo.Arrancar();
            // Realizar otras operaciones con el vehículo
            vehiculo.Detener();
        }
    }

}
