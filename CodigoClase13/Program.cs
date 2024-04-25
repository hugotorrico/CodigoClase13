Figura figura1 = new Rectangulo { Base = 5, Altura = 3 };
Figura figura2 = new Cuadrado { Lado = 4 };

Console.WriteLine("Área del rectángulo: " + figura1.CalcularArea()); // Salida: Área del rectángulo: 15
Console.WriteLine("Área del cuadrado: " + figura2.CalcularArea()); // Salida: Área del cuadrado: 16

// Violación del principio
Cuadrado cuadradoInvalido = new Rectangulo { Base = 2, Altura = 3 };
Console.WriteLine("Área del cuadrado inválido: " + cuadradoInvalido.CalcularArea()); // Salida: Área del cuadrado inválido: 6
Console.Read();