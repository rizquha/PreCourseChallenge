using System;

namespace ToUpperCase
{
    public class ToUpperClass
    {
        static void Main(string[] args)
        {
            // Create a progam that be able to
            // transform all string into uppercase.

            // >> dotnet run okeoke
            
            Console.Write(args[0].ToUpper());
        }

        public static string toUpper(string str)
        {
            return str.ToUpper();
        } 
    }
}
