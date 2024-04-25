using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID
{
    public interface ILog
    {
        public void WriteError(string error);
        public void WriteSucess(string error);
    }

    public class FileLog : ILog
    {
        public void WriteError(string error)
        {
            throw new NotImplementedException();
        }

        public void WriteSucess(string error)
        {
            throw new NotImplementedException();
        }
    }

    public class DatabaseLog : ILog
    {
        public void WriteError(string error)
        {
            throw new NotImplementedException();
        }

        public void WriteSucess(string error)
        {
            throw new NotImplementedException();
        }
    }


    //Console.WriteLine($"Logging: {message}");

    public class Logger
    {
        private readonly ILog _log;//Variable privada dentro la clase

        public Logger(ILog log)
        {
            _log = log;
        }
        public void Error(string error)
        {           
            _log.WriteError(error);
        }
        public void Sucess(string error)
        {
            _log.WriteSucess(error);
        }
    }

  

}
