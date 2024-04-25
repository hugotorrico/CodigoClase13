using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
        }
    }

    public class ClaseAlta3
    {
        private readonly Logger _logger;

        public ClaseAlta3()
        {
            _logger = new Logger(); // Dependencia concreta
        }

        public void DoSomething()
        {
            _logger.Log("Doing something...");
        }
    }

}
