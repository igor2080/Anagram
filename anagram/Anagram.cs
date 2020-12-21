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
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException("text", "The text cannot be empty.");
            

            string[] splitWords = text.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splitWords.Length; i++)
            {
                char[] wordReversed = Regex.Replace(splitWords[i], @"\p{L}", " ").ToCharArray();//non letters only
                char[] currentWordJustLetters = Regex.Replace(splitWords[i], @"[\W_\d]", "").ToCharArray().Reverse().ToArray();                

                //run over how many characters there are instead of the entire array
                for (int j = 0; j < currentWordJustLetters.Length; j++)
                {
                    //insert into the first empty space in the array
                    wordReversed[Array.IndexOf(wordReversed, ' ')] = currentWordJustLetters[j];

                }
                splitWords[i] = new string(wordReversed);
            }

            return string.Join(' ', splitWords);

        }
    }
}
