using System;
#if NET472
    using System.Configuration;
#elif NETCOREAPP2_0
    using Microsoft.Extensions.Configuration;
    using System.IO;
#elif NETCOREAPP2_1
    using Microsoft.Extensions.Configuration;
    using System.IO;
#endif

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
#elif NET472
            message = "This is .NET Framework 4.7.2";
#elif NETSTANDARD2_0
            message = "This is .NET Standard 2.0";
#else
            message = "Cannot detect your framework";
#endif

            return message;
        }

        public static string GetConfigurationValue(string key)
        {
            string value = "";

#if NET472
            value = ConfigurationManager.AppSettings[key];
#elif NETCOREAPP2_0 || NETCOREAPP2_1
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .Build();
            value = configuration[key];
#else
            value = $"Cannot find {key} from any target";      
#endif
            
            return value;
        }
    }
}