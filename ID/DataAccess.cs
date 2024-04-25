using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID
{
    public class DataAccess
    {
        public void SaveData(string data)
        {
            Console.WriteLine($"Saving data: {data}");
        }
    }

    public class ReportGenerator
    {
        private readonly DataAccess _dataAccess;

        public ReportGenerator()
        {
            _dataAccess = new DataAccess(); // Dependencia concreta
        }

        public void GenerateReport(string reportData)
        {
            _dataAccess.SaveData(reportData);
        }
    }

}
