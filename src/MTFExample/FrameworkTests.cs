using System;

namespace MTFExample
{
    public class FrameworkTests
    {
        public static string GetFramework()
        {
            string message = "";
#if NETCOREAPP2_0
            message = "This is .NET Core App 2.0";
#elif NETCOREAPP2_1
            message = "This is .NET Core App 2.1";
#elif NETSTANDARD2_0
            message = "This is .NET Standard 2.0";
#endif

            return message;
        }
    }
}