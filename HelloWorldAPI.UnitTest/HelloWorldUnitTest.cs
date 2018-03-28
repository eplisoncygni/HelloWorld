using HelloWorld.BL.Interface;
using HelloWorld.BL.Model;
using HelloWorld.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloWorldAPI.UnitTest
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void TestGetHelloWorld()
        {
            var mockWorldService = new Mock<IHelloWorldService>();
            mockWorldService.Setup(x => x.HelloWorld(It.IsAny<HelloModel>())).Returns("HelloWorld");

            var controller = new HelloWorldController(mockWorldService.Object);

            var result = controller.GetHelloWorld();
            Assert.AreEqual("HelloWorld", result);
        }
    }
}
