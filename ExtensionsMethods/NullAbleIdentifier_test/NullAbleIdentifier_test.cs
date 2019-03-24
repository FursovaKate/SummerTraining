using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullAbleIdentifier;

namespace NullAbleIdentifier_test
{
    [TestClass]
    public class CheckIfNullTest
    {
        [TestMethod]
        public void CheckIfObjectIsNull_expectedFalse()
        {
            int? inputNullable = 345;
            bool actual = inputNullable.IsNull();
            bool expected = false;
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
