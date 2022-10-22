using System;

namespace HealthMonitoring
{
    public static class LoggingMethods
    {
        public static void LogToConsole(string message)
        {
            Console.Error.WriteLine(message);
        }
    }

}
