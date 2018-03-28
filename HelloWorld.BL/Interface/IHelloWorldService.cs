using HelloWorld.BL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.BL.Interface
{
    public interface IHelloWorldService
    {
        string HelloWorld(HelloModel helloModel);
    }
}
