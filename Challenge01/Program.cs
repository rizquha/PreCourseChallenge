using System;

namespace YourName
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Get your name by using Console.ReadLine()
            // Example output: "Hello, my name is Salamander.",
            // depends on user input.

            Console.Write("Input your name : ");
            String name = Console.ReadLine();
            string name1 = nama(name);
            Console.WriteLine("Hello, my name is {0}.", name);
        }
        public static string nama(string str)
        {
            return str;
        }
    }
}
