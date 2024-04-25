using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID
{
    public class DatabaseService
    {
        public void GetData()
        {
            Console.WriteLine("Getting data from database...");
        }
    }

    public class ApiController
    {
        private readonly DatabaseService _databaseService;

        public ApiController()
        {
            _databaseService = new DatabaseService(); // Dependencia concreta
        }

        public void GetDataFromDatabase()
        {
            _databaseService.GetData();
        }
    }

}
