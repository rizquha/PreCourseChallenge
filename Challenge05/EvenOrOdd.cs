using System;

namespace EvenOdd
{
    public class EvenOrOdd
    {
        
        static public bool isOdd(int args){
            if(args%2 == 1)
                return true;

            else return false;
        }


        static public bool isEven(int args){
            if(args%2 == 0)
                return true;

            else return false;
        }
        

        static void Main(string[] args)
        {
            // Create new method with ability to detect odd or even number.
            // Example:
            // IsOdd(4) // false
            // IsEven(8) // true
            int inp = int.Parse(Console.ReadLine());
            Console.WriteLine("Is odd? " +  isOdd(inp));
            Console.WriteLine("Is even? " + isEven(inp));
        }
    }
}
