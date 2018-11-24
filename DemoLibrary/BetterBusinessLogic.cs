using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using DemoLibrary.Utilities;

namespace DemoLibrary
{
    class BetterBusinessLogic :IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess; 
        }

        public void ProcessData()
        { 
            _logger.Log("Starting the processing data.");
            Console.WriteLine();
            Console.WriteLine("Proseesing the data.");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            Console.WriteLine();
            _logger.Log("Finished processing of the data.");
            Console.WriteLine();
        }
    }
}
