
using LSP;

Cuadrilatero cuadrilatero = new Cuadrado { lado = 10 };
Rectangulo cuadrilatero1 = new Rectangulo { base1 = 10, altura=20 };

//rectangulo
Console.WriteLine(cuadrilatero1.CalcularArea());
Console.WriteLine(cuadrilatero1.CalcularDobleBase());


//cuadrado
Console.WriteLine(cuadrilatero.CalcularArea());
//Console.WriteLine(cuadrilatero.CalcularDobleBase());


Console.Read();



