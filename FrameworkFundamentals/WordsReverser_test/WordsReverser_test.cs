using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordsReverser;

namespace WordsReverser_test
{
    [TestClass]
    public class WordsReverserTest
    {
        [TestMethod]
        public void ReverseWordsFirstTest()
        {
            var input = "The greatest victory is that which requires no battle";
            var actual = WordsReverser.ReverseWords(input);
            var expected = "battle no requires which that is victory greatest The";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void ReverseWordsSecondTest()
        {
            var input = "The quick brown fox";
            var actual = WordsReverser.ReverseWords(input);
            var expected = "fox brown quick The";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void ReverseWordsThirdTest()
        {
            var input = "Doctor";
            var actual = WordsReverser.ReverseWords(input);
            var expected = "Doctor";
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
