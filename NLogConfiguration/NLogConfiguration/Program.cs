using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Trace("trace message");
            logger.Debug("debug message");
            logger.Info("info message");
            logger.Warn("warn message");
            logger.Error("error message");
            logger.Fatal("fatal message");
            logger.Log(LogLevel.Info, "log message");
        }
    }
}
