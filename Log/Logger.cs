using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Core;
namespace Log
{
    public static class Logger
    {
        public static void Write(string text)
        {
            var logger = new LoggerConfiguration().WriteTo.File(@"D:\Songs\Vedio\english\logFile.log").CreateLogger();
            logger.Information("Testing header");
            logger.Error(text);
        }
    }
}
