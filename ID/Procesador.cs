using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID
{
    public class ProcesadorArchivo
    {
        public void Procesar()
        {
            Console.WriteLine("Procesando archivo...");
            // Lógica de procesamiento de archivo
        }
    }

    public class ClaseAlta
    {
        private readonly ProcesadorArchivo _procesador;

        public ClaseAlta()
        {
            _procesador = new ProcesadorArchivo(); // Dependencia concreta
        }

        public void EjecutarProcesamiento()
        {
            _procesador.Procesar();
        }
    }




}
