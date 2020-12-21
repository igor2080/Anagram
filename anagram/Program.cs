using System;
using static Anagram.Anagram;

namespace anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = "";
            while (true)
            {
                Console.WriteLine("Enter the text to reverse: ");
                input = Console.ReadLine();
                if(!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(ReverseAnagram(input));
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("The text was empty. Please enter valid text.");
            }
            


        }
    }
}
