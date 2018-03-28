using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.BL.Interface;
using HelloWorld.BL.Model;

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        private readonly IHelloWorldService _helloWorldService;

        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        // GET api/helloworld
        [HttpGet]
        public string GetHelloWorld()
        {
            var hello = new HelloModel();
            return _helloWorldService.HelloWorld(hello);
        }


    }
}
