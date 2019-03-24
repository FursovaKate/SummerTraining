using Microsoft.VisualStudio.TestTools.UnitTesting;
using OccurrencesFinder;

namespace OccurrencesFinder_test
{
    [TestClass]
    public class OccurrencesFinderTest
    {
        [TestMethod]
        public void FindOccurencesTest()
        {
            var inputList = FileReader.ReadFile();
            var actual = OccurrencesFinder.FindOccurences(inputList, "Fox");
            var expected = 1;
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
