using ID;

//Objeto por el constructor, se le conoce como inyectar
//Inyección de Dependencias

Notificador notificador = new Notificador( new Email() );
notificador.SendNotificacion("Feliz Día del Padre");

Notificador notificador2 = new Notificador(new PUSH());
notificador2.SendNotificacion("Feliz Día de la Madre");


//Logger logger = new Logger(new FileLog());
//logger.Error("Mensaje de error");


Calculador calculador = new Calculador(new Cuadrado { Lado = 10 });
Calculador calculador2 = new Calculador(new Circulo { Radio = 10 });


IFigura figura = new Cuadrado();


Console.WriteLine(calculador.ObtenerArea());
Console.WriteLine(calculador2.ObtenerArea());



Console.Read();




