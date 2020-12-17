using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace Anagram
{
    public static class Anagram
    {
        public static string ReverseAnagram(string text)
        {
            string[] splitWords = text.Split(' ');
            for (int i = 0; i < splitWords.Length; i++)
            {
                char[] currentWordWithoutLetters = Regex.Replace(splitWords[i], @"[a-zA-Z]", " ").ToCharArray();
                char[] currentWordWithoutNumbers = Regex.Replace(splitWords[i], @"[^a-zA-Z]", "").ToCharArray().Reverse().ToArray();
                char[] wordReversed = new char[currentWordWithoutLetters.Length];

                currentWordWithoutLetters.CopyTo(wordReversed, 0);

                //run over how many characters there are instead of the entire array
                for (int j = 0; j < currentWordWithoutNumbers.Length; j++)
                {
                    //insert into the first empty space in the array
                    wordReversed[Array.IndexOf(wordReversed, ' ')] = currentWordWithoutNumbers[j];

                }
                splitWords[i] = new string(wordReversed);
            }

            return string.Join(' ', splitWords);

        }
    }
}
