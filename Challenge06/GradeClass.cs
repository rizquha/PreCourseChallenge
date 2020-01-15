using System;

namespace Grade
{
    public class GradeClass
    {

        static public char Grade(int args){
            if(args >= 90)
                return 'A';
            
            else if(args >= 80 && args < 90)
                return 'B';

            else if(args >= 70 && args < 80)
                return 'C';

            else if(args >= 60 && args < 70)
                return 'D';

            else if(args < 60)
                return 'E';

            else
                return '0';

        }


        static void Main(string[] args)
        {
            // Create a method called Grade()
            // That method should accept an integer with some criteria
            // 1) If the input more than 90 the output will be "A"
            // 2) If the input within range 80 to 89 the output will be "B"
            // 3) If the input within range 70 to 79 the output will be "C"
            // 4) If the input within range 60 to 69 the output will be "D"
            // 5) If the input below 59 the output will be "E"
            Console.Write("Input numeric value : ");
            int inp = int.Parse(Console.ReadLine());
            Console.WriteLine("Grade is : " + Grade(inp));
        }
    }
}
