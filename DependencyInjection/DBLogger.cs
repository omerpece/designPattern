using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class DBLogger : ILogger
    {
        public void LogAt (string text)
        {
            Console.WriteLine($"-'{text}' degeri mail olarak atıldı");
        }
    }

    public class SmsLogger : ILogger
    {
        public void LogAt(string text)
        {
            Console.WriteLine($"-'{text}' degeri sms olarak atıldı");
        }
    }
    public class EMailLogger : ILogger
    {
        public void LogAt(string text)
        {
            Console.WriteLine($"-'{text}' degeri mail olarak atıldı");
        }
    }
    public class XMLLogger : ILogger
    {
        public void LogAt(string text)
        {
            Console.WriteLine($"-'{text}' degeri XMLmail olarak atıldı");
        }
    }
    public class FileLogger :ILogger
    {
        public void LogAt(string text)
        {
            Console.WriteLine($"-'{text}' degeri dosya olarak atıldı");
        }
    }


}

