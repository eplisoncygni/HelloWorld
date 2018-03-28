using HelloWorld.BL.Interface;
using HelloWorld.BL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.BL.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        public string HelloWorld(HelloModel helloWorld)
        {
            return ($"{helloWorld.Hello}{helloWorld.World}");
        }
    }
}
