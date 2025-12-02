using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


//"Hello world" -- 2

//"Hello world Hello world" -- 4

namespace ExtensitonMethodsNamepsace
{

    public static class StringExtensions
    {
        public static int WordCount(this string input)   //Hello world
        {
            string[] words = input.Split(' ');   //["Hello" , "World"]
            int wordsLength = words.Length;
            return wordsLength;
        }

    }


    class Program
    {
        static void Main()
        {
            string sentence = "Hello world";
            int wordsCount = sentence.WordCount();

            // Displaying the result
            Console.WriteLine($"Word count: {wordsCount}");
        }
    }

}