using System;
using HelloWorld.Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    [TestClass]
    public class MessageRepoTests
    {
        [TestMethod]
        public void VerifyGetMessageReturnsHelloWorld()
        {
            IMessageRepo messageRepo = new MessageRepo();
            Assert.AreEqual("Hello World!", messageRepo.GetMessage());
        }
    }
}
