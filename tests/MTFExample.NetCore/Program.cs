using System;

namespace MTFExample.NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{FrameworkTests.GetFramework()}");
            Console.WriteLine($"{FrameworkTests.GetConfigurationValue("TestKey")}");
        }
    }
}