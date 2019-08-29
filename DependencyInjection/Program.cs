using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //SmsLogger sms = new SmsLogger();
            //sms.LogAt("fatal error!");

            //EMailLogger eMail = new EMailLogger();
            //eMail.LogAt("test error!");

            //ILogger logger = new EMailLogger();
            //logger.LogAt("test");

            LOgManager lOgManager = new LOgManager();
            // birinci yol
            lOgManager.Logger = new SmsLogger();
            lOgManager.LogAt(lOgManager.GetType().Name);


            lOgManager = new LOgManager(new EMailLogger());
            lOgManager.LogAt(lOgManager.GetType().Name);

            lOgManager.SetLogger(new XMLLogger());
            lOgManager.LogAt(lOgManager.GetType().Name);




            Console.ReadKey();
        }
    }
}
