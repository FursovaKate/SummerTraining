using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountDown;

namespace CountDown_test
{
    [TestClass]
    public class EventListenerTest
    {
        [TestMethod]
        public void PrintMessageTest()
        {
            var userInput = 2000;
            Broadcaster broadcaster = new Broadcaster();
            broadcaster.OnCountDown += EventListener.PrintMessage;
            broadcaster.CountDown(userInput);
            Assert.IsTrue(true);
        }
    }
}
