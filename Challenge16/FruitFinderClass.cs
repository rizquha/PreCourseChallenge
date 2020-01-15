using System;

namespace FruitFinder
{
    public class FruitFinderClass
    {
        static void Main(string[] args)
        {
            string[] fruits = {
                "Jeruk",
                "Apel",
                "Anggur",
                "Pepaya",
                "Pisang",
                "Kiwi",
                "Markisa",
            };

            // Find the index of a fruit
            Console.WriteLine(IndexFinder(fruits, "Jeruk")); // Output: 0
            Console.WriteLine(IndexFinder(fruits, "Pepaya")); // Output: 3
            Console.WriteLine(IndexFinder(fruits, "Markisa")); // Output: 6
        }

        public static int IndexFinder(string[] list, string value)
        {
            int ln = list.Length;
            for(int i=0; i<ln; i++){
                if(list[i] == value)
                    return i;
            }

            return 99;
        }
    }
}
