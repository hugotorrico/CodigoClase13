using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class  Cuadrilatero
    {       
        public abstract double CalcularArea();       
    }

    public class Cuadrado : Cuadrilatero
    {
        public int lado { get; set; }
        public override double CalcularArea()
        {
            return lado * lado;
        }      
    }

    public class Rectangulo : Cuadrilatero
    {
        public int base1 { get; set; }
        public int altura { get; set; }
        public override double CalcularArea()
        {
            return base1 * altura;
        }

        public double CalcularDobleBase()
        {
            return base1 * 2;
        }
    }

}
