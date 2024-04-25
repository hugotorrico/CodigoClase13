using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID
{
    public class FileLogger
    {
        public void LogToFile(string message)
        {
            Console.WriteLine($"Logging to file: {message}");
        }
    }

    public class LoggerService
    {
        private readonly FileLogger _fileLogger;

        public LoggerService()
        {
            _fileLogger = new FileLogger(); // Dependencia concreta
        }

        public void LogMessage(string message)
        {
            _fileLogger.LogToFile(message);
        }
    }

}
