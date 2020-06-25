using NLog;
using System;

namespace NlogTestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Logger logger = LogManager.GetLogger("databaseLogger");
            try
            {               
                int zero = 0;
                int result = 1 / zero;
                logger.Info("hi");

            }

            catch(DivideByZeroException ex)
            {
                
                logger.Error(ex, "whoops");
            }
        }
    }
}
