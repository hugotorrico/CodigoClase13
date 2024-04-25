using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID
{
    public interface IProcesador
    {
        void Procesar();
    }

    public class ProcesadorArchivo2 : IProcesador
    {
        public void Procesar()
        {
            Console.WriteLine("Procesando archivo...");
            // Lógica de procesamiento de archivo
        }
    }

    public class ClaseAlta2
    {
        private readonly IProcesador _procesador;

        public ClaseAlta2(IProcesador procesador)
        {
            _procesador = procesador; // Dependencia a través de la interfaz
        }

        public void EjecutarProcesamiento()
        {
            _procesador.Procesar();
        }
    }

}
