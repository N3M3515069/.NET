using System;
namespace SingletonPatternExample
{
    class Logger
    {
        private static Logger logger;
        private Logger(){}
        public static Logger GetInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }
        public void Log(string message)
        {
            Console.WriteLine("LOG: " + message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("First message");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Second message");

            Console.WriteLine(logger1 == logger2);

            Console.ReadKey();
        }
    }
}