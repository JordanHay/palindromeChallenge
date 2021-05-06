using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string textToCheck = Console.ReadLine();
            Console.WriteLine(TextIsPalindrome(textToCheck));

            Console.ReadLine();
        }

      private static bool TextIsPalindrome(string text)
        {
            char[] backwards = text.Reverse().ToArray();
            char[] forwards = text.ToCharArray();

            string backwardsText = new string(backwards);

            bool output = (string.Compare(text, backwardsText) == 0);

            return output;
        }

    }

}



