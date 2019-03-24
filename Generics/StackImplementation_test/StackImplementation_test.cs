using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackImplementation;

namespace StackImplementation_test
{
    [TestClass]
    public class IteratorTest
    {
        ClientClass client = new ClientClass();

        [TestMethod]
        public void GetPreviousTest()
        {
            var inputStack = new List<int>();
            for (var i = 0; i < 6; i++)
            {
                inputStack.Add(i);
            }
            var position = 2;
            var actual = client.GetIterator(inputStack, position).GetPrevious();
            var expected = 1;
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void GetNextTest()
        {
            var inputStack = new List<int>();
            for (var i = 0; i < 6; i++)
            {
                inputStack.Add(i);
            }
            var position = 2;
            var actual = client.GetIterator(inputStack, position).GetPrevious();
            var expected = 1;
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void CountElementsTest()
        {
            var inputStack = new List<int>();
            for (var i = 0; i < 6; i++)
            {
                inputStack.Add(i);
            }
            var actual = client.GetIterator(inputStack, 0).CountElements();
            var expected = 6;
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void AddElementsTest()
        {
            var inputSet = new List<int>() { 1, 2, 3, 4, 5 };
            var numberToAdd = 6;
            client.GetIterator(inputSet, 0).AddElement(numberToAdd);
            var actual = inputSet.Count;
            var expected = 6;
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void RemoveElementsTest()
        {
            var inputSet = new List<int>() { 1, 2, 3, 4, 5 };
            client.GetIterator(inputSet, 0).RemoveElement(4);
            var actual = inputSet.Count;
            var expected = 4;
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
