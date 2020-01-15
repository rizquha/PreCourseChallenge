using System;

namespace LeapYear
{
    public class LeapYearClass
    {

        static public bool IsLeapYear(int args){
            return DateTime.IsLeapYear(args);
        }

        static void Main(string[] args)
        {
            // Create a method called IsLeapYear().
            // That method should accept a year as input.
            // The output should be a boolean.
            Console.Write("insert year : ");
            int inp = int.Parse(Console.ReadLine());
            Console.WriteLine(IsLeapYear(inp));
        }
    }
}
