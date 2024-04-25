using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    // Clase base
    public abstract class Figura2
    {
        public abstract double CalcularArea();
    }

    // Clase derivada corregida
    public class Cuadrado2 : Figura2
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
