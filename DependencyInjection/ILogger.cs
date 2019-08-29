using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface ILogger
    {
        void LogAt(string text);
    }
}
