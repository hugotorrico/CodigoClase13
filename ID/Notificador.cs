using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID
{

    //Inversión de Dependencias
    public interface INotificacion
    {
        public void Send(string message);
    }

    public class Email: INotificacion
    {
        public void Send(string message)
        {
            Console.WriteLine("Enviado Email:" );
            Console.WriteLine(message);
        }
    }
 
    public class PUSH : INotificacion
    {
        public void Send(string message)
        {
            Console.WriteLine("Enviado PUSH:");
            Console.WriteLine(message);
        }
    }

    public class SMS : INotificacion
    {
        public void Send(string message)
        {
            Console.WriteLine("Enviado SMS:");
            Console.WriteLine(message);
        }
    }

    public class Mailing : INotificacion
    {
        public void Send(string message)
        {
            Console.WriteLine("Enviado Mailing:");
            Console.WriteLine(message);
        }
    }

    public class Whatsapp : INotificacion
    {
        public void Send(string message)
        {
            Console.WriteLine("Enviado Whatsapp:");
            Console.WriteLine(message);
        }
    }

    public class Notificador
    {

        private readonly INotificacion _notificacion;

        public Notificador(INotificacion notificacion)
        {
            _notificacion = notificacion;
        }

        public void SendNotificacion( string message)
        {
            _notificacion.Send(message);
        }

        public void SendNotificacionMasivo( string message)
        {
            for (int i = 0; i < 10; i++)
            {
                _notificacion.Send(message);
            }
            
        }

    }
}
