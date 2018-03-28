using HelloWorld.BL.Interface;
using HelloWorld.BL.Model;
using HelloWorld.BL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //settingup DI
            var services = new ServiceCollection()
                .AddTransient<IHelloWorldService, HelloWorldService>();
            var serviceProvider = services.BuildServiceProvider();
            
            //getting service instance
            var appService = serviceProvider.GetService<IHelloWorldService>();
            
            var result =  appService.HelloWorld(new HelloModel());
            
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
