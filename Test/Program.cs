using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"D:\games\logFile.log").CreateLogger();
            Log.Information("Testing header");
            try
            {
                Log.Debug("something");
                throw new NotImplementedException();
                
               
            }
            catch (Exception ex)
            {
                Log.Error(ex,"Error kaveen");
            }
            finally
            {
                Log.CloseAndFlush();
                Console.WriteLine("Completed");
                Console.ReadKey();
            }
        }
    }
}
