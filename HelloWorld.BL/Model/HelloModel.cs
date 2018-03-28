using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.BL.Model
{
    public class HelloModel
    {
        private string hello;
        private string world;

        public string Hello
        {
            get
            {
                return hello ?? "Hello";
            }
            set
            {
                hello = value;
            }
        }
        public string World
        {
            get
            {
                return world ?? "World";
            }
            set
            {
                world = value;
            }
        }
    }
}
