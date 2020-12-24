using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Anagram.Anagram;

namespace AnagramTests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void ReverseAnagram_Are_Multiple_Words_Reversed()
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
        public void ReverseAnagram_Is_Single_Word_Reversed()
        {
            string input = "abc!d";
            string expectedOutput = "dcb!a";
            string actualOutput = ReverseAnagram(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void ReverseAnagram_Is_Symbol_Only_Unchanged()
        {
            string input = "12345!";
            string expectedOutput = "12345!";
            string actualOutput = ReverseAnagram(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "The text cannot be empty.")]
        public void ReverseAnagram_Empty_Returns_Exception()
        {
            string input = "";
            ReverseAnagram(input);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "The text cannot be empty.")]
        public void ReverseAnagram_Null_Returns_Exception()
        {
            string input = null;
            ReverseAnagram(input);
        }
        [TestMethod]
        public void ReverseAnagram_Only_Spaces_Unchanged()
        {
            string input = " ";
            string expectedOutput = "";
            string actualOutput = ReverseAnagram(input);
            Assert.AreEqual(expectedOutput, actualOutput);
            input = "                 ";
            expectedOutput = "";
            actualOutput = ReverseAnagram(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void ReverseAnagram_Many_Spaces_Words_Reversed()
        {
            string input = "       abc!d            ff$fe                      ";
            string expectedOutput = "dcb!a ef$ff";
            string actualOutput = ReverseAnagram(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
