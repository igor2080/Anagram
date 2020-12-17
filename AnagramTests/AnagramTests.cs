using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Anagram.Anagram;

namespace AnagramTests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void AreMultipleWordsReversed()
        {
            string input1 = "abcd efgh";
            string input2 = "a1bcd efg!h";

            string expectedOutput1 = "dcba hgfe";
            string expectedOutput2 = "d1cba hgf!e";

            string actualOutput1 = ReverseAnagram(input1);
            string actualOutput2 = ReverseAnagram(input2);            

            Assert.AreEqual(expectedOutput1, actualOutput1);
            Assert.AreEqual(expectedOutput2, actualOutput2);
        }
        [TestMethod]
        public void IsSingleWordReversed()
        {
            string input = "abc!d";
            string expectedOutput = "dcb!a";
            string actualOutput = ReverseAnagram(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void IsSymbolOnlyAccepted()
        {
            string input = "12345!";
            string expectedOutput = "12345!";
            string actualOutput = ReverseAnagram(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
