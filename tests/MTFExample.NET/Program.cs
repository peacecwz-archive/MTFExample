using System;

namespace MTFExample.NET
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"{FrameworkTests.GetFramework()}");
            Console.WriteLine($"{FrameworkTests.GetConfigurationValue("TestKey")}");
        }
    }
}