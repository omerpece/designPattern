using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
   public class LOgManager
    {
        private ILogger _logger;
        public ILogger Logger
        {
            set { _logger = value; } // birinci dependency injection
        }

        public LOgManager()
        {

        }
        public LOgManager(ILogger logger)
        {
            _logger = logger; // ikinci dependency injection
        }
        public void SetLogger(ILogger logger)
        {
            this._logger = logger; // üçüncü depencency injection
        }



        public void LogAt(string text)
        {
            _logger.LogAt(text);
        }


    }
}
