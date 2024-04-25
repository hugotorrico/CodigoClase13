using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID
{
    public interface IFigura
    {
        public double CalcularArea();
    }

    public class Cuadrado : IFigura
    {
        public double Lado { get; set; }
        public double CalcularArea()
        {
            return Lado * Lado;
        }
    }
    public class Circulo : IFigura
    {
        public double Radio { get; set; }
        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }


    public class Calculador
    {
        private readonly IFigura _figura;
        public Calculador( IFigura figura)
        {
            _figura = figura;
        }

        public double ObtenerArea()
        {
            return _figura.CalcularArea();
        }

    }


}
