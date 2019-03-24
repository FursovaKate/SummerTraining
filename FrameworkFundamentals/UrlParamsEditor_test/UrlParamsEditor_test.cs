using Microsoft.VisualStudio.TestTools.UnitTesting;
using UrlParamsEditor;

namespace UrlParamsEditor_test
{
    [TestClass]
    public class UrlHelperTest
    {
        [TestMethod]
        public void AddUrlParameterTest()
        {
           var url = "www.test.com";
           var parameter = "key=value";
           var expected = "www.test.com?key=value";
           var actual = UrlHelper.AddOrChangeUrlParameter(url, parameter);
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);

        }

        [TestMethod]
        public void ChangeUrlParameterTest()
        {
            var url = "www.test.com?key=value";
            var parameter = "key=test";
            var expected = "www.test.com?key=test";
            var actual = UrlHelper.AddOrChangeUrlParameter(url, parameter);
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void AddAnotherParameterTest()
        {
            var url = "www.test.com?key=value";
            var parameter = "test=test";
            var expected = "www.test.com?key=value&test=test";
            var actual = UrlHelper.AddOrChangeUrlParameter(url, parameter);
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
