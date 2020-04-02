using log4net;
using Prism.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismLoggerTest
{
    public class Logger : ILoggerFacade
    {
        private readonly ILog logger = LogManager.GetLogger(typeof(Logger));
        public void Log(string message, Category category, Priority priority)
        {
            switch(category)
            {
                case Category.Debug:
                    logger.Debug(message);
                    break;
                case Category.Exception:
                    logger.Error(message);
                    break;
                case Category.Info:
                    logger.Info(message);
                    break;
                case Category.Warn:
                    logger.Warn(message);
                    break;
            }
        }
    }
}
