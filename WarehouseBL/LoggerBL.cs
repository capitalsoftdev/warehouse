using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseBL
{
    public static class LoggerBL 
    {
        private static ILogger _logger;

        public static ILogger Logger
        {
            get
            {
                if (_logger == null)
                    throw new Exception("Logger not configured");
                else
                    return _logger;
            }

            set
            {
                _logger = value;
            }
        }
    }
}
