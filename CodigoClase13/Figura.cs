// Clase base
public class Figura
{
    public virtual double CalcularArea()
    {
        return 0;
    }
}

// Clase derivada
public class Rectangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}

// Clase derivada
public class Cuadrado : Figura
{
    public double Lado { get; set; }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}