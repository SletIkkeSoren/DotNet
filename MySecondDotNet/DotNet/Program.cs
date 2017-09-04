using System;

namespace MySecondDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = WebHost().CreateDefaultBuilder().Use<Startup>().Build();
            host.Run();
        }
    }
}
