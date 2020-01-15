using System;

namespace CountWords
{
    public class CountWordsClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountWords("Hello")); // Output: 1
            Console.WriteLine(CountWords("Hello World")); // Output: 2
            Console.WriteLine(CountWords("Lorem ipsum dolor sit amet")); // Output: 5
        }

        public static int CountWords(string value)
        {
            // Make this method to be able counting words

            return value.Split(' ').Length;
        }
    }
}
